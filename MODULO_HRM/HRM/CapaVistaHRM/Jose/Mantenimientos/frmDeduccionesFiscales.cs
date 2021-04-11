using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Jose;

namespace CapaVistaHRM.Jose.Mantenimientos
{
    public partial class frmDeduccionesFiscales : Form
    {
        ClsValidaciones validar = new ClsValidaciones();
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmDeduccionesFiscales(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void rdInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  0
            if (rdInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void rdActivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (rdActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rdValor_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (rdValor.Checked == true)
            {
                txtCantidad.Text = "0.0";
            }
        }

        private void rdFormula_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFormula.Checked == true)
            {
                txtFormula.Text = "Sin Formula Especificada.";
            }

        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {
            if (txtFormula.Text.Length == 0)
            {
                rdFormula.Checked = false;
                rdFormula.Enabled = true;
            }
            else
            {
                rdFormula.Enabled = false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length == 0)
            {
                rdValor.Checked = false;
                rdValor.Enabled = true;
            }
            else
            {
                rdValor.Enabled = false;
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 316;
            navegador1.tbl = "tipodeduccion";
            navegador1.campoEstado = "estado";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudaJose/AyudaMantenimientosJose.chm";
            navegador1.ruta = "AYUDA-FORMULARIO-DEDUCCIONES.html";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloLetras(e);
            validar.ValidadCantidad(e,txtNombre,48);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidadCantidad(e, txtDescripcion, 248);
        }

        private void txtFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidadCantidad(e, txtFormula, 98);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloNumerosDecimales(e);
            validar.ValidadCantidad(e, txtCantidad, 9);
        }
    }
}
