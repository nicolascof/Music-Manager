using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Music_Manager
{
    public partial class frm_Principal : Form
    {
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        Sql oSql;
        Grupo[] oGrupo;
        int cantidadGrupos;

        public frm_Principal ()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            oSql = new Sql();
            oGrupo = new Grupo[50];
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            EnableBoxes(false);
            lbl_PosicionArreglo.Visible = false;
            tsl_Consultas.Enabled = false;
            tab_Consultas.Enabled = false;
            tsmi_AdministradorDatos_Desconectar.Enabled = false;
        }

        private void tsmi_Archivo_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsl_AcercaDe_Click(object sender, EventArgs e)
        {
            frm_About ofrm_AcercaDe = new frm_About();
            ofrm_AcercaDe.Show();
        }

        private void tsl_Consultas_Click(object sender, EventArgs e)
        {
            tab_Consultas.Enabled = true;
            tabc_Principal.SelectedTab = tab_Consultas;
        }

        private void tsmi_AdministradorDatos_Conectar_Click(object sender, EventArgs e)
        {
            frm_ConectarBaseDeDatos ofrm_ConectarBaseDeDatos = new frm_ConectarBaseDeDatos();
            ofrm_ConectarBaseDeDatos.ShowDialog();

            DialogResult respuesta = ofrm_ConectarBaseDeDatos.DialogResult;
            
            if (respuesta == DialogResult.OK)
            {
                if (!oSql.Conectar(ofrm_ConectarBaseDeDatos.TipoAutenticacion, ofrm_ConectarBaseDeDatos.Bd,
                ofrm_ConectarBaseDeDatos.Servidor, ofrm_ConectarBaseDeDatos.Usuario, ofrm_ConectarBaseDeDatos.Contrasenia))
                {
                    MessageBox.Show("Error en la conexión", "Conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Exito en la conexión", "Conectar", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tsslConexion.Image = global::Music_Manager.Properties.Resources.WebDatabase;
                        tsslConexion.Text = "Conectado";

                        CargarClases();
                    }
                }
            }
        }

        private void CargarClases ()
        {
            int cantidadAlbums;
            cantidadGrupos = 0;

            tv_Grupo.Nodes.Clear();

            if (!oSql.sp_SeleccionNombreGrupo())
            {
                MessageBox.Show("Error en la consulta", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TreeNode rn_Conjuntos = tv_Grupo.Nodes.Add("Conjuntos");
                TreeNode rn_Solistas = tv_Grupo.Nodes.Add("Solistas");

                while (oSql.DataReader1.Read())
                {
                    oGrupo[cantidadGrupos] = new Grupo((int) oSql.DataReader1["cant_albums"]);
                    oGrupo[cantidadGrupos].IdGrupo = (int) oSql.DataReader1["id_grupo"];
                    oGrupo[cantidadGrupos].Descripcion = (string) oSql.DataReader1["descripcion"];
                    oGrupo[cantidadGrupos].IdCompania = (int) oSql.DataReader1["id_compania"];
                    oGrupo[cantidadGrupos].CantidadIntegrantes = (byte) oSql.DataReader1["cant_integrantes"];
                    oGrupo[cantidadGrupos].SolistaConjunto = (bool) oSql.DataReader1["solista_conjunto"];

                    if (oGrupo[cantidadGrupos].SolistaConjunto == true)
                    {
                        rn_Solistas.Nodes.Add(oGrupo[cantidadGrupos].IdGrupo.ToString(), oGrupo[cantidadGrupos].Descripcion);
                    }
                    else
                    {
                        rn_Conjuntos.Nodes.Add(oGrupo[cantidadGrupos].IdGrupo.ToString(), oGrupo[cantidadGrupos].Descripcion);
                    }

                    oSql.sp_SeleccionAlbumPorGrupo(oGrupo[cantidadGrupos].Descripcion);

                    using (oSql.DataReader2)
                    {
                        cantidadAlbums = 0;

                        while (oSql.DataReader2.Read())
                        {
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums] = new Album();
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdAlbum = (int) oSql.DataReader2["id_album"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdGenero = (int) oSql.DataReader2["id_genero"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdDisqueria = (int) oSql.DataReader2["id_disqueria"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdCompania = (int) oSql.DataReader2["id_compania"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdGrupo = (int) oSql.DataReader2["id_grupo"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].Titulo = (string) oSql.DataReader2["titulo"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].Costo = (decimal) oSql.DataReader2["costo"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].FechaTerminado = (DateTime) oSql.DataReader2["fecha_terminado"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].FechaLanzamiento = (DateTime) oSql.DataReader2["fecha_lanzamiento"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].CantidadTemas = (int) oSql.DataReader2["cant_temas"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].DuracionAlbum = (int) oSql.DataReader2["duracion_album"];
                            oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].Obsevaciones = (string) oSql.DataReader2["observaciones"];
                            ++cantidadAlbums;
                        }
                    }

                    ++cantidadGrupos;
                }

                oSql.DataReader1.Close();
                oSql.DataReader2.Close();

                tsl_Consultas.Enabled = true;
                tsmi_AdministradorDatos_Conectar.Enabled = false;
                tsmi_AdministradorDatos_Desconectar.Enabled = true;
            }
        } // Fin CargarClases

        private void tsmi_AdministradorDatos_Desconectar_Click(object sender, EventArgs e)
        {
            oSql.Conexion.Close();
            tsslConexion.Image = global::Music_Manager.Properties.Resources.DeleteDatabase;
            tsslConexion.Text = "Desconectado";
            tsmi_AdministradorDatos_Conectar.Enabled = true;
            tsmi_AdministradorDatos_Desconectar.Enabled = false;
        }

        /* NAME: tv_Grupo_AfterSelect 
         * DESCRIPTION: evento de seleccion de nodo
         * PARAMETERS: object, TreeViewEventArgs
         * RETURNS: void
         */
        private void tv_Grupo_AfterSelect (object sender, TreeViewEventArgs e)
        {
            int dato;

            if (tv_Grupo.SelectedNode.Name != "")
            {
                CleanBoxes();

                EnableBoxes(false);

                dato = BusquedaBinaria(oGrupo, int.Parse(tv_Grupo.SelectedNode.Name));

                if (dato != -1)
                {
                    tbx_IdGrupo.Text = oGrupo[dato].IdGrupo.ToString();
                    tbx_GrupoNombre.Text = oGrupo[dato].Descripcion;
                    tbx_CantidadIntegrantes.Text = oGrupo[dato].CantidadIntegrantes.ToString();
                    lbl_PosicionArreglo.Text = dato.ToString();

                    for (int i = 0; i < oGrupo[dato].OAlbum.Length; ++i)
                    {
                        cbx_Titulo.Items.Add(oGrupo[dato].OAlbum[i].Titulo);
                    }

                    cbx_Titulo.Enabled = true;

                    cbx_Titulo.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Grupo No Encontrado", "Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /* NAME: cbx_Titulo_SelectedIndexChanged 
         * DESCRIPTION: evento de eleccion de album
         * PARAMETERS: object, EventArgs
         * RETURNS: void
         */
        private void cbx_Titulo_SelectedIndexChanged (object sender, EventArgs e)
        {
            int dato;
            int posicion = int.Parse(lbl_PosicionArreglo.Text);

            if (tv_Grupo.SelectedNode.Name != "" && cbx_Titulo.SelectedIndex != -1)
            {
                dato = BusquedaSecuencial(oGrupo, posicion, cbx_Titulo.SelectedItem.ToString());

                if (dato != -1)
                {
                    cbx_Genero.Items.Clear();
                    cbx_IdDisqueria.Items.Clear();
                    cbx_IdCompania.Items.Clear();

                    tbx_IdAlbum.Text = oGrupo[posicion].OAlbum[dato].IdAlbum.ToString();
                    cbx_Genero.Items.Add(oGrupo[posicion].OAlbum[dato].MostrarGenero(oGrupo[posicion].OAlbum[dato].IdGenero));
                    cbx_Genero.SelectedIndex = 0;
                    cbx_IdDisqueria.Items.Add(oGrupo[posicion].OAlbum[dato].MostrarDisqueria(oGrupo[posicion].OAlbum[dato].IdDisqueria));
                    cbx_IdDisqueria.SelectedIndex = 0;
                    cbx_IdCompania.Items.Add(oGrupo[posicion].OAlbum[dato].MostrarCompania(oGrupo[posicion].OAlbum[dato].IdCompania));
                    cbx_IdCompania.SelectedIndex = 0;
                    dtp_FechaTerminado.Value = oGrupo[posicion].OAlbum[dato].FechaTerminado;
                    dtp_FechaLanzamiento.Value = oGrupo[posicion].OAlbum[dato].FechaLanzamiento;
                    tbx_CantidadTemas.Text = oGrupo[posicion].OAlbum[dato].CantidadTemas.ToString();
                    tbx_Duracion.Text = oGrupo[posicion].OAlbum[dato].DuracionAlbum.ToString();
                    tbx_Costo.Text = oGrupo[posicion].OAlbum[dato].Costo.ToString();
                    rtbx_Observaciones.Text = oGrupo[posicion].OAlbum[dato].Obsevaciones;
                }
                else
                {
                    MessageBox.Show("Dato No Encontrado", "Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /* NAME: BusquedaBinaria 
         * DESCRIPTION: busca dato en arreglo mediante metodo binario
         * PARAMETERS: int -1:no encontro dato
         * RETURNS: int
         */
        private int BusquedaBinaria (Grupo[] oGrupo, int Dato)
        {
            int bajo = 0;
            int alto = cantidadGrupos - 1;
            int medio;

            while (bajo <= alto)
            {
                medio = (bajo + alto) / 2;

                if (Dato == (oGrupo[medio] == null ? 0 : oGrupo[medio].IdGrupo)) // si se encuentra el valor
                    return medio;
                else if (Dato < (oGrupo[medio] == null ? 0 : oGrupo[medio].IdGrupo)) // busca en la mitad más baja
                    alto = medio - 1;
                else // busca en la mitad más alta
                    bajo = medio + 1; 
            }

            return -1;
        }

        /* NAME: BusquedaSecuencial 
         * DESCRIPTION: busca dato en arreglo mediante metodo secuencial
         * PARAMETERS: int -1:no encontro dato
         * RETURNS: int
         */
        private int BusquedaSecuencial (Grupo[] oGrupo, int Posicion, string Dato)
        {
            for (int i = 0; i < oGrupo[Posicion].OAlbum.Length; ++i)
            {
                if (Dato.CompareTo(oGrupo[Posicion].OAlbum[i].Titulo) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        /* NAME: EnableBoxes 
         * DESCRIPTION: habilita o deshabilita controles
         * PARAMETERS: bool
         * RETURNS: void
         */
        private void EnableBoxes (bool b)
        {
            foreach (Control obj in this.gbx_Grupo.Controls)
            {
                if (obj is TextBox)
                    obj.Enabled = b;
            }

            foreach (Control obj in this.gbx_Album.Controls)
            {
                if (obj is TextBox || obj is ComboBox || obj is RichTextBox || obj is DateTimePicker)
                    obj.Enabled = b;
            }
        }

        /* NAME: CleanBoxes 
         * DESCRIPTION: limpiar los controles
         * PARAMETERS: void
         * RETURNS: void
         */
        private void CleanBoxes ()
        {
            foreach (Control obj in this.gbx_Grupo.Controls)
            {
                if (obj is TextBox)
                    obj.Text = null;
            }

            foreach (Control obj in this.gbx_Album.Controls)
            {
                if (obj is TextBox || obj is ComboBox || obj is RichTextBox)
                    obj.Text = null;
            }

            lbl_PosicionArreglo.Text = null;
            cbx_Titulo.Items.Clear();
        }

        private void cbx_SeleccionConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_SeleccionConsulta.SelectedIndex)
            {
                case 0:
                    VisibleGroupBoxesConsultas(false);
                    gbx_Consulta01.Visible = true;
                    gbx_Consulta01.Focus();
                    break;
                case 1:
                    VisibleGroupBoxesConsultas(false);
                    gbx_Consulta02.Visible = true;
                    gbx_Consulta02.Focus();
                    break;
                case 2:
                    VisibleGroupBoxesConsultas(false);
                    gbx_Consulta03.Visible = true;
                    gbx_Consulta03.Focus();
                    break;
                case 3:
                    VisibleGroupBoxesConsultas(false);
                    gbx_Consulta04.Visible = true;
                    gbx_Consulta04.Focus();
                    break;
            }
        }

        /* NAME: VisibleGroupBoxesConsultas
         * DESCRIPTION: hace visible los groupbox
         * PARAMETERS: bool
         * RETURNS: void
         */
        private void VisibleGroupBoxesConsultas (bool b)
        {
            foreach (Control obj in this.gbx_Consultas.Controls)
            {
                if (obj is GroupBox)
                    obj.Visible = b;
            }
        }

        /* NAME: btn_Ejecutar
         * DESCRIPTION: ejecuto la consulta (Laboratorio II)
         * PARAMETERS: object, EventArgs
         * RETURNS: void
         */
        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            /*
            dataGridView1.DataSource = null;

            conexion.ConnectionString = stringConexion;
            conexion.Open();

            command.CommandText = textBox1.Text;
            command.Connection = conexion;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);

            conexion.Close();

            dataGridView1.DataSource = dataSet.Tables[0];
            */
        }

        private void btn_Eliminar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el album " + cbx_Titulo.SelectedItem.ToString() + " del Grupo " + tbx_GrupoNombre.Text, 
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!oSql.sp_EliminacionAlbum(int.Parse(tbx_IdAlbum.Text)))
                {
                    MessageBox.Show("Error en la eliminacion del album", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CleanBoxes();

                    CargarClases();
                }
            }
        }

        private void btn_Agregar_Click (object sender, EventArgs e)
        {

        }

        private void btn_Editar_Click (object sender, EventArgs e)
        {

        }

        private void btn_Grabar_Click (object sender, EventArgs e)
        {

        }
    }
}