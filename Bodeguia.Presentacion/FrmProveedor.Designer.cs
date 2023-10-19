
namespace Bodeguita.Presentacion
{
    partial class FrmProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TapGeneral = new System.Windows.Forms.TabControl();
            this.TapListado = new System.Windows.Forms.TabPage();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.TapEdicion = new System.Windows.Forms.TabPage();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TapGeneral.SuspendLayout();
            this.TapListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TapEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TapGeneral
            // 
            this.TapGeneral.Controls.Add(this.TapListado);
            this.TapGeneral.Controls.Add(this.TapEdicion);
            this.TapGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TapGeneral.Location = new System.Drawing.Point(0, 0);
            this.TapGeneral.Name = "TapGeneral";
            this.TapGeneral.SelectedIndex = 0;
            this.TapGeneral.Size = new System.Drawing.Size(613, 480);
            this.TapGeneral.TabIndex = 2;
            // 
            // TapListado
            // 
            this.TapListado.Controls.Add(this.DgvListado);
            this.TapListado.Controls.Add(this.btnEliminar);
            this.TapListado.Controls.Add(this.btnDesactivar);
            this.TapListado.Controls.Add(this.btnActivar);
            this.TapListado.Controls.Add(this.label1);
            this.TapListado.Controls.Add(this.btnBuscar);
            this.TapListado.Controls.Add(this.txtBuscar);
            this.TapListado.Location = new System.Drawing.Point(4, 29);
            this.TapListado.Name = "TapListado";
            this.TapListado.Padding = new System.Windows.Forms.Padding(3);
            this.TapListado.Size = new System.Drawing.Size(605, 447);
            this.TapListado.TabIndex = 0;
            this.TapListado.Text = "Listado";
            this.TapListado.UseVisualStyleBackColor = true;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Location = new System.Drawing.Point(9, 39);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 29;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(566, 327);
            this.DgvListado.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(299, 391);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(159, 391);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 30);
            this.btnDesactivar.TabIndex = 11;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(9, 391);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(100, 30);
            this.btnActivar.TabIndex = 10;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(405, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(8, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(391, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // TapEdicion
            // 
            this.TapEdicion.Controls.Add(this.txtTelefono);
            this.TapEdicion.Controls.Add(this.label7);
            this.TapEdicion.Controls.Add(this.txtRfc);
            this.TapEdicion.Controls.Add(this.label6);
            this.TapEdicion.Controls.Add(this.label5);
            this.TapEdicion.Controls.Add(this.btnActualizar);
            this.TapEdicion.Controls.Add(this.label4);
            this.TapEdicion.Controls.Add(this.btnGuardar);
            this.TapEdicion.Controls.Add(this.btnCancelar);
            this.TapEdicion.Controls.Add(this.txtId);
            this.TapEdicion.Controls.Add(this.txtDireccion);
            this.TapEdicion.Controls.Add(this.txtNombre);
            this.TapEdicion.Controls.Add(this.label2);
            this.TapEdicion.Location = new System.Drawing.Point(4, 29);
            this.TapEdicion.Name = "TapEdicion";
            this.TapEdicion.Padding = new System.Windows.Forms.Padding(3);
            this.TapEdicion.Size = new System.Drawing.Size(605, 447);
            this.TapEdicion.TabIndex = 1;
            this.TapEdicion.Text = "Edición";
            this.TapEdicion.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(139, 240);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(319, 26);
            this.txtTelefono.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Telefono :";
            // 
            // txtRfc
            // 
            this.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRfc.Location = new System.Drawing.Point(139, 191);
            this.txtRfc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(319, 26);
            this.txtRfc.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "RFC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dirección  (*):";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(153, 343);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "(*) INDICA QUE EL DATO ES OBLIGATORIO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(154, 343);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(358, 343);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(310, 24);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 26);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(139, 109);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(319, 61);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(139, 67);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre (*):";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 480);
            this.Controls.Add(this.TapGeneral);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.TapGeneral.ResumeLayout(false);
            this.TapListado.ResumeLayout(false);
            this.TapListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TapEdicion.ResumeLayout(false);
            this.TapEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TapGeneral;
        private System.Windows.Forms.TabPage TapListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage TapEdicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}