﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControladorHRM.Manuel;
using System.Net;


namespace CapaVistaHRM.Manuel.Procesos
{
    public partial class frmEntrevista : Form
    {

        ClsControladorManuel Cont_R = new ClsControladorManuel();

        public frmEntrevista()
        {
            InitializeComponent();
            funcLlenarTipoEntrevista();
            cmbTipoEntrevista.DropDownStyle = ComboBoxStyle.DropDownList;
<<<<<<< HEAD
=======
            EstadoNoEntrevistados = 0;
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
        }

        //Declaración de variables Entidad Reclutamiento
        string IdRecluta,Comentarios,OpcionRecluta;
<<<<<<< HEAD
        int Resultado,TipoEntrevista,Punteo;

        

      
=======
        int Resultado,TipoEntrevista,Punteo,EstadoNoEntrevistados;

        


>>>>>>> 8679c524d2039044202f555e7b5085c359020019
        //Se agrega el codigo a la variable resultado de reprobado
        private void rbtnReprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReprobado.Checked == true)
            {
                //estado de no escogido
<<<<<<< HEAD
                Resultado = 3;
=======
                Resultado = 4;
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
                pnlOpciones.Enabled = false;
                rbtnPrimeraOp.Checked = false;
                rbtnSegOpcion.Checked = false;
            }
        }
        //Se agrega el codigo a la variable resultado de aprobado
        private void rbtnAprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAprobado.Checked == true)
            {
                pnlOpciones.Enabled = true;
            }
        }

        //funcion para llenar el combo
        public void funcLlenarTipoEntrevista()
        {
            DataTable Datos = Cont_R.funcItemsEntrevista();
            cmbTipoEntrevista.DataSource = Datos;
            cmbTipoEntrevista.DisplayMember = "TIPOENTREVISTA";
            cmbTipoEntrevista.ResetText();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                IdRecluta = txtIdBancoTalento.Text;
                gbxDatosEntrevista.Enabled = true;
<<<<<<< HEAD

=======
                
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarRecluta(txtIdBancoTalento.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento

                        txtPrimerNombre.Text = Lector.GetString(0);
                        txtPrimerApellido.Text = Lector.GetString(1);
                        cmbPuestoTrabajo.Text = Lector.GetString(10);
                        cmbHorario.Text = Lector.GetString(11);
                        cmbDepartamentoTrabajo.Text = Lector.GetString(12);
                        

                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id de ese Recluta no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();


                }

            }//fin ifelse
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void frmEntrevista_Load(object sender, EventArgs e)
        {
            
            txtIdBancoTalento.MaxLength = 8;
            txtPunteo.MaxLength = 3;
        }

        private void btnReclutas_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
<<<<<<< HEAD
            frmMostrarReclutas MostrarReclu = new frmMostrarReclutas();
=======
            frmMostrarReclutas MostrarReclu = new frmMostrarReclutas(EstadoNoEntrevistados);
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
            MostrarReclu.ShowDialog();
        }

        private void rbtnPrimeraOp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrimeraOp.Checked == true)
            {
<<<<<<< HEAD
                //prioridad máxima luego de recomendados
                Resultado = 1;
=======
                //prioridad máxima luego de recomendados, estado de ya evaluado
                Resultado = 1;
                OpcionRecluta = "Primera Opcion";
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
            }
        }

        private void rbtnSegOpcion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSegOpcion.Checked == true)
            {
<<<<<<< HEAD
                //segunda prioridad
                Resultado = 2;
=======
                //segunda prioridad, estado de ya evaluado
                Resultado = 1;
                OpcionRecluta = "Segunda Opcion";
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
            }
        }

        private void btnIngresoEntrevista_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "" ||  txtPunteo.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //Mensaje de validación de radiobuttons
                if (rbtnAprobado.Checked == false && rbtnReprobado.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado un Tipo de Resultado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    //segunda verificación de datos de cajas de texto vacias
                    if (rtxtComentarios.Text == "") { MessageBox.Show("ADVERTENCIA: No ha ingresado sus Comentarios sobre el Recluta Entrevistado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    else
                    {
                        if (rbtnAprobado.Checked==true &&(rbtnPrimeraOp.Checked==false && rbtnSegOpcion.Checked==false )) { MessageBox.Show("ADVERTENCIA: No ha seleccionado un Tipo de Opción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                        else { 
                        //Mensaje de Pregunta
                            if (MessageBox.Show("¿Desea agregar un nuevo Resultado de Entrevista ?", "Entrevista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                            else
                            {

                                //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                                //datos Reclutamiento
                                
                                Punteo = Convert.ToInt32(txtPunteo.Text);
                                TipoEntrevista = cmbTipoEntrevista.SelectedIndex + 1;
                                Comentarios = rtxtComentarios.Text;


<<<<<<< HEAD
                                //Datos para entidad Entrevista
                                if (Resultado == 1){
                                    OpcionRecluta = "Primera Opcion";
                                }else
                                   if(Resultado == 2){
                                    OpcionRecluta = "Segunda Opcion";
                                }
                                
=======
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
                                //envío de datos hacia capa Controlador
                                Cont_R.funcInsertarEntrevista(IdRecluta, TipoEntrevista,Punteo, Resultado, Comentarios, OpcionRecluta);
                                MessageBox.Show("Se ha ingresado la Entrevista con Éxito", "FORMULARIO ENTREVISTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                funcLimpieza();
                                funcBloqueo();

                            }//fin elseif Pregunta

                        }//fin else if rbtn aprobado con opcion

                    }//fin elseif txt

                }//fin elseif rbtn
            }

        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdBancoTalento.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            cmbPuestoTrabajo.Text = "";
            cmbTipoEntrevista.Text = "";
            txtPunteo.Text = "";
            rbtnAprobado.Checked = false;
            rbtnReprobado.Checked = false;
            rtxtComentarios.Text = "";
            rbtnPrimeraOp.Checked = false;
            rbtnSegOpcion.Checked = false;
<<<<<<< HEAD

=======
            cmbHorario.Text = "";
>>>>>>> 8679c524d2039044202f555e7b5085c359020019

        }
        //Función de Bloqueo
        private void funcBloqueo()
        {
            gbxDatosEntrevista.Enabled = false;
<<<<<<< HEAD
=======
           
>>>>>>> 8679c524d2039044202f555e7b5085c359020019
        }


    }

}
