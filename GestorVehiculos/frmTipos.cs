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
    public partial class frmTipos : Form
    {
        public frmTipos()
        {
            InitializeComponent();
            CargarTipos(); //Al abrir el formulario, cargamos los tipos de vehículo en el DataGridView
        }

        //CargarTipos() --> Este método carga los tipos de vehículo desde la base de datos
        private void CargarTipos()
        {
            try
            {
                using (var db = new ParkingEntities()) //Abrimos conexión con la base de datos
                {
                    var lista = db.TiposVehiculo
                        .Select(tipo => new
                        {
                            tipo.Id,
                            tipo.Nombre,
                            tipo.TarifaHora
                        })
                        .ToList();

                    dgvTipos.DataSource = lista; //Mostramos la lista en el DataGridView
                }

                dgvTipos.ClearSelection(); //Quitamos la selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de vehículo: " + ex.Message);
            }
        }

        //Validar() --> Este método valida que los datos escritos sean correctos
        private bool Validar()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text)) //Si el nombre está vacío
            {
                MessageBox.Show("El nombre es obligatorio.");
                esValido = false;
            }

            decimal tarifa;
            if (!decimal.TryParse(txtTarifa.Text, out tarifa) || tarifa < 0) //Si la tarifa no es número o es negativa
            {
                MessageBox.Show("La tarifa debe ser un número positivo.");
                esValido = false;
            }

            return esValido;
        }

        //NombreTipoExiste() --> Método auxiliar para comprobar si existe un nombre de tipo
        private bool NombreTipoExiste(string nombre, int? idTipo = null)
        {
            using (var db = new ParkingEntities())
            {
                return db.TiposVehiculo.Any(tipo => tipo.Nombre == nombre && tipo.Id != idTipo);
            }
        }

        //LimpiarCampos() --> Este método limpia los cuadros de texto
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTarifa.Clear();
        }

        //CrearTipo() --> Este método crea un nuevo tipo de vehículo
        private void CrearTipo()
        {
            if (Validar()) //Validamos los datos
            {
                //Comprobamos si ya existe un tipo con ese nombre
                string nombre = txtNombre.Text.Trim();
                if (NombreTipoExiste(nombre))
                {
                    MessageBox.Show("Ya existe un tipo de vehículo con ese nombre.");
                    return;
                }

                try
                {
                    using (var db = new ParkingEntities())
                    {
                        var tipo = new TiposVehiculo
                        {
                            Nombre = nombre, //Guardamos el nombre
                            TarifaHora = decimal.Parse(txtTarifa.Text.Trim()) //Guardamos la tarifa
                        };

                        db.TiposVehiculo.Add(tipo); //Añadimos el nuevo tipo
                        db.SaveChanges(); //Guardamos en la base de datos
                    }

                    //Refrescamos la lista y limpiamos los campos
                    CargarTipos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear tipo de vehículo: " + ex.Message);
                }
            }
        }

        //EditarTipo() --> Este método edita un tipo de vehículo seleccionado
        private void EditarTipo()
        {
            if (dgvTipos.CurrentRow != null) //Si hay una fila seleccionada
            {
                if (Validar())
                {
                    var id = (int)dgvTipos.CurrentRow.Cells["Id"].Value; //Obtenemos el Id del tipo
                    //Comprobamos si ya existe otro tipo con ese nombre
                    string nombre = txtNombre.Text.Trim();
                    if (NombreTipoExiste(nombre, id))
                    {
                        MessageBox.Show("Ya existe otro tipo de vehículo con ese nombre.");
                        return;
                    }

                    try
                    {
                        using (var db = new ParkingEntities())
                        {
                            var tipo = db.TiposVehiculo.Find(id); //Buscamos el tipo en la base de datos
                            if (tipo != null)
                            {
                                tipo.Nombre = nombre; //Actualizamos el nombre
                                tipo.TarifaHora = decimal.Parse(txtTarifa.Text.Trim()); //Actualizamos la tarifa
                                db.SaveChanges(); //Guardamos los cambios

                                //Refrescamos la lista y limpiamos los campos
                                CargarTipos();
                                LimpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("El tipo de vehículo seleccionado no existe en la base de datos.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar tipo de vehículo: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de vehículo en la lista.");
            }
        }

        //EliminarTipo() --> Este método elimina un tipo de vehículo
        private void EliminarTipo()
        {
            if (dgvTipos.CurrentRow != null) //Si hay una fila seleccionada
            {
                var id = (int)dgvTipos.CurrentRow.Cells["Id"].Value; //Obtenemos el Id del tipo

                //Confirmamos la eliminación
                var confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este tipo de vehículo?",
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
                            var tipo = db.TiposVehiculo.Include("Vehiculos").FirstOrDefault(t => t.Id == id);
                            if (tipo != null)
                            {
                                if (tipo.Vehiculos.Any()) //Si tiene vehículos asociados, no se puede borrar
                                {
                                    MessageBox.Show("No se puede eliminar: tiene vehículos asociados.");
                                }
                                else
                                {
                                    db.TiposVehiculo.Remove(tipo); //Eliminamos el tipo
                                    db.SaveChanges(); //Guardamos los cambios
                                    //Refrescamos la lista y limpiamos los campos
                                    CargarTipos();
                                    LimpiarCampos();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El tipo de vehículo seleccionado no existe en la base de datos.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar tipo de vehículo: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de vehículo en la lista.");
            }
        }

        //Eventos del Formulario
        //dgvTipos_SelectionChanged() --> Este evento se ejecuta cuando seleccionamos una fila en el DataGridView
        private void dgvTipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTipos.CurrentRow != null)
            {
                //Rellenamos los cuadros de texto con los datos del tipo seleccionado
                txtNombre.Text = dgvTipos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTarifa.Text = dgvTipos.CurrentRow.Cells["TarifaHora"].Value.ToString();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearTipo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTipo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTipo();
        }

        //Eventos del MenuStrip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearTipo();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarTipo();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarTipo();
        }

        //Eventos del ToolStrip
        private void btnCrearToolStrip_Click(object sender, EventArgs e)
        {
            CrearTipo();
        }

        private void btnEditarToolStrip_Click(object sender, EventArgs e)
        {
            EditarTipo();
        }

        private void btnEliminarToolStrip_Click(object sender, EventArgs e)
        {
            EliminarTipo();
        }

        private void btnCerrarToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
