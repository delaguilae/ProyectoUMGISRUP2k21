﻿
namespace CapaVistaHRM.Jose.Mantenimientos
{
    partial class frmDeduccionesFiscales
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdFormula = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdValor = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblCantidadMonto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdInactivo = new System.Windows.Forms.RadioButton();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdFormula);
            this.groupBox3.Location = new System.Drawing.Point(987, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 55);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // rdFormula
            // 
            this.rdFormula.AutoSize = true;
            this.rdFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFormula.Location = new System.Drawing.Point(6, 21);
            this.rdFormula.Name = "rdFormula";
            this.rdFormula.Size = new System.Drawing.Size(123, 24);
            this.rdFormula.TabIndex = 46;
            this.rdFormula.TabStop = true;
            this.rdFormula.Text = "Sin Formula";
            this.rdFormula.UseVisualStyleBackColor = true;
            this.rdFormula.CheckedChanged += new System.EventHandler(this.rdFormula_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdValor);
            this.groupBox2.Location = new System.Drawing.Point(987, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 55);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // rdValor
            // 
            this.rdValor.AutoSize = true;
            this.rdValor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdValor.Location = new System.Drawing.Point(6, 21);
            this.rdValor.Name = "rdValor";
            this.rdValor.Size = new System.Drawing.Size(101, 24);
            this.rdValor.TabIndex = 45;
            this.rdValor.TabStop = true;
            this.rdValor.Text = "Sin Valor";
            this.rdValor.UseVisualStyleBackColor = true;
            this.rdValor.CheckedChanged += new System.EventHandler(this.rdValor_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(673, 318);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(110, 27);
            this.txtEstado.TabIndex = 63;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            // 
            // lblCantidadMonto
            // 
            this.lblCantidadMonto.AutoSize = true;
            this.lblCantidadMonto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMonto.Location = new System.Drawing.Point(580, 199);
            this.lblCantidadMonto.Name = "lblCantidadMonto";
            this.lblCantidadMonto.Size = new System.Drawing.Size(52, 20);
            this.lblCantidadMonto.TabIndex = 62;
            this.lblCantidadMonto.Text = "Valor";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(673, 192);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(284, 27);
            this.txtCantidad.TabIndex = 59;
            this.txtCantidad.Tag = "valor";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(580, 152);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(74, 20);
            this.lblFormula.TabIndex = 61;
            this.lblFormula.Text = "Formula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdInactivo);
            this.groupBox1.Controls.Add(this.rdActivo);
            this.groupBox1.Location = new System.Drawing.Point(673, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 82);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // rdInactivo
            // 
            this.rdInactivo.AutoSize = true;
            this.rdInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInactivo.Location = new System.Drawing.Point(125, 33);
            this.rdInactivo.Name = "rdInactivo";
            this.rdInactivo.Size = new System.Drawing.Size(92, 24);
            this.rdInactivo.TabIndex = 22;
            this.rdInactivo.TabStop = true;
            this.rdInactivo.Text = "Inactivo";
            this.rdInactivo.UseVisualStyleBackColor = true;
            this.rdInactivo.CheckedChanged += new System.EventHandler(this.rdInactivo_CheckedChanged);
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActivo.Location = new System.Drawing.Point(18, 33);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(80, 24);
            this.rdActivo.TabIndex = 21;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = true;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(580, 246);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 20);
            this.lblEstado.TabIndex = 58;
            this.lblEstado.Text = "Estado";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(17, 230);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 57;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(17, 191);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(17, 148);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 55;
            this.lblCodigo.Text = "Codigo";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(21, 467);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1393, 270);
            this.dgvDatos.TabIndex = 54;
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(673, 145);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(587, 27);
            this.txtFormula.TabIndex = 53;
            this.txtFormula.Tag = "formula";
            this.txtFormula.TextChanged += new System.EventHandler(this.txtFormula_TextChanged);
            this.txtFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormula_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(163, 227);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(380, 224);
            this.txtDescripcion.TabIndex = 52;
            this.txtDescripcion.Tag = "descripcion";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(163, 186);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 27);
            this.txtNombre.TabIndex = 51;
            this.txtNombre.Tag = "tipoDeduccion";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(163, 149);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 27);
            this.txtCodigo.TabIndex = 50;
            this.txtCodigo.Tag = "idTipoDeduccion";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(11, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 49;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // frmDeduccionesFiscales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 750);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblCantidadMonto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.navegador1);
            this.Name = "frmDeduccionesFiscales";
            this.Text = "Mantenimiento Deducciones";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdFormula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdValor;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblCantidadMonto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdInactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private CapaVistaNavegador.Navegador navegador1;
    }
}