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
            cantidadGrupos = 0;
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            EnableBoxes(false);
        }

        private void tsbAcercaDe_Click(object sender, EventArgs e)
        {
            frm_About ofrm_AcercaDe = new frm_About();
            ofrm_AcercaDe.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        { 
            frm_ConsultasSQL frm_consultasSQL = new frm_ConsultasSQL();
            frm_consultasSQL.Show();
        }

        private void tsddbABD_Conectar_Click (object sender, EventArgs e)
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

                        if (!oSql.sp_SeleccionNombreGrupo())
                        {
                            MessageBox.Show("Error en la consulta", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            TreeNode rn_Conjuntos = tv_Grupo.Nodes.Add("Conjuntos");
                            TreeNode rn_Solistas = tv_Grupo.Nodes.Add("Solistas");

                            int cantidadAlbums;

                            while (oSql.DataReader1.Read())
                            {
                                oGrupo[cantidadGrupos] = new Grupo((int)oSql.DataReader1["cant_albums"]);
                                oGrupo[cantidadGrupos].IdGrupo = (int)oSql.DataReader1["id_grupo"];
                                oGrupo[cantidadGrupos].Descripcion = (string)oSql.DataReader1["descripcion"];
                                oGrupo[cantidadGrupos].IdCompania = (int)oSql.DataReader1["id_compania"];
                                oGrupo[cantidadGrupos].CantidadIntegrantes = (byte)oSql.DataReader1["cant_integrantes"];
                                oGrupo[cantidadGrupos].SolistaConjunto = (bool)oSql.DataReader1["solista_conjunto"];
                                
                                if (oGrupo[cantidadGrupos].SolistaConjunto == true)
                                    rn_Solistas.Nodes.Add("" + oGrupo[cantidadGrupos].IdGrupo + "", oGrupo[cantidadGrupos].Descripcion);
                                else
                                    rn_Conjuntos.Nodes.Add("" + oGrupo[cantidadGrupos].IdGrupo + "", oGrupo[cantidadGrupos].Descripcion);
                                    
                                cantidadAlbums = 0;

                                oSql.sp_SeleccionAlbumPorGrupo(oGrupo[cantidadGrupos].Descripcion);

                                using (oSql.DataReader2)
                                {
                                    while (oSql.DataReader2.Read())
                                    {
                                        //id_album    id_genero   id_disqueria id_compania id_grupo    varios_artistas titulo
                                        //costo                                   fecha_terminado         fecha_lanzamiento       
                                        //cant_temas  duracion_album observaciones                                                                    id_grupo    descripcion                    id_compania cant_integrantes solista_conjunto

                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums] = new Album();
                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdAlbum = (int)oSql.DataReader2["id_album"];
                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdGenero = (int)oSql.DataReader2["id_genero"];
                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdDisqueria = (int)oSql.DataReader2["id_disqueria"];
                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdCompania = (int)oSql.DataReader2["id_compania"];
                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].IdGrupo = (int)oSql.DataReader2["id_grupo"];
                                        oGrupo[cantidadGrupos].OAlbum[cantidadAlbums].Titulo = (string)oSql.DataReader2["titulo"];
                                        ++cantidadAlbums;
                                    }
                                }

                                oSql.DataReader2.Close();

                                ++cantidadGrupos;
                            }

                            oSql.DataReader1.Close();
                        }
                    }
                }
            }
        }

        private void cerrarToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void tv_Grupo_AfterSelect (object sender, TreeViewEventArgs e)
        {
            int dato;

            if (tv_Grupo.SelectedNode.Name != "")
            {
                CleanBoxes();

                EnableBoxes(false);

                dato = BusquedaBinaria(oGrupo, int.Parse(tv_Grupo.SelectedNode.Name));

                tbx_GrupoNombre.Text = oGrupo[dato].Descripcion;
                tbx_CantidadIntegrantes.Text = oGrupo[dato].CantidadIntegrantes.ToString();

                for (int i = 0; i < oGrupo[dato].OAlbum.Length; ++i)
                {
                    cbx_Titulo.Items.Add(oGrupo[dato].OAlbum[i].Titulo);
                }

                cbx_Titulo.Enabled = true;
            }
        }

        private void cbx_Titulo_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private int BusquedaBinaria (Grupo[] oGrupo, int Dato)
        {
            int bajo = 0;
            int alto = cantidadGrupos - 1;
            int medio;

            while (bajo <= alto)
            {
                medio = (bajo + alto) / 2;

                if (Dato == (oGrupo[medio] == null ? 0 : oGrupo[medio].IdGrupo))
                    return medio;
                else if (Dato < (oGrupo[medio] == null ? 0 : oGrupo[medio].IdGrupo))
                    alto = medio - 1;
                else
                    bajo = medio + 1;
            }

            return 0;
        }

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

            cbx_Titulo.Items.Clear();
        }

        private void cbx_SeleccionConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_SeleccionConsulta.SelectedIndex)
            {
                case 0:
                    label1.Visible = true;
                    label1.Text = "Nombre Grupo";
                    textBox1.Visible = true;
                    break;
                case 1:
                    label1.Visible = true;
                    label1.Text = "Genero";
                    textBox1.Visible = true;
                    break;
                case 2:
                    label1.Visible = true;
                    label1.Text = "Año";
                    textBox1.Visible = true;
                    break;
                case 3:
                    label1.Visible = true;
                    label1.Text = "Nombre Grupo";
                    textBox1.Visible = true;
                    label2.Visible = true;
                    label2.Text = "Desde";
                    break;
            }
        }
    }
}