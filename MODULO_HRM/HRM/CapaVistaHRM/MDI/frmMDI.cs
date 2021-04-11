using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad;
using CapaVistaHRM.Jose.Mantenimientos;
using CapaVistaHRM.Jose.Procesos;

namespace CapaVistaHRM.MDI
{

    public partial class frmMDI : Form
    {
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();
        frmContratos Contratos;
        frmPercepcionesFiscales Percepciones;
        frmDeduccionesFiscales Deducciones;
        frmDificultad Dificultad;
        frmTipoEntrevista TipoEntrevista;
        frmTipoHorario TipoHorario;
        frmFormacionAcademica TipoFormacionAcademica;
        frmTipoMoneda TipoMoneda;
        frmCambioContraseña cambioContraseña;
        frmMantenimientoUsuario MantenimientoUsuario;
        frmAplicativo Aplicativo;
        frmAsignacionDeAplicaciones AsignacionDeAplicaciones;
        frmModulo Modulo;
        frmMantenimientoPerfil MantenimientoPerfil;
        frmAsignarAplicacionesAPerfil AsignarAplicacionesAPerfil;
        frmModificarPermisos ModificarPermisos;

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("310", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Contratos", 310);

                if (Contratos == null)
                {
                    Contratos = new frmContratos(txtUsuario.Text, this);
                    Contratos.MdiParent = this;
                    Contratos.FormClosed += (o, args) => Contratos = null;
                }
                Contratos.Show();
                Contratos.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Contratos", 310);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void percepcionesFisclaesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("317", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Percepciones fiscales", 317);

                if (Percepciones == null)
                {
                    Percepciones = new frmPercepcionesFiscales(txtUsuario.Text, this);
                    Percepciones.MdiParent = this;
                    Percepciones.FormClosed += (o, args) => Percepciones = null;
                }
                Percepciones.Show();
                Percepciones.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Percepciones fiscales", 317);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void deduccionesFiscalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("316", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Deducciones fiscales", 316);

