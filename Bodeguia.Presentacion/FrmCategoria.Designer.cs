
namespace Bodeguita.Presentacion
{
    partial class FrmCategoria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorNotificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnListar = new System.Windows.Forms.Button();
            this.TapGeneral.SuspendLayout();
            this.TapListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TapEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificacion)).BeginInit();
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
            this.TapGeneral.Size = new System.Drawing.Size(547, 394);
            this.TapGeneral.TabIndex = 1;
            // 
            // TapListado
            // 
            this.TapListado.Controls.Add(this.btnListar);
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
            this.TapListado.Size = new System.Drawing.Size(539, 361);
            this.TapListado.TabIndex = 0;
            this.TapListado.Text = "Listado";
            this.TapListado.UseVisualStyleBackColor = true;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToResizeColumns = false;
            this.DgvListado.AllowUserToResizeRows = false;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.GridColor = System.Drawing.SystemColors.Control;
            this.DgvListado.Location = new System.Drawing.Point(9, 39);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListado.RowHeadersWidth = 10;
            this.DgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.RowTemplate.Height = 29;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(519, 256);
            this.DgvListado.TabIndex = 13;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(299, 311);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(152, 311);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 30);
            this.btnDesactivar.TabIndex = 11;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(9, 311);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(100, 30);
            this.btnActivar.TabIndex = 10;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(322, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(8, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(308, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // TapEdicion
            // 
            this.TapEdicion.Controls.Add(this.btnActualizar);
            this.TapEdicion.Controls.Add(this.label4);
            this.TapEdicion.Controls.Add(this.BtnGuardar);
            this.TapEdicion.Controls.Add(this.btnCancelar);
            this.TapEdicion.Controls.Add(this.txtId);
            this.TapEdicion.Controls.Add(this.txtDescripcion);
            this.TapEdicion.Controls.Add(this.txtNombre);
            this.TapEdicion.Controls.Add(this.label3);
            this.TapEdicion.Controls.Add(this.label2);
            this.TapEdicion.Location = new System.Drawing.Point(4, 29);
            this.TapEdicion.Name = "TapEdicion";
            this.TapEdicion.Padding = new System.Windows.Forms.Padding(3);
            this.TapEdicion.Size = new System.Drawing.Size(587, 361);
            this.TapEdicion.TabIndex = 1;
            this.TapEdicion.Text = "Edición";
            this.TapEdicion.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(113, 276);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "(*) INDICA QUE EL DATO ES OBLIGATORIO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(113, 276);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(317, 276);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(284, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 26);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(111, 131);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(319, 81);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(111, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre (*)";
            // 
            // ErrorNotificacion
            // 
            this.ErrorNotificacion.ContainerControl = this;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(428, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 30);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.TapGeneral);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCategoria";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.TapGeneral.ResumeLayout(false);
            this.TapListado.ResumeLayout(false);
            this.TapListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TapEdicion.ResumeLayout(false);
            this.TapEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TapGeneral;
        private System.Windows.Forms.TabPage TapListado;
        private System.Windows.Forms.TabPage TapEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.ErrorProvider ErrorNotificacion;
        private System.Windows.Forms.Button btnListar;
    }
}