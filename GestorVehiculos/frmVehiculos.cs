using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorVehiculos
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
            CargarTipos(); //Al abrir el formulario, cargamos los tipos de vehículo en el combo
            CargarVehiculos(); //También cargamos los vehículos en la DataGridView
        }

        //CargarTipos() --> Este método carga los tipos de vehículo en el ComboBox
        private void CargarTipos()
        {
            try
            {
                using (var db = new ParkingEntities()) //Abrimos conexión con la base de datos
                {
                    var tipos = db.TiposVehiculo.ToList(); //Sacamos todos los tipos
                    cmbTipo.DataSource = tipos; //Los asignamos como fuente de datos del ComboBox
                    cmbTipo.DisplayMember = "Nombre"; //Mostramos el nombre del tipo
                    cmbTipo.ValueMember = "Id"; //El valor asociado será el Id del tipo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de vehículo: " + ex.Message);
            }
        }

        //CargarVehiculos() --> Este método carga los vehículos en el DataGridView, con filtro opcional
        private void CargarVehiculos(string filtro = "")
        {

            try
            {
                using (var db = new ParkingEntities())
                {
                    var lista = string.IsNullOrWhiteSpace(filtro) //Si no hay filtro
                        ? db.Vehiculos
                            .Include("TiposVehiculo")
                            .Select(vehiculo => new
                            {
                                vehiculo.Id,
                                vehiculo.Matricula,
                                vehiculo.Marca,
                                vehiculo.Modelo,
                                Tipo = vehiculo.TiposVehiculo.Nombre //Mostramos el nombre del tipo
                            })
                            .ToList()
                        : db.Vehiculos 
                            .Include("TiposVehiculo")
                            .Where(vehiculo => vehiculo.Matricula.Contains(filtro))
                            .Select(vehiculo => new
                            {
                                vehiculo.Id,
                                vehiculo.Matricula,
                                vehiculo.Marca,
                                vehiculo.Modelo,
                                Tipo = vehiculo.TiposVehiculo.Nombre
                            })
                            .ToList();

                    dgvVehiculos.DataSource = lista; //Mostramos la lista en el DataGridView
                }

                dgvVehiculos.ClearSelection(); //Quitamos la selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message);
            }
        }

        //Validar() --> Este método valida que los datos escritos sean correctos
        private bool Validar()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtMatricula.Text)) //Si la matrícula está vacía
            {
                MessageBox.Show("La matrícula es obligatoria.");
                esValido = false;
            }

            if (cmbTipo.SelectedItem == null) //Si no se ha elegido un tipo
            {
                MessageBox.Show("Selecciona un tipo de vehículo.");
                esValido = false;
            }

            return esValido;
        }

        //LimpiarCampos() --> Este método limpia los cuadros de texto y el filtro
        private void LimpiarCampos()
        {
            txtMatricula.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtFiltro.Clear();

            //Reseteamos el ComboBox al primer elemento
            if (cmbTipo.Items.Count > 0)
            {
                cmbTipo.SelectedIndex = 0;
            }
        }

        //CrearVehiculo() --> Este método crea un nuevo vehículo
        private void CrearVehiculo()
        {
            if (Validar()) //Validamos los datos
            {
                try
                {
                    using (var db = new ParkingEntities())
                    {
                        var vehiculo = new Vehiculos
                        {
                            Matricula = txtMatricula.Text.Trim().ToUpper(),
                            Marca = txtMarca.Text.Trim(),
                            Modelo = txtModelo.Text.Trim(),
                            TipoVehiculoId = (int)cmbTipo.SelectedValue
                        };

                        db.Vehiculos.Add(vehiculo); //Añadimos el vehículo
                        db.SaveChanges(); //Guardamos en la base de datos
                    }
                    //Recargamos el DataGridView y limpiamos los campos
                    CargarVehiculos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear vehículo: " + ex.Message);
                }
            }
        }

        //EditarVehiculo() --> Este método edita un vehículo seleccionado
        private void EditarVehiculo()
        {
            if (dgvVehiculos.CurrentRow != null) //Si hay una fila seleccionada
            {
                if (Validar())
                {
                    var id = (int)dgvVehiculos.CurrentRow.Cells["Id"].Value; //Obtenemos el Id del vehículo seleccionado

                    try
                    {
                        using (var db = new ParkingEntities())
                        {
                            var vehiculo = db.Vehiculos.Find(id); //Buscamos el vehículo
                            if (vehiculo != null)
                            {
                                vehiculo.Matricula = txtMatricula.Text.Trim().ToUpper();
                                vehiculo.Marca = txtMarca.Text.Trim();
                                vehiculo.Modelo = txtModelo.Text.Trim();
                                vehiculo.TipoVehiculoId = (int)cmbTipo.SelectedValue;

                                db.SaveChanges(); //Guardamos cambios
                            }
                            else
                            {
                                MessageBox.Show("El vehículo seleccionado no existe en la base de datos.");
                            }
                        }
                        //Recargamos el DataGridView y limpiamos los campos
                        CargarVehiculos();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar vehículo: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehículo en la lista.");
            }
        }

        //EliminarVehiculo() --> Este método elimina un vehículo seleccionado
        private void EliminarVehiculo()
        {
            if (dgvVehiculos.CurrentRow != null) //Si hay una fila seleccionada
            {
                var id = (int)dgvVehiculos.CurrentRow.Cells["Id"].Value; //Obtenemos el Id del vehículo seleccionado

                //Pedimos confirmación antes de eliminar
                var confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este vehículo?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes) //Si el usuario confirma
                {
                    try
                    {
                        using (var db = new ParkingEntities())
                        {
                            var vehiculo = db.Vehiculos.Find(id); //Buscamos el vehículo
                            if (vehiculo != null)
                            {
                                db.Vehiculos.Remove(vehiculo); //Lo eliminamos
                                db.SaveChanges(); //Guardamos cambios
                            }
                            else
                            {
                                MessageBox.Show("El vehículo seleccionado no existe en la base de datos.");
                            }
                        }
                        //Recargamos el DataGridView y limpiamos los campos
                        CargarVehiculos();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar vehículo: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehículo en la lista.");
            }
        }

        //Eventos del Formulario
        //dgvVehiculos_SelectionChanged() --> Este evento se ejecuta cuando seleccionamos una fila en el DataGridView
        private void dgvVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow != null)
            {
                //Cargamos los datos del vehículo seleccionado en los cuadros de texto y el ComboBox
                txtMatricula.Text = dgvVehiculos.CurrentRow.Cells["Matricula"].Value.ToString();
                txtMarca.Text = dgvVehiculos.CurrentRow.Cells["Marca"].Value?.ToString();
                txtModelo.Text = dgvVehiculos.CurrentRow.Cells["Modelo"].Value?.ToString();

                //Sincronizamos el ComboBox con el nombre del tipo mostrado en la columna "Tipo"
                var tipoNombre = dgvVehiculos.CurrentRow.Cells["Tipo"].Value.ToString();
                if (!string.IsNullOrEmpty(tipoNombre))
                {
                    cmbTipo.SelectedIndex = cmbTipo.FindStringExact(tipoNombre);
                }
            }
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.Trim().ToUpper();
            CargarVehiculos(filtro);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearVehiculo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarVehiculo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarVehiculo();
        }

        //Eventos del MenuStrip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearVehiculo();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarVehiculo();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarVehiculo();
        }

        //Eventos del ToolStrip
        private void btnCrearToolStrip_Click(object sender, EventArgs e)
        {
            CrearVehiculo();
        }

        private void btnEditarToolStrip_Click(object sender, EventArgs e)
        {
            EditarVehiculo();
        }

        private void btnEliminarToolStrip_Click(object sender, EventArgs e)
        {
            EliminarVehiculo();
        }

        private void btnCerrarToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