                if (Deducciones == null)
                {
                    Deducciones = new frmDeduccionesFiscales(txtUsuario.Text, this);
                    Deducciones.MdiParent = this;
                    Deducciones.FormClosed += (o, args) => Deducciones = null;
                }
                Deducciones.Show();
                Deducciones.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Deducciones fiscales", 316);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tipoDeHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("315", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Horarios", 315);

                if (TipoHorario == null)
                {
                    TipoHorario = new frmTipoHorario(txtUsuario.Text, this);
                    TipoHorario.MdiParent = this;
                    TipoHorario.FormClosed += (o, args) => TipoHorario = null;
                }
                TipoHorario.Show();
                TipoHorario.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Horarios ", 315);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tiposDeEntrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("312", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Entrevista", 312);

                if (TipoEntrevista == null)
                {
                    TipoEntrevista = new frmTipoEntrevista(txtUsuario.Text, this);
                    TipoEntrevista.MdiParent = this;
                    TipoEntrevista.FormClosed += (o, args) => TipoEntrevista = null;
                }
                TipoEntrevista.Show();
                TipoEntrevista.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Entrevista", 312);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tipoDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("311", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de  Moneda ", 311);

                if (TipoMoneda == null)
                {
                    TipoMoneda = new frmTipoMoneda(txtUsuario.Text, this);
                    TipoMoneda.MdiParent = this;
                    TipoMoneda.FormClosed += (o, args) => TipoMoneda = null;
                }
                TipoMoneda.Show();
                TipoMoneda.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Moneda", 311);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tipoDeDificultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("313", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de  Dificultad ", 313);

                if (Dificultad == null)
                {
                    Dificultad = new frmDificultad(txtUsuario.Text, this);
                    Dificultad.MdiParent = this;
                    Dificultad.FormClosed += (o, args) => Dificultad = null;
                }
                Dificultad.Show();
                Dificultad.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Dificultad", 313);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void formacionAcademicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("314", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de  Formacion Academica ", 314);

                if (TipoFormacionAcademica == null)
                {
                    TipoFormacionAcademica = new frmFormacionAcademica(txtUsuario.Text, this);
                    TipoFormacionAcademica.MdiParent = this;
                    TipoFormacionAcademica.FormClosed += (o, args) => TipoFormacionAcademica = null;
                }
                TipoFormacionAcademica.Show();
                TipoFormacionAcademica.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de  Formacion Academica", 314);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cambioContraseña == null)
            {
                cambioContraseña = new  frmCambioContraseña(txtUsuario.Text);
                cambioContraseña.MdiParent = this;
                cambioContraseña.FormClosed += (o, args) => cambioContraseña = null;
            }
            cambioContraseña.Show();
            cambioContraseña.BringToFront();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de usuarios", 2);

                if (MantenimientoUsuario == null)
                {
                    MantenimientoUsuario = new frmMantenimientoUsuario(txtUsuario.Text);
                    MantenimientoUsuario.MdiParent = this;
                    MantenimientoUsuario.FormClosed += (o, args) => MantenimientoUsuario = null;
                }
                MantenimientoUsuario.Show();
                MantenimientoUsuario.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de usuarios", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de aplicaciones", 3);

                if (Aplicativo == null)
                {
                    Aplicativo = new frmAplicativo();
                    Aplicativo.MdiParent = this;
                    Aplicativo.FormClosed += (o, args) => Aplicativo = null;
                }
                Aplicativo.Show();
                Aplicativo.BringToFront();

            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de aplicaciones", 3);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDePerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la asignacion de aplicaciones", 6);


                if (AsignacionDeAplicaciones == null)
                {
                    AsignacionDeAplicaciones = new frmAsignacionDeAplicaciones();
                    AsignacionDeAplicaciones.MdiParent = this;
                    AsignacionDeAplicaciones.FormClosed += (o, args) => AsignacionDeAplicaciones = null;
                }
                AsignacionDeAplicaciones.Show();
                AsignacionDeAplicaciones.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a l asignacion de aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("8", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de Modulo", 8);


                if (Modulo == null)
                {
                    Modulo = new frmModulo(txtUsuario.Text);
                    Modulo.MdiParent = this;
                    Modulo.FormClosed += (o, args) => Modulo = null;
                }
                Modulo.Show();
                Modulo.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de Modulo", 8);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("4", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil", 4);

                if (MantenimientoPerfil == null)
                {
                    MantenimientoPerfil = new frmMantenimientoPerfil(txtUsuario.Text);
                    MantenimientoPerfil.MdiParent = this;
                    MantenimientoPerfil.FormClosed += (o, args) => MantenimientoPerfil = null;
                }
                MantenimientoPerfil.Show();
                MantenimientoPerfil.BringToFront();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de mantenimiento de perfil", 4);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (seguridad.PermisosAcceso("5", txtUsuario.Text) == 1)
           {
               bit.user(txtUsuario.Text);
               bit.insert("Ingreso a la apliacion de mantenimiento de perfil apliaciones a perfil", 5);

                if (AsignarAplicacionesAPerfil == null)
                {
                    AsignarAplicacionesAPerfil = new frmAsignarAplicacionesAPerfil();
                    AsignarAplicacionesAPerfil.MdiParent = this;
                    AsignarAplicacionesAPerfil.FormClosed += (o, args) => AsignarAplicacionesAPerfil = null;
                }
                AsignarAplicacionesAPerfil.Show();
                AsignarAplicacionesAPerfil.BringToFront();

           }
           else
           {
               bit.user(txtUsuario.Text);
               bit.insert("Trato de ingresar a la aplicacione de mantenimiento de perfil apliaciones a perfil", 5);
               MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
           }
        }

        private void asignacionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (seguridad.PermisosAcceso("10", txtUsuario.Text) == 1)
           {
               bit.user(txtUsuario.Text);
               bit.insert("Ingreso a la aplicacion de Asignacion de permisos", 10);

                if (ModificarPermisos == null)
                {
                    ModificarPermisos = new frmModificarPermisos();
                    ModificarPermisos.MdiParent = this;
                    ModificarPermisos.FormClosed += (o, args) => ModificarPermisos = null;
                }
                ModificarPermisos.Show();
                ModificarPermisos.BringToFront();
           }
           else
           {
               bit.user(txtUsuario.Text);
               bit.insert("Trato de ingresar a la aplicacion de Asignacion de permisos", 10);
               MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
           }
        }
    }
}
