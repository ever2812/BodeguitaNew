using System;
using System.Windows.Forms;
using Bodeguita.Negocio;


namespace Bodeguita.Presentacion
{
    public partial class FrmCategoria : Form
    {

        string NombreAnt;
        
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar() {
            NCategoria nc = new NCategoria();
            DgvListado.DataSource = nc.Listar();
            this.FormatoDgv();
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            BtnGuardar.Visible = true;
            btnActualizar.Visible = false;
           
            ErrorNotificacion.Clear();     
        }


        //Para la opción de buscar, queda pendiente, en el evento keypress o keyup, configurar la tecla Enter para buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NCategoria nc = new NCategoria();
            DgvListado.DataSource = nc.Buscar(txtBuscar.Text);
        }

        private void FormatoDgv() {
            DgvListado.Columns[0].Width = 50;
            DgvListado.Columns[1].Width = 150;
            DgvListado.Columns[2].Width = 220;
            DgvListado.Columns[3].Width = 80;
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta;
                if ((txtNombre.Text == string.Empty) && txtDescripcion.Text == string.Empty)
                {
                    ErrorNotificacion.SetError(txtNombre, "Se debe ingresar un Nombre");
                    ErrorNotificacion.SetError(txtDescripcion, "Debe agregar una descripción");
                }
                else
                {
                    NCategoria nc = new NCategoria();
                    rpta = nc.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Registro insertado correctamente");
                        TapGeneral.SelectedIndex = 0;
                        Limpiar();
                        Listar();
                    }
                    else {
                        MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             
                btnActualizar.Visible = true;
                BtnGuardar.Visible = false;

                txtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["CATEGORIA"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["CATEGORIA"].Value);
                txtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["DESCRIPCION"].Value);
                TapGeneral.SelectedIndex = 1;
                TapEdicion.Text = "Editar Categoría";

            }
            catch
            {
                MessageBox.Show("Seleccione desde la celda Nombre");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            TapEdicion.Text = "Agregar";
            Listar();
            TapGeneral.SelectedIndex = 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta;
                if ((txtNombre.Text == string.Empty) && txtDescripcion.Text == string.Empty)
                {
                    ErrorNotificacion.SetError(txtNombre, "Se debe ingresar un Nombre");
                    ErrorNotificacion.SetError(txtDescripcion, "Debe agregar una descripción");
                }
                else
                {
                    if (txtNombre.Text == this.NombreAnt)
                    {
                        MessageBox.Show("No se han hecho cambios aun...");
                    }
                    else
                    {
                        NCategoria nc = new NCategoria();
                        rpta=nc.Actualizar(Convert.ToInt32(txtId.Text), txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                        if (rpta.Equals("OK"))
                        {
                            MensajeOK("Registro Actualizado correctamente");
                            TapGeneral.SelectedIndex = 0;
                            TapEdicion.Text = "Agregar";
                            Limpiar();
                            Listar();
                        }
                        else {
                            MensajeError(rpta);
                        }
                    }
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try {

                string rpta;
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar este registro?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (Opcion == DialogResult.Yes)
                {
                    int cat = 0;

                    foreach (DataGridViewRow fila in DgvListado.SelectedRows)
                    {
                        cat = Convert.ToInt32(fila.Cells["ID"].Value);
                    }

                    NCategoria nc = new NCategoria();
                    rpta = nc.Desactivar(cat);
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Registro desactivado correctamente");
                        this.Limpiar();
                        this.Listar();
                    }
                    else {
                        MensajeError(rpta);
                    }
                    
                }
                else
                {
                    MessageBox.Show("nSe ha cancelado su desición");
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
          
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta;
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Activar este registro?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (Opcion == DialogResult.Yes)
                {
                    int cat = 0;

                    foreach (DataGridViewRow fila in DgvListado.SelectedRows)
                    {
                        cat = Convert.ToInt32(fila.Cells["ID"].Value);
                    }

                    NCategoria nc = new NCategoria();
                    rpta=nc.Activar(cat);
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Registro Activado correctamente");
                        this.Limpiar();
                        this.Listar();
                    }
                    else {
                        MensajeError(rpta);
                    }                    
                }
                else
                {
                    MessageBox.Show("Se ha cancelado su desición");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigo = 0;
                    string rpta = "";

                    foreach (DataGridViewRow fila in DgvListado.SelectedRows)
                    {
                        codigo = Convert.ToInt32(fila.Cells["ID"].Value);
                    }

                    NCategoria nc = new NCategoria();
                    rpta = nc.Eliminar(codigo);
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Registro eliminado correctamente");
                        this.Limpiar();
                        this.Listar();
                        this.Listar();
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                }
                else {
                    MessageBox.Show("Ha cancelado la solicitud de eliminación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
