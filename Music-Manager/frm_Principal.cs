﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
        string botonEditarAgregar;

        public frm_Principal ()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            oSql = new Sql();
            oGrupo = new Grupo[5];
            botonEditarAgregar = null;
        }

        private void frm_Principal_Load (object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar ()
        {
            EnableBoxes(false);

            tsl_Buscar.Visible = false; // Boton Buscar

            tabc_Principal.TabPages.Remove(tab_Consultas);
            tabc_Principal.TabPages.Remove(tab_Disquerias);
            tab_Consultas.Enabled = false;

            lbl_PosicionArreglo.Visible = false;

            tsl_Consultas.Enabled = false;
            tsmi_Archivo_Disquerias.Enabled = false;
            tsmi_AdministradorDatos_Desconectar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Agregar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Grabar.Enabled = false;
        }

        private void tsmi_Archivo_Disquerias_Click (object sender, EventArgs e)
        {
            if (btn_Cancelar.Enabled)
            {
                MessageBox.Show("Tiene tareas pendientes en la pestaña Informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tab_Consultas.Created)
                {
                    tabc_Principal.TabPages.Remove(tab_Consultas);
                    tab_Consultas.Enabled = false;
                    tsl_Consultas.Enabled = true;

                    tabc_Consultas.SelectedTab = tab_Consulta01;

                    cbx_SeleccionConsulta.SelectedIndex = -1;
                    LimpiarConsultas();

                    errorp_Consulta.Clear();
                }

                tabc_Principal.TabPages.Add(tab_Disquerias);
                tabc_Principal.SelectedTab = tab_Disquerias;
                Actualizar_lbx_Disquerias_Descripcion();
                tsmi_Archivo_Disquerias.Enabled = false;

                tv_Grupo.Enabled = false;
            }
        }

        private void tsmi_Archivo_Cerrar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro de Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsl_AcercaDe_Click (object sender, EventArgs e)
        {
            frm_About ofrm_AcercaDe = new frm_About();
            ofrm_AcercaDe.Show();
        }

        private void tsmi_AdministradorDatos_Conectar_Click (object sender, EventArgs e)
        {
            frm_ConectarBaseDeDatos ofrm_ConectarBaseDeDatos = new frm_ConectarBaseDeDatos();
            ofrm_ConectarBaseDeDatos.ShowDialog();

            if (!ofrm_ConectarBaseDeDatos.Error)
            {
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
        }

        private void tsmi_AdministradorDatos_Desconectar_Click (object sender, EventArgs e)
        {
            oSql.Conexion.Close();
            tsslConexion.Image = global::Music_Manager.Properties.Resources.DeleteDatabase;
            tsslConexion.Text = "Desconectado";
            tsmi_AdministradorDatos_Conectar.Enabled = true;
            tsmi_AdministradorDatos_Desconectar.Enabled = false;
            tsmi_Archivo_Disquerias.Enabled = true;
            CleanBoxes();
            tv_Grupo.Nodes.Clear();
            Iniciar();
        }

        /* NAME: CargarClases
         * DESCRIPTION: carga la clase grupo con sus respectivos album's
         * PARAMETERS:
         * RETURNS: void
         */
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

                    oSql.sp_SeleccionAlbumPorGrupo(oGrupo[cantidadGrupos].IdGrupo);

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

                for (int i = 0; i < tv_Grupo.Nodes.Count; ++i)
                {
                    tv_Grupo.Nodes[i].Expand();
                }

                tsl_Consultas.Enabled = true;
                tsmi_Archivo_Disquerias.Enabled = true;
                tsmi_AdministradorDatos_Conectar.Enabled = false;
                tsmi_AdministradorDatos_Desconectar.Enabled = true;
            }
        }

        /* NAME: tv_Grupo_AfterSelect 
         * DESCRIPTION: evento afterSelect de seleccion de nodo del TreeView
         * PARAMETERS:
         * RETURNS: void
         */
        private void tv_Grupo_AfterSelect (object sender, TreeViewEventArgs e)
        {
            int dato;

            cbx_Titulo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (tv_Grupo.SelectedNode.Name != "")
            {
                CleanBoxes();

                EnableBoxes(false);

                dato = BusquedaBinaria(oGrupo, int.Parse(tv_Grupo.SelectedNode.Name));

                if (dato != -1)
                {
                    tbx_IdGrupo.Text = oGrupo[dato].IdGrupo.ToString();
                    cbx_GrupoNombre.Items.Add(oGrupo[dato].Descripcion);
                    cbx_GrupoNombre.SelectedIndex = 0;
                    tbx_CantidadIntegrantes.Text = oGrupo[dato].CantidadIntegrantes.ToString();
                    lbl_PosicionArreglo.Text = dato.ToString();

                    for (int i = 0; i < oGrupo[dato].OAlbum.Length; ++i)
                    {
                        cbx_Titulo.Items.Add(oGrupo[dato].OAlbum[i].Titulo);
                    }

                    cbx_Titulo.Enabled = true;
                    cbx_Titulo.SelectedIndex = 0;

                    btn_Eliminar.Enabled = true;
                    btn_Editar.Enabled = true;
                    btn_Agregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Grupo No Encontrado", "Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CleanBoxes();

                EnableBoxes(false);

                btn_Eliminar.Enabled = false;
                btn_Editar.Enabled = false;
                btn_Agregar.Enabled = false;
                btn_Cancelar.Enabled = false;
                btn_Grabar.Enabled = false;
            }
        }

        /* NAME: cbx_Titulo_SelectedIndexChanged 
         * DESCRIPTION: evento indexChanged de seleccion de album
         * PARAMETERS: 
         * RETURNS: void
         */
        private void cbx_Titulo_SelectedIndexChanged (object sender, EventArgs e)
        {
            int dato;
            int posicion = int.Parse(lbl_PosicionArreglo.Text);

            if (tv_Grupo.SelectedNode.Name != "" && cbx_Titulo.SelectedIndex != -1)
            {
                CargarComboBoxesGeneroDisqueriaCompania();

                dato = cbx_Titulo.SelectedIndex;

                tbx_IdAlbum.Text = oGrupo[posicion].OAlbum[dato].IdAlbum.ToString();
                cbx_Genero.SelectedValue = oGrupo[posicion].OAlbum[dato].IdGenero.ToString();
                cbx_Disqueria.SelectedValue = oGrupo[posicion].OAlbum[dato].IdDisqueria.ToString();
                cbx_Compania.SelectedValue = oGrupo[posicion].OAlbum[dato].IdCompania.ToString();
                dtp_FechaTerminado.Value = oGrupo[posicion].OAlbum[dato].FechaTerminado;
                dtp_FechaLanzamiento.Value = oGrupo[posicion].OAlbum[dato].FechaLanzamiento;
                tbx_CantidadTemas.Text = oGrupo[posicion].OAlbum[dato].CantidadTemas.ToString();
                tbx_Duracion.Text = oGrupo[posicion].OAlbum[dato].DuracionAlbum.ToString();
                tbx_Costo.Text = oGrupo[posicion].OAlbum[dato].Costo.ToString();
                rtbx_Observaciones.Text = oGrupo[posicion].OAlbum[dato].Obsevaciones;
            }
        }

        /* NAME: BusquedaBinaria 
         * DESCRIPTION: busca dato en arreglo mediante metodo binario
         * PARAMETERS: 
         * RETURNS: int -1:no encontro dato
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

        /* NAME: EnableBoxes 
         * DESCRIPTION: habilita o deshabilita controles
         * PARAMETERS: bool
         * RETURNS: void
         */
        private void EnableBoxes (bool b)
        {
            foreach (Control obj in this.gbx_Grupo.Controls)
            {
                if (obj is TextBox || obj is ComboBox)
                {
                    obj.Enabled = b;
                }
            }

            foreach (Control obj in this.gbx_Album.Controls)
            {
                if (obj is TextBox || obj is ComboBox || obj is RichTextBox || obj is DateTimePicker)
                {
                    obj.Enabled = b;
                }
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
                if (obj is TextBox || obj is ComboBox)
                    obj.Text = null;
            }

            foreach (Control obj in this.gbx_Album.Controls)
            {
                if (obj is TextBox || obj is ComboBox || obj is RichTextBox)
                    obj.Text = null;
            }

            lbl_PosicionArreglo.Text = null;
            cbx_GrupoNombre.Items.Clear();
            cbx_Titulo.Items.Clear();
        }

        public void CargarComboBoxesGeneroDisqueriaCompania()
        {
            if (!oSql.sp_CargarGeneros())
            {
                MessageBox.Show("Error Cargar Generos\n" + oSql.stringError, "Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbx_Genero.DataSource = oSql.DataSet1;
                cbx_Genero.DisplayMember = "generos.descricpion";
                cbx_Genero.ValueMember = "generos.id_genero";
            }

            if (!oSql.sp_CargarDisquerias())
            {
                MessageBox.Show("Error Cargar Disquerias\n" + oSql.stringError, "Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbx_Disqueria.DataSource = oSql.DataSet1;
                cbx_Disqueria.DisplayMember = "disquerias.descripcion";
                cbx_Disqueria.ValueMember = "disquerias.id_disqueria";
            }

            if (!oSql.sp_CargarCompanias())
            {
                MessageBox.Show("Error Cargar Compañias\n" + oSql.stringError, "Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbx_Compania.DataSource = oSql.DataSet1;
                cbx_Compania.DisplayMember = "companias.descripcion";
                cbx_Compania.ValueMember = "companias.id_compania";
            }
        }

        /* NAME: btn_Eliminar_Click
         * DESCRIPTION: evento click del boton Eliminar del tab_Informacion
         * PARAMETERS: 
         * RETURNS: void
         */
        private void btn_Eliminar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el album " + cbx_Titulo.SelectedItem.ToString() + " del Grupo " + cbx_GrupoNombre.SelectedItem.ToString(), 
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

        /* NAME: btn_Agregar_Click
         * DESCRIPTION: evento click del boton Agregar del tab_Informacion
         * PARAMETERS: 
         * RETURNS: void
         */
        private void btn_Agregar_Click (object sender, EventArgs e)
        {
            foreach (Control obj in this.gbx_Album.Controls)
            {
                if (obj is TextBox || obj is ComboBox || obj is RichTextBox)
                    obj.Text = null;
            }

            cbx_Titulo.Items.Clear();

            EnableBoxes(true);

            tbx_IdGrupo.Enabled = false;
            cbx_GrupoNombre.Enabled = false;
            tbx_CantidadIntegrantes.Enabled = false;
            tbx_IdAlbum.Enabled = false;

            cbx_Titulo.DropDownStyle = ComboBoxStyle.DropDown;

            btn_Eliminar.Enabled = false;
            btn_Agregar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Grabar.Enabled = true;

            botonEditarAgregar = "agregar";
        }

        /* NAME: btn_Editar_Click
         * DESCRIPTION: evento click del boton Editar del tab_Informacion
         * PARAMETERS: 
         * RETURNS: void
         */
        private void btn_Editar_Click (object sender, EventArgs e)
        {
            EnableBoxes(true);

            tbx_IdGrupo.Enabled = false;
            cbx_GrupoNombre.Enabled = false;
            tbx_CantidadIntegrantes.Enabled = false;
            tbx_IdAlbum.Enabled = false;

            cbx_Titulo.DropDownStyle = ComboBoxStyle.Simple;

            btn_Eliminar.Enabled = false;
            btn_Agregar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Grabar.Enabled = true;

            botonEditarAgregar = "editar";
        }

        /* NAME: btn_Cancelar_Click
         * DESCRIPTION: evento click del boton Cancelar del tab_Informacion
         * PARAMETERS: 
         * RETURNS: void
         */
        private void btn_Cancelar_Click (object sender, EventArgs e)
        {
            CleanBoxes();

            EnableBoxes(false);

            btn_Cancelar.Enabled = false;
            btn_Grabar.Enabled = false;

            CargarClases();
        }

        /* NAME: btn_Grabar_Click
         * DESCRIPTION: evento click del boton Grabar del tab_Informacion
         * PARAMETERS: 
         * RETURNS: void
         */
        private void btn_Grabar_Click (object sender, EventArgs e)
        {
            if (tbx_Costo.Text == "" || tbx_CantidadTemas.Text == "" || tbx_Duracion.Text == "")
            {
                MessageBox.Show("Llene los casilleros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.Match(tbx_CantidadTemas.Text, @"^[0-9]*$").Success)
            {
                MessageBox.Show("Verifique la cantidad de Temas del Album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.Match(tbx_Duracion.Text, @"^[0-9]*$").Success)
            {
                MessageBox.Show("Verifique le Duracion del Album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.Match(tbx_Costo.Text, @"^[0-9]*$").Success)
            {
                MessageBox.Show("Verifique el Costo del Album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DateTime.Compare(dtp_FechaTerminado.Value.Date, dtp_FechaLanzamiento.Value.Date) > 0)
            {
                MessageBox.Show("La Fecha de Terminado no puede ser mayor que la Fecha de Lanzamiento", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ("agregar".CompareTo(botonEditarAgregar) == 0)
                {
                    if (!oSql.sp_AgregarAlbum(Convert.ToInt32(cbx_Genero.SelectedValue), Convert.ToInt32(cbx_Disqueria.SelectedValue),
                        Convert.ToInt32(cbx_Compania.SelectedValue), int.Parse(tbx_IdGrupo.Text), int.Parse(tbx_CantidadIntegrantes.Text) > 1 ? true : false,
                        cbx_Titulo.Text, decimal.Parse(tbx_Costo.Text), dtp_FechaTerminado.Value.Date, dtp_FechaLanzamiento.Value.Date, int.Parse(tbx_CantidadTemas.Text),
                        int.Parse(tbx_Duracion.Text), rtbx_Observaciones.Text))
                    {
                        MessageBox.Show("Error al agregar album", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CleanBoxes();

                        EnableBoxes(false);
                        btn_Eliminar.Enabled = true;
                        btn_Agregar.Enabled = true;
                        btn_Editar.Enabled = true;
                        btn_Cancelar.Enabled = false;
                        btn_Grabar.Enabled = false;

                        CargarClases();
                    }
                }

                if ("editar".CompareTo(botonEditarAgregar) == 0)
                {
                    if (!oSql.sp_ModificarAlbum(int.Parse(tbx_IdAlbum.Text), Convert.ToInt32(cbx_Genero.SelectedValue), Convert.ToInt32(cbx_Disqueria.SelectedValue),
                        Convert.ToInt32(cbx_Compania.SelectedValue), int.Parse(tbx_IdGrupo.Text), int.Parse(tbx_CantidadIntegrantes.Text) > 1 ? true : false,
                        cbx_Titulo.Text, decimal.Parse(tbx_Costo.Text), dtp_FechaTerminado.Value.Date, dtp_FechaLanzamiento.Value.Date,
                        int.Parse(tbx_CantidadTemas.Text), int.Parse(tbx_Duracion.Text), rtbx_Observaciones.Text))
                    {
                        MessageBox.Show("Error al modificar album", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CleanBoxes();

                        EnableBoxes(false);
                        btn_Eliminar.Enabled = true;
                        btn_Agregar.Enabled = true;
                        btn_Editar.Enabled = true;
                        btn_Cancelar.Enabled = false;
                        btn_Grabar.Enabled = false;

                        CargarClases();
                    }
                }
            }
        }

        //####################################################################
        //## ABM Disquerias ##################################################
        //####################################################################

        private void btn_Disquerias_Ejecutar_Click(object sender, EventArgs e)
        {
            if (rbtn_Disquerias_Agregar.Checked)
            {
                if (tbx_Disquerias_Item.Text == "")
                {
                    MessageBox.Show("Imposible Agregar Disqueria Vacia\n" + oSql.stringError, "Disquerias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!oSql.sp_AgregarDisqueria(tbx_Disquerias_Item.Text))
                    {
                        MessageBox.Show("Error Agregar Genero\n" + oSql.stringError, "Disquerias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tbx_Disquerias_Item.Text = null;
                        Actualizar_lbx_Disquerias_Descripcion();
                    }
                }
            }
            else if (rbtn_Disquerias_Eliminar.Checked)
            {
                if (!oSql.sp_EliminarDisqueria(Convert.ToInt32(lbx_Disquerias_Descripcion.SelectedValue)))
                {
                    MessageBox.Show("Error Eliminar Genero\n" + oSql.stringError, "Disquerias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Actualizar_lbx_Disquerias_Descripcion();
                }
            }
            else if (rbtn_Disquerias_Modificar.Checked)
            {
                if (tbx_Disquerias_Item.Text == "")
                {
                    MessageBox.Show("Imposible Modificar " + lbx_Disquerias_Descripcion.Text + " por Disqueria Vacia\n" + oSql.stringError, "Disquerias", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!oSql.sp_ModificarDisqueria(Convert.ToInt32(lbx_Disquerias_Descripcion.SelectedValue),
                        tbx_Disquerias_Item.Text))
                    {
                        MessageBox.Show("Error Modificar Genero\n" + oSql.stringError, "Disquerias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Actualizar_lbx_Disquerias_Descripcion();
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna opcion\n" + oSql.stringError, "Disquerias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar_lbx_Disquerias_Descripcion()
        {
            oSql.sp_CargarDisquerias();
            lbx_Disquerias_Descripcion.DataSource = oSql.DataSet1;
            lbx_Disquerias_Descripcion.DisplayMember = "disquerias.descripcion";
            lbx_Disquerias_Descripcion.ValueMember = "disquerias.id_disqueria";
        }

        private void lbx_Disquerias_Descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtn_Disquerias_Modificar.Checked)
            {
                tbx_Disquerias_Item.Text = lbx_Disquerias_Descripcion.Text;
            }
        }

        private void rbtn_Disquerias_Modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Disquerias_Agregar.Checked)
            {
                tbx_Disquerias_Item.Enabled = true;
                tbx_Disquerias_Item.Text = null;
            }
            else if (rbtn_Disquerias_Modificar.Checked)
            {
                tbx_Disquerias_Item.Enabled = true;
                tbx_Disquerias_Item.Text = lbx_Disquerias_Descripcion.Text;
            }
            else if (rbtn_Disquerias_Eliminar.Checked)
            {
                tbx_Disquerias_Item.Text = null;
                tbx_Disquerias_Item.Enabled = false;
            }
        }

        //####################################################################
        //## LABORATORIO #####################################################
        //####################################################################

        private void tabc_Principal_Selecting (object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tab_Informacion)
            {
                if (tab_Consultas.Created)
                {
                    tabc_Principal.TabPages.Remove(tab_Consultas);
                    tab_Consultas.Enabled = false;
                    tsl_Consultas.Enabled = true;

                    tabc_Consultas.SelectedTab = tab_Consulta01;

                    cbx_SeleccionConsulta.SelectedIndex = -1;
                    LimpiarConsultas();

                    errorp_Consulta.Clear();

                    tv_Grupo.Enabled = true;
                }
                
                if (tab_Disquerias.Created)
                {
                    tabc_Principal.TabPages.Remove(tab_Disquerias);
                    tsmi_Archivo_Disquerias.Enabled = true;

                    tv_Grupo.Enabled = true;
                }
            }
        }

        private void tsl_Consultas_Click (object sender, EventArgs e)
        {
            if (btn_Cancelar.Enabled)
            {
                MessageBox.Show("Tiene tareas pendientes en la pestaña Informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tv_Grupo.Enabled = false;

                tsl_Consultas.Enabled = false;
                tabc_Principal.TabPages.Add(tab_Consultas);
                tab_Consultas.Enabled = true;
                tabc_Principal.SelectedTab = tab_Consultas;
                tabc_Consultas.Enabled = false;
                btn_Ejecutar.Enabled = false;
            }
        }

        private void cbx_SeleccionConsulta_SelectedIndexChanged (object sender, EventArgs e)
        {
            tabc_Consultas.Enabled = true;
            btn_Ejecutar.Enabled = true;

            lbl_Consulta_ModificarPor.Visible = false;
            tbx_Consulta_ModificarPor.Visible = false;

            switch (cbx_SeleccionConsulta.SelectedIndex)
            {
                case 0:
                    tabc_Consultas.SelectedTab = tab_Consulta01;
                    break;
                case 1:
                    tabc_Consultas.SelectedTab = tab_Consulta02;
                    break;
                case 2:
                    tabc_Consultas.SelectedTab = tab_Consulta03;
                    break;
                case 3:
                    tabc_Consultas.SelectedTab = tab_Consulta04;
                    break;
                case 4:
                    tabc_Consultas.SelectedTab = tab_Generos;
                    cbx_Consulta_EleccionABM.SelectedIndex = 0;
                    break;
            }
        }

        private void cbx_Consulta_EleccionABM_SelectedIndexChanged (object sender, EventArgs e)
        {
            lbl_Consulta_ModificarPor.Visible = false;
            tbx_Consulta_ModificarPor.Visible = false;

            if (cbx_Consulta_EleccionABM.SelectedIndex == 0) // Agregar
            {
                if (!oSql.sp_CargarGeneros())
                {
                    MessageBox.Show("Error Cargar Generos\n" + oSql.stringError, "ABM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MostrarDataGridView();
                    pbx_Consultas.Image = null;
                    cbx_Consulta_Genero2.SelectedIndex = -1;
                    cbx_Consulta_Genero2.DropDownStyle = ComboBoxStyle.Simple;
                }
            }
            else if (cbx_Consulta_EleccionABM.SelectedIndex == 1) // Eliminar
            {
                Actualizar_cbx_Consulta_Genero2();
                cbx_Consulta_Genero2.SelectedIndex = 0;
                cbx_Consulta_Genero2.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (cbx_Consulta_EleccionABM.SelectedIndex == 2) // Modificar
            {
                lbl_Consulta_ModificarPor.Visible = true;
                tbx_Consulta_ModificarPor.Visible = true;
                Actualizar_cbx_Consulta_Genero2();
                cbx_Consulta_Genero2.SelectedIndex = 0;
                cbx_Consulta_Genero2.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        /* NAME: btn_Ejecutar
         * DESCRIPTION: ejecuto la consulta (Laboratorio II)
         * PARAMETERS: object, EventArgs
         * RETURNS: void
         */
        private void btn_Ejecutar_Click (object sender, EventArgs e)
        {
            if (tabc_Consultas.SelectedTab == tab_Consulta01) // Eleccion del tab Consulta01
            {
                if (ValidacionNombreGrupo())
                {
                    errorp_Consulta.Clear();
                    if (!oSql.sp_Consulta01(tbx_Consulta_NombreGrupo.Text))
                    {
                        MessageBox.Show("Error Consulta01", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MostrarDataGridView();
                    }
                }
            }
            else if (tabc_Consultas.SelectedTab == tab_Consulta02) // Eleccion del tab Consulta02
            {
                if (ValidacionGenero())
                {
                    errorp_Consulta.Clear();
                    if (!oSql.sp_Consulta02(tbx_Consulta_Genero.Text))
                    {
                        MessageBox.Show("Error Consulta02", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MostrarDataGridView();
                    }
                }
            }
            else if (tabc_Consultas.SelectedTab == tab_Consulta03) // Eleccion del tab Consulta03
            {
                if (ValidacionAnio())
                {
                    errorp_Consulta.Clear();
                    if (!oSql.sp_Consulta03(int.Parse(tbx_Consulta_Anio.Text)))
                    {
                        MessageBox.Show("Error Consulta03", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MostrarDataGridView();
                    }
                }
            }
            else if (tabc_Consultas.SelectedTab == tab_Consulta04) // Eleccion del tab Consulta04
            {
                if (ValidacionNombreGrupo2() && ValidacionDuracionAlbum())
                {
                    errorp_Consulta.Clear();
                    if (!oSql.sp_Consulta04(tbx_Consulta_NombreGrupo2.Text, dtp_Consulta_FechaDesde.Value.Date,
                        dtp_Consulta_FechaHasta.Value.Date, int.Parse(cbx_Consulta_DuracionAlbum.SelectedItem.ToString())))
                    {
                        MessageBox.Show("Error Consulta04", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MostrarDataGridView();
                    }
                }
            }
            else if (tabc_Consultas.SelectedTab == tab_Generos) // Eleccion del tab Generos
            {
                if (ValidacionGenero2())
                {
                    errorp_Consulta.Clear();
                    if (cbx_Consulta_EleccionABM.SelectedIndex == 0) // Agregar
                    {
                        if (!oSql.sp_AgregarGenero(cbx_Consulta_Genero2.Text))
                        {
                            MessageBox.Show("Error Agregar Genero\n" + oSql.stringError, "ABM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Actualizar_cbx_Consulta_Genero2();
                            MostrarDataGridView();
                        }
                    }
                    else if (cbx_Consulta_EleccionABM.SelectedIndex == 1) // Eliminar
                    {
                        if (!oSql.sp_EliminarGenero(Convert.ToInt32(cbx_Consulta_Genero2.SelectedValue)))
                        {
                            MessageBox.Show("Error Eliminar Genero\n" + oSql.stringError, "ABM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Actualizar_cbx_Consulta_Genero2();
                            MostrarDataGridView();
                        }
                    }
                    else if (cbx_Consulta_EleccionABM.SelectedIndex == 2) // Modificar
                    {
                        if (tbx_Consulta_ModificarPor.Text != "")
                        {
                            if (!oSql.sp_ModificarGenero(Convert.ToInt32(cbx_Consulta_Genero2.SelectedValue), tbx_Consulta_ModificarPor.Text))//cbx_Consulta_Genero2.Text))
                            {
                                MessageBox.Show("Error Modificar Genero\n" + oSql.stringError, "ABM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                tbx_Consulta_ModificarPor.Text = null;
                                Actualizar_cbx_Consulta_Genero2();
                                MostrarDataGridView();
                            }
                        }
                    }
                }
            }
        }

        private void cbx_Consulta_Genero2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Consulta_EleccionABM.SelectedIndex == 2)
                tbx_Consulta_ModificarPor.Text = cbx_Consulta_Genero2.Text;
        }

        private void Actualizar_cbx_Consulta_Genero2 ()
        {
            if (!oSql.sp_CargarGeneros())
            {
                MessageBox.Show("Error Cargar Generos\n" + oSql.stringError, "ABM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbx_Consulta_Genero2.DataSource = oSql.DataSet1;
                cbx_Consulta_Genero2.DisplayMember = "generos.descricpion";
                cbx_Consulta_Genero2.ValueMember = "generos.id_genero";
            }
        }

        private void MostrarDataGridView ()
        {
            //dgv_Consultas.DataSource = null;
            dgv_Consultas.DataSource = oSql.DataSet1.Tables[0];
            
            if (tabc_Consultas.SelectedTab == tab_Generos)
                dgv_Consultas.Columns[0].Visible = false; // Oculto la columna id_genero

            if ((dgv_Consultas.RowCount) == 0)
            {
                pbx_Consultas.Image = global::Music_Manager.Properties.Resources.Error;
                tbx_Resultado.Text = "Ningun Resultado Encontrado";
            }
            else
            {
                pbx_Consultas.Image = global::Music_Manager.Properties.Resources.GoodTick;
                tbx_Resultado.Text = (dgv_Consultas.RowCount) + " Resultados Encontrados";
            }
        }

        private void LimpiarConsultas ()
        {
            pbx_Consultas.Image = null;
            errorp_Consulta.Clear();
            dgv_Consultas.DataSource = null;
            tbx_Resultado.Text = null;
        }

        private void tabc_Consultas_SelectedIndexChanged (object sender, EventArgs e)
        {
            LimpiarConsultas();
        }

        //####################################################################
        //## Validacion de campos - Consulta #################################
        //####################################################################

        private void tbx_Consulta_NombreGrupo_Validating (object sender, CancelEventArgs e)
        {
            ValidacionNombreGrupo();
        }

        private bool ValidacionNombreGrupo ()
        {
            bool b = true;

            if (tbx_Consulta_NombreGrupo.Text == "")
            {
                errorp_Consulta.SetError(tbx_Consulta_NombreGrupo, "Ingrese Nombre Grupo");
                b = false;
            }
            else
            {
                errorp_Consulta.SetError(tbx_Consulta_NombreGrupo, "");
            }

            return b;
        }

        private void tbx_Consulta_Anio_Validating (object sender, CancelEventArgs e)
        {
            ValidacionAnio();
        }

        private bool ValidacionAnio ()
        {
            bool b = true;

            if (tbx_Consulta_Anio.Text == "")
            {
                errorp_Consulta.SetError(tbx_Consulta_Anio, "Ingrese Año - Ej. 1988");
                b = false;
            }
            else
            {
                errorp_Consulta.SetError(tbx_Consulta_Anio, "");
            }

            return b;
        }

        private void tbx_Consulta_Genero_Validating (object sender, CancelEventArgs e)
        {
            ValidacionGenero();
        }

        private bool ValidacionGenero ()
        {
            bool b = true;

            if (tbx_Consulta_Genero.Text == "")
            {
                errorp_Consulta.SetError(tbx_Consulta_Genero, "Ingrese Genero");
                b = false;
            }
            else
            {
                errorp_Consulta.SetError(tbx_Consulta_Genero, "");
            }

            return b;
        }

        private void tbx_Consulta_NombreGrupo2_Validating (object sender, CancelEventArgs e)
        {
            ValidacionNombreGrupo2();
        }

        private bool ValidacionNombreGrupo2 ()
        {
            bool b = true;

            if (tbx_Consulta_NombreGrupo2.Text == "")
            {
                errorp_Consulta.SetError(tbx_Consulta_NombreGrupo2, "Ingrese Nombre Grupo");
                b = false;
            }
            else
            {
                errorp_Consulta.SetError(tbx_Consulta_NombreGrupo2, "");
            }

            return b;
        }

        private void cbx_Consulta_DuracionAlbum_Validating (object sender, CancelEventArgs e)
        {
            ValidacionDuracionAlbum();
        }

        private bool ValidacionDuracionAlbum ()
        {
            bool b = true;

            if (cbx_Consulta_DuracionAlbum.SelectedItem == null)
            {
                errorp_Consulta.SetError(cbx_Consulta_DuracionAlbum, "Ingrese Nombre Grupo");
                b = false;
            }
            else
            {
                errorp_Consulta.SetError(cbx_Consulta_DuracionAlbum, "");
            }

            return b;
        }

        private void cbx_Consulta_Genero2_Validating (object sender, CancelEventArgs e)
        {
            ValidacionGenero2();
        }

        private bool ValidacionGenero2 ()
        {
            bool b = true;

            if (cbx_Consulta_Genero2.Text == "" && cbx_Consulta_Genero2.SelectedValue == null && cbx_Consulta_Genero2.SelectedItem == null)
            {
                errorp_Consulta.SetError(cbx_Consulta_Genero2, "Ingrese Genero");
                b = false;
            }
            else
            {
                errorp_Consulta.SetError(cbx_Consulta_Genero2, "");
            }

            return b;
        }

        //####################################################################
        //## FIN - Validacion de campos - Consulta ###########################
        //####################################################################
    }
}