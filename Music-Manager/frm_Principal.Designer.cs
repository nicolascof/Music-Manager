namespace Music_Manager
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tv_Grupo = new System.Windows.Forms.TreeView();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsddb_Archivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_Archivo_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddb_AdministradorDatos = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_AdministradorDatos_Conectar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AdministradorDatos_Desconectar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_Consultas = new System.Windows.Forms.ToolStripButton();
            this.tsl_Buscar = new System.Windows.Forms.ToolStripLabel();
            this.tsl_AcercaDe = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab_Info = new System.Windows.Forms.TabPage();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.gbx_Album = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_IdCompania = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_IdDisqueria = new System.Windows.Forms.ComboBox();
            this.tbx_IdAlbum = new System.Windows.Forms.TextBox();
            this.lbl_IdCompania = new System.Windows.Forms.Label();
            this.lbl_IdDisqueria = new System.Windows.Forms.Label();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.tbx_Costo = new System.Windows.Forms.TextBox();
            this.cbx_Titulo = new System.Windows.Forms.ComboBox();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.lbl_DuracionAlbum = new System.Windows.Forms.Label();
            this.lbl_CantidadTemas = new System.Windows.Forms.Label();
            this.lbl_FechaLanzamiento = new System.Windows.Forms.Label();
            this.lbl_FechaTerminado = new System.Windows.Forms.Label();
            this.rtbx_Observaciones = new System.Windows.Forms.RichTextBox();
            this.tbx_Duracion = new System.Windows.Forms.TextBox();
            this.tbx_CantidadTemas = new System.Windows.Forms.TextBox();
            this.dtp_FechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaTerminado = new System.Windows.Forms.DateTimePicker();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cbx_Genero = new System.Windows.Forms.ComboBox();
            this.gbx_Grupo = new System.Windows.Forms.GroupBox();
            this.cbx_GrupoNombre = new System.Windows.Forms.ComboBox();
            this.lbl_PosicionArreglo = new System.Windows.Forms.Label();
            this.lbl_IdGrupo = new System.Windows.Forms.Label();
            this.tbx_IdGrupo = new System.Windows.Forms.TextBox();
            this.lbl_CantidadIntegrantes = new System.Windows.Forms.Label();
            this.tbx_CantidadIntegrantes = new System.Windows.Forms.TextBox();
            this.lbl_Grupo_Nombre = new System.Windows.Forms.Label();
            this.tabc_Principal = new System.Windows.Forms.TabControl();
            this.tab_Consultas = new System.Windows.Forms.TabPage();
            this.gbx_Consultas = new System.Windows.Forms.GroupBox();
            this.pbx_Consultas = new System.Windows.Forms.PictureBox();
            this.tabc_Consultas = new System.Windows.Forms.TabControl();
            this.tab_Consulta01 = new System.Windows.Forms.TabPage();
            this.tbx_Consulta_NombreGrupo = new System.Windows.Forms.TextBox();
            this.lbl_Consulta_NombreGrupo = new System.Windows.Forms.Label();
            this.tab_Consulta02 = new System.Windows.Forms.TabPage();
            this.tbx_Consulta_Genero = new System.Windows.Forms.TextBox();
            this.lbl_Consulta_Genero = new System.Windows.Forms.Label();
            this.tab_Consulta03 = new System.Windows.Forms.TabPage();
            this.tbx_Consulta_Anio = new System.Windows.Forms.TextBox();
            this.lbl_Consulta_Anio = new System.Windows.Forms.Label();
            this.tab_Consulta04 = new System.Windows.Forms.TabPage();
            this.cbx_Consulta_DuracionAlbum = new System.Windows.Forms.ComboBox();
            this.lbl_Consulta_DuracionAlbum = new System.Windows.Forms.Label();
            this.tbx_Consulta_NombreGrupo2 = new System.Windows.Forms.TextBox();
            this.lbl_Consulta_NombreGrupo2 = new System.Windows.Forms.Label();
            this.lbl_Consulta_FechaHasta = new System.Windows.Forms.Label();
            this.dtp_Consulta_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtp_Consulta_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_Consulta_FechaDesde = new System.Windows.Forms.Label();
            this.tab_Generos = new System.Windows.Forms.TabPage();
            this.cbx_Consulta_SeleccionABM = new System.Windows.Forms.ComboBox();
            this.cbx_Consulta_GenerosDescripcion = new System.Windows.Forms.ComboBox();
            this.dgv_Consultas = new System.Windows.Forms.DataGridView();
            this.tbx_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.lbl_SeleccionConsulta = new System.Windows.Forms.Label();
            this.cbx_SeleccionConsulta = new System.Windows.Forms.ComboBox();
            this.errorp_Consulta = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.tab_Info.SuspendLayout();
            this.gbx_Album.SuspendLayout();
            this.gbx_Grupo.SuspendLayout();
            this.tabc_Principal.SuspendLayout();
            this.tab_Consultas.SuspendLayout();
            this.gbx_Consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbx_Consultas)).BeginInit();
            this.tabc_Consultas.SuspendLayout();
            this.tab_Consulta01.SuspendLayout();
            this.tab_Consulta02.SuspendLayout();
            this.tab_Consulta03.SuspendLayout();
            this.tab_Consulta04.SuspendLayout();
            this.tab_Generos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_Consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorp_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_Grupo
            // 
            this.tv_Grupo.Location = new System.Drawing.Point(0, 28);
            this.tv_Grupo.Name = "tv_Grupo";
            this.tv_Grupo.Size = new System.Drawing.Size(199, 542);
            this.tv_Grupo.TabIndex = 1;
            this.tv_Grupo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Grupo_AfterSelect);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddb_Archivo,
            this.tsddb_AdministradorDatos,
            this.tsl_Consultas,
            this.tsl_Buscar,
            this.tsl_AcercaDe});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(825, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "ts";
            // 
            // tsddb_Archivo
            // 
            this.tsddb_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Archivo_Cerrar});
            this.tsddb_Archivo.Image = global::Music_Manager.Properties.Resources.Clipboard;
            this.tsddb_Archivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddb_Archivo.Name = "tsddb_Archivo";
            this.tsddb_Archivo.Size = new System.Drawing.Size(72, 22);
            this.tsddb_Archivo.Text = "Archivo";
            // 
            // tsmi_Archivo_Cerrar
            // 
            this.tsmi_Archivo_Cerrar.Image = global::Music_Manager.Properties.Resources.Exit;
            this.tsmi_Archivo_Cerrar.Name = "tsmi_Archivo_Cerrar";
            this.tsmi_Archivo_Cerrar.Size = new System.Drawing.Size(105, 22);
            this.tsmi_Archivo_Cerrar.Text = "Salir";
            this.tsmi_Archivo_Cerrar.Click += new System.EventHandler(this.tsmi_Archivo_Cerrar_Click);
            // 
            // tsddb_AdministradorDatos
            // 
            this.tsddb_AdministradorDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AdministradorDatos_Conectar,
            this.tsmi_AdministradorDatos_Desconectar});
            this.tsddb_AdministradorDatos.Image = global::Music_Manager.Properties.Resources.Database;
            this.tsddb_AdministradorDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddb_AdministradorDatos.Name = "tsddb_AdministradorDatos";
            this.tsddb_AdministradorDatos.Size = new System.Drawing.Size(148, 22);
            this.tsddb_AdministradorDatos.Text = "Administrador de Datos";
            // 
            // tsmi_AdministradorDatos_Conectar
            // 
            this.tsmi_AdministradorDatos_Conectar.Image = global::Music_Manager.Properties.Resources.NewDatabase;
            this.tsmi_AdministradorDatos_Conectar.Name = "tsmi_AdministradorDatos_Conectar";
            this.tsmi_AdministradorDatos_Conectar.Size = new System.Drawing.Size(221, 22);
            this.tsmi_AdministradorDatos_Conectar.Text = "Conectar con Base de Datos";
            this.tsmi_AdministradorDatos_Conectar.Click += new System.EventHandler(this.tsmi_AdministradorDatos_Conectar_Click);
            // 
            // tsmi_AdministradorDatos_Desconectar
            // 
            this.tsmi_AdministradorDatos_Desconectar.Image = global::Music_Manager.Properties.Resources.DeleteDatabase;
            this.tsmi_AdministradorDatos_Desconectar.Name = "tsmi_AdministradorDatos_Desconectar";
            this.tsmi_AdministradorDatos_Desconectar.Size = new System.Drawing.Size(221, 22);
            this.tsmi_AdministradorDatos_Desconectar.Text = "Desconectar";
            this.tsmi_AdministradorDatos_Desconectar.Click += new System.EventHandler(this.tsmi_AdministradorDatos_Desconectar_Click);
            // 
            // tsl_Consultas
            // 
            this.tsl_Consultas.Image = global::Music_Manager.Properties.Resources.Edit;
            this.tsl_Consultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_Consultas.Name = "tsl_Consultas";
            this.tsl_Consultas.Size = new System.Drawing.Size(74, 22);
            this.tsl_Consultas.Text = "Consultas";
            this.tsl_Consultas.Click += new System.EventHandler(this.tsl_Consultas_Click);
            // 
            // tsl_Buscar
            // 
            this.tsl_Buscar.Image = global::Music_Manager.Properties.Resources.Search;
            this.tsl_Buscar.Name = "tsl_Buscar";
            this.tsl_Buscar.Size = new System.Drawing.Size(55, 22);
            this.tsl_Buscar.Text = "Buscar";
            // 
            // tsl_AcercaDe
            // 
            this.tsl_AcercaDe.Image = global::Music_Manager.Properties.Resources.HelpAndSupport;
            this.tsl_AcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_AcercaDe.Name = "tsl_AcercaDe";
            this.tsl_AcercaDe.Size = new System.Drawing.Size(75, 22);
            this.tsl_AcercaDe.Text = "Acerca de";
            this.tsl_AcercaDe.Click += new System.EventHandler(this.tsl_AcercaDe_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConexion});
            this.StatusStrip.Location = new System.Drawing.Point(0, 577);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(825, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // tsslConexion
            // 
            this.tsslConexion.Image = global::Music_Manager.Properties.Resources.DeleteDatabase;
            this.tsslConexion.Name = "tsslConexion";
            this.tsslConexion.Size = new System.Drawing.Size(91, 17);
            this.tsslConexion.Text = "Desconectado";
            // 
            // tab_Info
            // 
            this.tab_Info.Controls.Add(this.btn_Cancelar);
            this.tab_Info.Controls.Add(this.btn_Eliminar);
            this.tab_Info.Controls.Add(this.btn_Agregar);
            this.tab_Info.Controls.Add(this.btn_Grabar);
            this.tab_Info.Controls.Add(this.btn_Editar);
            this.tab_Info.Controls.Add(this.gbx_Album);
            this.tab_Info.Controls.Add(this.gbx_Grupo);
            this.tab_Info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab_Info.Location = new System.Drawing.Point(4, 22);
            this.tab_Info.Name = "tab_Info";
            this.tab_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Info.Size = new System.Drawing.Size(610, 520);
            this.tab_Info.TabIndex = 0;
            this.tab_Info.Text = "Informacion";
            this.tab_Info.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(448, 489);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(205, 489);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 15;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(286, 489);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 14;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(529, 489);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 13;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(367, 489);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // gbx_Album
            // 
            this.gbx_Album.Controls.Add(this.label5);
            this.gbx_Album.Controls.Add(this.cbx_IdCompania);
            this.gbx_Album.Controls.Add(this.label6);
            this.gbx_Album.Controls.Add(this.cbx_IdDisqueria);
            this.gbx_Album.Controls.Add(this.tbx_IdAlbum);
            this.gbx_Album.Controls.Add(this.lbl_IdCompania);
            this.gbx_Album.Controls.Add(this.lbl_IdDisqueria);
            this.gbx_Album.Controls.Add(this.lbl_Costo);
            this.gbx_Album.Controls.Add(this.tbx_Costo);
            this.gbx_Album.Controls.Add(this.cbx_Titulo);
            this.gbx_Album.Controls.Add(this.lbl_Observaciones);
            this.gbx_Album.Controls.Add(this.lbl_DuracionAlbum);
            this.gbx_Album.Controls.Add(this.lbl_CantidadTemas);
            this.gbx_Album.Controls.Add(this.lbl_FechaLanzamiento);
            this.gbx_Album.Controls.Add(this.lbl_FechaTerminado);
            this.gbx_Album.Controls.Add(this.rtbx_Observaciones);
            this.gbx_Album.Controls.Add(this.tbx_Duracion);
            this.gbx_Album.Controls.Add(this.tbx_CantidadTemas);
            this.gbx_Album.Controls.Add(this.dtp_FechaLanzamiento);
            this.gbx_Album.Controls.Add(this.dtp_FechaTerminado);
            this.gbx_Album.Controls.Add(this.lbl_Genero);
            this.gbx_Album.Controls.Add(this.lbl_Titulo);
            this.gbx_Album.Controls.Add(this.cbx_Genero);
            this.gbx_Album.Location = new System.Drawing.Point(6, 114);
            this.gbx_Album.Name = "gbx_Album";
            this.gbx_Album.Size = new System.Drawing.Size(598, 369);
            this.gbx_Album.TabIndex = 11;
            this.gbx_Album.TabStop = false;
            this.gbx_Album.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            // 
            // cbx_IdCompania
            // 
            this.cbx_IdCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_IdCompania.FormattingEnabled = true;
            this.cbx_IdCompania.Location = new System.Drawing.Point(129, 125);
            this.cbx_IdCompania.Name = "cbx_IdCompania";
            this.cbx_IdCompania.Size = new System.Drawing.Size(174, 21);
            this.cbx_IdCompania.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Id Album";
            // 
            // cbx_IdDisqueria
            // 
            this.cbx_IdDisqueria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_IdDisqueria.FormattingEnabled = true;
            this.cbx_IdDisqueria.Location = new System.Drawing.Point(129, 98);
            this.cbx_IdDisqueria.Name = "cbx_IdDisqueria";
            this.cbx_IdDisqueria.Size = new System.Drawing.Size(174, 21);
            this.cbx_IdDisqueria.TabIndex = 19;
            // 
            // tbx_IdAlbum
            // 
            this.tbx_IdAlbum.Location = new System.Drawing.Point(129, 19);
            this.tbx_IdAlbum.Name = "tbx_IdAlbum";
            this.tbx_IdAlbum.Size = new System.Drawing.Size(100, 20);
            this.tbx_IdAlbum.TabIndex = 20;
            // 
            // lbl_IdCompania
            // 
            this.lbl_IdCompania.AutoSize = true;
            this.lbl_IdCompania.Location = new System.Drawing.Point(69, 128);
            this.lbl_IdCompania.Name = "lbl_IdCompania";
            this.lbl_IdCompania.Size = new System.Drawing.Size(54, 13);
            this.lbl_IdCompania.TabIndex = 18;
            this.lbl_IdCompania.Text = "Compañia";
            // 
            // lbl_IdDisqueria
            // 
            this.lbl_IdDisqueria.AutoSize = true;
            this.lbl_IdDisqueria.Location = new System.Drawing.Point(72, 101);
            this.lbl_IdDisqueria.Name = "lbl_IdDisqueria";
            this.lbl_IdDisqueria.Size = new System.Drawing.Size(51, 13);
            this.lbl_IdDisqueria.TabIndex = 17;
            this.lbl_IdDisqueria.Text = "Disqueria";
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Location = new System.Drawing.Point(89, 259);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Costo.TabIndex = 16;
            this.lbl_Costo.Text = "Costo";
            // 
            // tbx_Costo
            // 
            this.tbx_Costo.Location = new System.Drawing.Point(129, 256);
            this.tbx_Costo.Name = "tbx_Costo";
            this.tbx_Costo.Size = new System.Drawing.Size(100, 20);
            this.tbx_Costo.TabIndex = 15;
            // 
            // cbx_Titulo
            // 
            this.cbx_Titulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Titulo.FormattingEnabled = true;
            this.cbx_Titulo.Location = new System.Drawing.Point(129, 45);
            this.cbx_Titulo.Name = "cbx_Titulo";
            this.cbx_Titulo.Size = new System.Drawing.Size(358, 21);
            this.cbx_Titulo.TabIndex = 14;
            this.cbx_Titulo.SelectedIndexChanged += new System.EventHandler(this.cbx_Titulo_SelectedIndexChanged);
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.AutoSize = true;
            this.lbl_Observaciones.Location = new System.Drawing.Point(45, 285);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.lbl_Observaciones.TabIndex = 13;
            this.lbl_Observaciones.Text = "Observaciones";
            // 
            // lbl_DuracionAlbum
            // 
            this.lbl_DuracionAlbum.AutoSize = true;
            this.lbl_DuracionAlbum.Location = new System.Drawing.Point(41, 233);
            this.lbl_DuracionAlbum.Name = "lbl_DuracionAlbum";
            this.lbl_DuracionAlbum.Size = new System.Drawing.Size(82, 13);
            this.lbl_DuracionAlbum.TabIndex = 12;
            this.lbl_DuracionAlbum.Text = "Duración Album";
            // 
            // lbl_CantidadTemas
            // 
            this.lbl_CantidadTemas.AutoSize = true;
            this.lbl_CantidadTemas.Location = new System.Drawing.Point(39, 207);
            this.lbl_CantidadTemas.Name = "lbl_CantidadTemas";
            this.lbl_CantidadTemas.Size = new System.Drawing.Size(84, 13);
            this.lbl_CantidadTemas.TabIndex = 11;
            this.lbl_CantidadTemas.Text = "Cantidad Temas";
            // 
            // lbl_FechaLanzamiento
            // 
            this.lbl_FechaLanzamiento.AutoSize = true;
            this.lbl_FechaLanzamiento.Location = new System.Drawing.Point(23, 182);
            this.lbl_FechaLanzamiento.Name = "lbl_FechaLanzamiento";
            this.lbl_FechaLanzamiento.Size = new System.Drawing.Size(100, 13);
            this.lbl_FechaLanzamiento.TabIndex = 10;
            this.lbl_FechaLanzamiento.Text = "Fecha Lanzamiento";
            // 
            // lbl_FechaTerminado
            // 
            this.lbl_FechaTerminado.AutoSize = true;
            this.lbl_FechaTerminado.Location = new System.Drawing.Point(33, 156);
            this.lbl_FechaTerminado.Name = "lbl_FechaTerminado";
            this.lbl_FechaTerminado.Size = new System.Drawing.Size(90, 13);
            this.lbl_FechaTerminado.TabIndex = 9;
            this.lbl_FechaTerminado.Text = "Fecha Terminado";
            // 
            // rtbx_Observaciones
            // 
            this.rtbx_Observaciones.Location = new System.Drawing.Point(129, 282);
            this.rtbx_Observaciones.Name = "rtbx_Observaciones";
            this.rtbx_Observaciones.Size = new System.Drawing.Size(358, 81);
            this.rtbx_Observaciones.TabIndex = 8;
            this.rtbx_Observaciones.Text = "";
            // 
            // tbx_Duracion
            // 
            this.tbx_Duracion.Location = new System.Drawing.Point(129, 230);
            this.tbx_Duracion.Name = "tbx_Duracion";
            this.tbx_Duracion.Size = new System.Drawing.Size(100, 20);
            this.tbx_Duracion.TabIndex = 7;
            // 
            // tbx_CantidadTemas
            // 
            this.tbx_CantidadTemas.Location = new System.Drawing.Point(129, 204);
            this.tbx_CantidadTemas.Name = "tbx_CantidadTemas";
            this.tbx_CantidadTemas.Size = new System.Drawing.Size(100, 20);
            this.tbx_CantidadTemas.TabIndex = 6;
            // 
            // dtp_FechaLanzamiento
            // 
            this.dtp_FechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaLanzamiento.Location = new System.Drawing.Point(129, 178);
            this.dtp_FechaLanzamiento.Name = "dtp_FechaLanzamiento";
            this.dtp_FechaLanzamiento.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaLanzamiento.TabIndex = 5;
            // 
            // dtp_FechaTerminado
            // 
            this.dtp_FechaTerminado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaTerminado.Location = new System.Drawing.Point(129, 152);
            this.dtp_FechaTerminado.Name = "dtp_FechaTerminado";
            this.dtp_FechaTerminado.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaTerminado.TabIndex = 4;
            this.dtp_FechaTerminado.Value = new System.DateTime(2009, 11, 8, 0, 0, 0, 0);
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(81, 74);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_Genero.TabIndex = 3;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(90, 48);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // cbx_Genero
            // 
            this.cbx_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Genero.FormattingEnabled = true;
            this.cbx_Genero.Location = new System.Drawing.Point(129, 71);
            this.cbx_Genero.Name = "cbx_Genero";
            this.cbx_Genero.Size = new System.Drawing.Size(174, 21);
            this.cbx_Genero.TabIndex = 1;
            // 
            // gbx_Grupo
            // 
            this.gbx_Grupo.Controls.Add(this.cbx_GrupoNombre);
            this.gbx_Grupo.Controls.Add(this.lbl_PosicionArreglo);
            this.gbx_Grupo.Controls.Add(this.lbl_IdGrupo);
            this.gbx_Grupo.Controls.Add(this.tbx_IdGrupo);
            this.gbx_Grupo.Controls.Add(this.lbl_CantidadIntegrantes);
            this.gbx_Grupo.Controls.Add(this.tbx_CantidadIntegrantes);
            this.gbx_Grupo.Controls.Add(this.lbl_Grupo_Nombre);
            this.gbx_Grupo.Location = new System.Drawing.Point(6, 6);
            this.gbx_Grupo.Name = "gbx_Grupo";
            this.gbx_Grupo.Size = new System.Drawing.Size(598, 102);
            this.gbx_Grupo.TabIndex = 10;
            this.gbx_Grupo.TabStop = false;
            this.gbx_Grupo.Text = "Conjunto / Solista";
            // 
            // cbx_GrupoNombre
            // 
            this.cbx_GrupoNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GrupoNombre.FormattingEnabled = true;
            this.cbx_GrupoNombre.Location = new System.Drawing.Point(129, 45);
            this.cbx_GrupoNombre.Name = "cbx_GrupoNombre";
            this.cbx_GrupoNombre.Size = new System.Drawing.Size(211, 21);
            this.cbx_GrupoNombre.TabIndex = 20;
            // 
            // lbl_PosicionArreglo
            // 
            this.lbl_PosicionArreglo.AutoSize = true;
            this.lbl_PosicionArreglo.Location = new System.Drawing.Point(235, 22);
            this.lbl_PosicionArreglo.Name = "lbl_PosicionArreglo";
            this.lbl_PosicionArreglo.Size = new System.Drawing.Size(0, 13);
            this.lbl_PosicionArreglo.TabIndex = 19;
            // 
            // lbl_IdGrupo
            // 
            this.lbl_IdGrupo.AutoSize = true;
            this.lbl_IdGrupo.Location = new System.Drawing.Point(75, 22);
            this.lbl_IdGrupo.Name = "lbl_IdGrupo";
            this.lbl_IdGrupo.Size = new System.Drawing.Size(48, 13);
            this.lbl_IdGrupo.TabIndex = 18;
            this.lbl_IdGrupo.Text = "Id Grupo";
            // 
            // tbx_IdGrupo
            // 
            this.tbx_IdGrupo.Location = new System.Drawing.Point(129, 19);
            this.tbx_IdGrupo.Name = "tbx_IdGrupo";
            this.tbx_IdGrupo.Size = new System.Drawing.Size(100, 20);
            this.tbx_IdGrupo.TabIndex = 17;
            // 
            // lbl_CantidadIntegrantes
            // 
            this.lbl_CantidadIntegrantes.AutoSize = true;
            this.lbl_CantidadIntegrantes.Location = new System.Drawing.Point(18, 74);
            this.lbl_CantidadIntegrantes.Name = "lbl_CantidadIntegrantes";
            this.lbl_CantidadIntegrantes.Size = new System.Drawing.Size(105, 13);
            this.lbl_CantidadIntegrantes.TabIndex = 11;
            this.lbl_CantidadIntegrantes.Text = "Cantidad Integrantes";
            // 
            // tbx_CantidadIntegrantes
            // 
            this.tbx_CantidadIntegrantes.Location = new System.Drawing.Point(129, 71);
            this.tbx_CantidadIntegrantes.Name = "tbx_CantidadIntegrantes";
            this.tbx_CantidadIntegrantes.Size = new System.Drawing.Size(211, 20);
            this.tbx_CantidadIntegrantes.TabIndex = 10;
            // 
            // lbl_Grupo_Nombre
            // 
            this.lbl_Grupo_Nombre.AutoSize = true;
            this.lbl_Grupo_Nombre.Location = new System.Drawing.Point(79, 48);
            this.lbl_Grupo_Nombre.Name = "lbl_Grupo_Nombre";
            this.lbl_Grupo_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Grupo_Nombre.TabIndex = 0;
            this.lbl_Grupo_Nombre.Text = "Nombre";
            // 
            // tabc_Principal
            // 
            this.tabc_Principal.Controls.Add(this.tab_Info);
            this.tabc_Principal.Controls.Add(this.tab_Consultas);
            this.tabc_Principal.HotTrack = true;
            this.tabc_Principal.Location = new System.Drawing.Point(205, 24);
            this.tabc_Principal.Name = "tabc_Principal";
            this.tabc_Principal.SelectedIndex = 0;
            this.tabc_Principal.Size = new System.Drawing.Size(618, 546);
            this.tabc_Principal.TabIndex = 2;
            this.tabc_Principal.SelectedIndexChanged += new System.EventHandler(this.tabc_Principal_SelectedIndexChanged);
            // 
            // tab_Consultas
            // 
            this.tab_Consultas.Controls.Add(this.gbx_Consultas);
            this.tab_Consultas.Location = new System.Drawing.Point(4, 22);
            this.tab_Consultas.Name = "tab_Consultas";
            this.tab_Consultas.Size = new System.Drawing.Size(610, 520);
            this.tab_Consultas.TabIndex = 3;
            this.tab_Consultas.Text = "Consultas";
            this.tab_Consultas.UseVisualStyleBackColor = true;
            // 
            // gbx_Consultas
            // 
            this.gbx_Consultas.Controls.Add(this.pbx_Consultas);
            this.gbx_Consultas.Controls.Add(this.tabc_Consultas);
            this.gbx_Consultas.Controls.Add(this.dgv_Consultas);
            this.gbx_Consultas.Controls.Add(this.tbx_Resultado);
            this.gbx_Consultas.Controls.Add(this.btn_Ejecutar);
            this.gbx_Consultas.Controls.Add(this.lbl_SeleccionConsulta);
            this.gbx_Consultas.Controls.Add(this.cbx_SeleccionConsulta);
            this.gbx_Consultas.Location = new System.Drawing.Point(6, 6);
            this.gbx_Consultas.Name = "gbx_Consultas";
            this.gbx_Consultas.Size = new System.Drawing.Size(598, 508);
            this.gbx_Consultas.TabIndex = 0;
            this.gbx_Consultas.TabStop = false;
            this.gbx_Consultas.Text = "Consultas";
            // 
            // pbx_Consultas
            // 
            this.pbx_Consultas.Location = new System.Drawing.Point(565, 17);
            this.pbx_Consultas.Name = "pbx_Consultas";
            this.pbx_Consultas.Size = new System.Drawing.Size(27, 23);
            this.pbx_Consultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Consultas.TabIndex = 18;
            this.pbx_Consultas.TabStop = false;
            // 
            // tabc_Consultas
            // 
            this.tabc_Consultas.Controls.Add(this.tab_Consulta01);
            this.tabc_Consultas.Controls.Add(this.tab_Consulta02);
            this.tabc_Consultas.Controls.Add(this.tab_Consulta03);
            this.tabc_Consultas.Controls.Add(this.tab_Consulta04);
            this.tabc_Consultas.Controls.Add(this.tab_Generos);
            this.tabc_Consultas.Location = new System.Drawing.Point(6, 46);
            this.tabc_Consultas.Name = "tabc_Consultas";
            this.tabc_Consultas.SelectedIndex = 0;
            this.tabc_Consultas.Size = new System.Drawing.Size(586, 102);
            this.tabc_Consultas.TabIndex = 17;
            this.tabc_Consultas.SelectedIndexChanged += new System.EventHandler(this.tabc_Consultas_SelectedIndexChanged);
            // 
            // tab_Consulta01
            // 
            this.tab_Consulta01.Controls.Add(this.tbx_Consulta_NombreGrupo);
            this.tab_Consulta01.Controls.Add(this.lbl_Consulta_NombreGrupo);
            this.tab_Consulta01.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta01.Name = "tab_Consulta01";
            this.tab_Consulta01.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Consulta01.Size = new System.Drawing.Size(578, 76);
            this.tab_Consulta01.TabIndex = 0;
            this.tab_Consulta01.Text = "Consulta01";
            this.tab_Consulta01.UseVisualStyleBackColor = true;
            // 
            // tbx_Consulta_NombreGrupo
            // 
            this.tbx_Consulta_NombreGrupo.Location = new System.Drawing.Point(120, 18);
            this.tbx_Consulta_NombreGrupo.Name = "tbx_Consulta_NombreGrupo";
            this.tbx_Consulta_NombreGrupo.Size = new System.Drawing.Size(219, 20);
            this.tbx_Consulta_NombreGrupo.TabIndex = 4;
            this.tbx_Consulta_NombreGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Consulta_NombreGrupo_Validating);
            // 
            // lbl_Consulta_NombreGrupo
            // 
            this.lbl_Consulta_NombreGrupo.AutoSize = true;
            this.lbl_Consulta_NombreGrupo.Location = new System.Drawing.Point(38, 21);
            this.lbl_Consulta_NombreGrupo.Name = "lbl_Consulta_NombreGrupo";
            this.lbl_Consulta_NombreGrupo.Size = new System.Drawing.Size(76, 13);
            this.lbl_Consulta_NombreGrupo.TabIndex = 3;
            this.lbl_Consulta_NombreGrupo.Text = "Nombre Grupo";
            // 
            // tab_Consulta02
            // 
            this.tab_Consulta02.Controls.Add(this.tbx_Consulta_Genero);
            this.tab_Consulta02.Controls.Add(this.lbl_Consulta_Genero);
            this.tab_Consulta02.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta02.Name = "tab_Consulta02";
            this.tab_Consulta02.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Consulta02.Size = new System.Drawing.Size(578, 76);
            this.tab_Consulta02.TabIndex = 1;
            this.tab_Consulta02.Text = "Consulta02";
            this.tab_Consulta02.UseVisualStyleBackColor = true;
            // 
            // tbx_Consulta_Genero
            // 
            this.tbx_Consulta_Genero.Location = new System.Drawing.Point(120, 18);
            this.tbx_Consulta_Genero.Name = "tbx_Consulta_Genero";
            this.tbx_Consulta_Genero.Size = new System.Drawing.Size(219, 20);
            this.tbx_Consulta_Genero.TabIndex = 6;
            this.tbx_Consulta_Genero.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Consulta_Genero_Validating);
            // 
            // lbl_Consulta_Genero
            // 
            this.lbl_Consulta_Genero.AutoSize = true;
            this.lbl_Consulta_Genero.Location = new System.Drawing.Point(72, 21);
            this.lbl_Consulta_Genero.Name = "lbl_Consulta_Genero";
            this.lbl_Consulta_Genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_Consulta_Genero.TabIndex = 5;
            this.lbl_Consulta_Genero.Text = "Genero";
            // 
            // tab_Consulta03
            // 
            this.tab_Consulta03.Controls.Add(this.tbx_Consulta_Anio);
            this.tab_Consulta03.Controls.Add(this.lbl_Consulta_Anio);
            this.tab_Consulta03.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta03.Name = "tab_Consulta03";
            this.tab_Consulta03.Size = new System.Drawing.Size(578, 76);
            this.tab_Consulta03.TabIndex = 2;
            this.tab_Consulta03.Text = "Consulta03";
            this.tab_Consulta03.UseVisualStyleBackColor = true;
            // 
            // tbx_Consulta_Anio
            // 
            this.tbx_Consulta_Anio.Location = new System.Drawing.Point(120, 18);
            this.tbx_Consulta_Anio.Name = "tbx_Consulta_Anio";
            this.tbx_Consulta_Anio.Size = new System.Drawing.Size(219, 20);
            this.tbx_Consulta_Anio.TabIndex = 8;
            this.tbx_Consulta_Anio.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Consulta_Anio_Validating);
            // 
            // lbl_Consulta_Anio
            // 
            this.lbl_Consulta_Anio.AutoSize = true;
            this.lbl_Consulta_Anio.Location = new System.Drawing.Point(88, 21);
            this.lbl_Consulta_Anio.Name = "lbl_Consulta_Anio";
            this.lbl_Consulta_Anio.Size = new System.Drawing.Size(26, 13);
            this.lbl_Consulta_Anio.TabIndex = 7;
            this.lbl_Consulta_Anio.Text = "Año";
            // 
            // tab_Consulta04
            // 
            this.tab_Consulta04.Controls.Add(this.cbx_Consulta_DuracionAlbum);
            this.tab_Consulta04.Controls.Add(this.lbl_Consulta_DuracionAlbum);
            this.tab_Consulta04.Controls.Add(this.tbx_Consulta_NombreGrupo2);
            this.tab_Consulta04.Controls.Add(this.lbl_Consulta_NombreGrupo2);
            this.tab_Consulta04.Controls.Add(this.lbl_Consulta_FechaHasta);
            this.tab_Consulta04.Controls.Add(this.dtp_Consulta_FechaDesde);
            this.tab_Consulta04.Controls.Add(this.dtp_Consulta_FechaHasta);
            this.tab_Consulta04.Controls.Add(this.lbl_Consulta_FechaDesde);
            this.tab_Consulta04.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta04.Name = "tab_Consulta04";
            this.tab_Consulta04.Size = new System.Drawing.Size(578, 76);
            this.tab_Consulta04.TabIndex = 3;
            this.tab_Consulta04.Text = "Consulta04";
            this.tab_Consulta04.UseVisualStyleBackColor = true;
            // 
            // cbx_Consulta_DuracionAlbum
            // 
            this.cbx_Consulta_DuracionAlbum.FormatString = "N0";
            this.cbx_Consulta_DuracionAlbum.FormattingEnabled = true;
            this.cbx_Consulta_DuracionAlbum.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120"});
            this.cbx_Consulta_DuracionAlbum.Location = new System.Drawing.Point(445, 17);
            this.cbx_Consulta_DuracionAlbum.Name = "cbx_Consulta_DuracionAlbum";
            this.cbx_Consulta_DuracionAlbum.Size = new System.Drawing.Size(100, 21);
            this.cbx_Consulta_DuracionAlbum.TabIndex = 19;
            this.cbx_Consulta_DuracionAlbum.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Consulta_DuracionAlbum_Validating);
            // 
            // lbl_Consulta_DuracionAlbum
            // 
            this.lbl_Consulta_DuracionAlbum.AutoSize = true;
            this.lbl_Consulta_DuracionAlbum.Location = new System.Drawing.Point(357, 20);
            this.lbl_Consulta_DuracionAlbum.Name = "lbl_Consulta_DuracionAlbum";
            this.lbl_Consulta_DuracionAlbum.Size = new System.Drawing.Size(82, 13);
            this.lbl_Consulta_DuracionAlbum.TabIndex = 18;
            this.lbl_Consulta_DuracionAlbum.Text = "Duración Album";
            // 
            // tbx_Consulta_NombreGrupo2
            // 
            this.tbx_Consulta_NombreGrupo2.Location = new System.Drawing.Point(104, 17);
            this.tbx_Consulta_NombreGrupo2.Name = "tbx_Consulta_NombreGrupo2";
            this.tbx_Consulta_NombreGrupo2.Size = new System.Drawing.Size(219, 20);
            this.tbx_Consulta_NombreGrupo2.TabIndex = 12;
            this.tbx_Consulta_NombreGrupo2.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Consulta_NombreGrupo2_Validating);
            // 
            // lbl_Consulta_NombreGrupo2
            // 
            this.lbl_Consulta_NombreGrupo2.AutoSize = true;
            this.lbl_Consulta_NombreGrupo2.Location = new System.Drawing.Point(22, 20);
            this.lbl_Consulta_NombreGrupo2.Name = "lbl_Consulta_NombreGrupo2";
            this.lbl_Consulta_NombreGrupo2.Size = new System.Drawing.Size(76, 13);
            this.lbl_Consulta_NombreGrupo2.TabIndex = 11;
            this.lbl_Consulta_NombreGrupo2.Text = "Nombre Grupo";
            // 
            // lbl_Consulta_FechaHasta
            // 
            this.lbl_Consulta_FechaHasta.AutoSize = true;
            this.lbl_Consulta_FechaHasta.Location = new System.Drawing.Point(198, 47);
            this.lbl_Consulta_FechaHasta.Name = "lbl_Consulta_FechaHasta";
            this.lbl_Consulta_FechaHasta.Size = new System.Drawing.Size(33, 13);
            this.lbl_Consulta_FechaHasta.TabIndex = 16;
            this.lbl_Consulta_FechaHasta.Text = "hasta";
            // 
            // dtp_Consulta_FechaDesde
            // 
            this.dtp_Consulta_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Consulta_FechaDesde.Location = new System.Drawing.Point(104, 43);
            this.dtp_Consulta_FechaDesde.Name = "dtp_Consulta_FechaDesde";
            this.dtp_Consulta_FechaDesde.Size = new System.Drawing.Size(86, 20);
            this.dtp_Consulta_FechaDesde.TabIndex = 14;
            // 
            // dtp_Consulta_FechaHasta
            // 
            this.dtp_Consulta_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Consulta_FechaHasta.Location = new System.Drawing.Point(237, 43);
            this.dtp_Consulta_FechaHasta.Name = "dtp_Consulta_FechaHasta";
            this.dtp_Consulta_FechaHasta.Size = new System.Drawing.Size(86, 20);
            this.dtp_Consulta_FechaHasta.TabIndex = 13;
            // 
            // lbl_Consulta_FechaDesde
            // 
            this.lbl_Consulta_FechaDesde.AutoSize = true;
            this.lbl_Consulta_FechaDesde.Location = new System.Drawing.Point(29, 47);
            this.lbl_Consulta_FechaDesde.Name = "lbl_Consulta_FechaDesde";
            this.lbl_Consulta_FechaDesde.Size = new System.Drawing.Size(69, 13);
            this.lbl_Consulta_FechaDesde.TabIndex = 15;
            this.lbl_Consulta_FechaDesde.Text = "Fecha desde";
            // 
            // tab_Generos
            // 
            this.tab_Generos.Controls.Add(this.cbx_Consulta_SeleccionABM);
            this.tab_Generos.Controls.Add(this.cbx_Consulta_GenerosDescripcion);
            this.tab_Generos.Location = new System.Drawing.Point(4, 22);
            this.tab_Generos.Name = "tab_Generos";
            this.tab_Generos.Size = new System.Drawing.Size(578, 76);
            this.tab_Generos.TabIndex = 4;
            this.tab_Generos.Text = "Generos";
            this.tab_Generos.UseVisualStyleBackColor = true;
            // 
            // cbx_Consulta_SeleccionABM
            // 
            this.cbx_Consulta_SeleccionABM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Consulta_SeleccionABM.FormattingEnabled = true;
            this.cbx_Consulta_SeleccionABM.Items.AddRange(new object[] {
            "Agregar",
            "Eliminar",
            "Modificar"});
            this.cbx_Consulta_SeleccionABM.Location = new System.Drawing.Point(120, 30);
            this.cbx_Consulta_SeleccionABM.Name = "cbx_Consulta_SeleccionABM";
            this.cbx_Consulta_SeleccionABM.Size = new System.Drawing.Size(121, 21);
            this.cbx_Consulta_SeleccionABM.TabIndex = 4;
            this.cbx_Consulta_SeleccionABM.SelectedIndexChanged += new System.EventHandler(this.cbx_Consulta_SeleccionABM_SelectedIndexChanged);
            // 
            // cbx_Consulta_GenerosDescripcion
            // 
            this.cbx_Consulta_GenerosDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbx_Consulta_GenerosDescripcion.FormattingEnabled = true;
            this.cbx_Consulta_GenerosDescripcion.Location = new System.Drawing.Point(353, 30);
            this.cbx_Consulta_GenerosDescripcion.Name = "cbx_Consulta_GenerosDescripcion";
            this.cbx_Consulta_GenerosDescripcion.Size = new System.Drawing.Size(174, 21);
            this.cbx_Consulta_GenerosDescripcion.TabIndex = 3;
            this.cbx_Consulta_GenerosDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbx_Consulta_GenerosDescripcion_SelectedIndexChanged);
            // 
            // dgv_Consultas
            // 
            this.dgv_Consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Consultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Consultas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consultas.Location = new System.Drawing.Point(6, 169);
            this.dgv_Consultas.Name = "dgv_Consultas";
            this.dgv_Consultas.ReadOnly = true;
            this.dgv_Consultas.Size = new System.Drawing.Size(586, 333);
            this.dgv_Consultas.TabIndex = 0;
            // 
            // tbx_Resultado
            // 
            this.tbx_Resultado.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbx_Resultado.ForeColor = System.Drawing.Color.Red;
            this.tbx_Resultado.Location = new System.Drawing.Point(6, 150);
            this.tbx_Resultado.Name = "tbx_Resultado";
            this.tbx_Resultado.Size = new System.Drawing.Size(586, 13);
            this.tbx_Resultado.TabIndex = 12;
            this.tbx_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(490, 17);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ejecutar.TabIndex = 11;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // lbl_SeleccionConsulta
            // 
            this.lbl_SeleccionConsulta.AutoSize = true;
            this.lbl_SeleccionConsulta.Location = new System.Drawing.Point(17, 22);
            this.lbl_SeleccionConsulta.Name = "lbl_SeleccionConsulta";
            this.lbl_SeleccionConsulta.Size = new System.Drawing.Size(107, 13);
            this.lbl_SeleccionConsulta.TabIndex = 2;
            this.lbl_SeleccionConsulta.Text = "Seleccionar Consulta";
            // 
            // cbx_SeleccionConsulta
            // 
            this.cbx_SeleccionConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SeleccionConsulta.FormattingEnabled = true;
            this.cbx_SeleccionConsulta.Items.AddRange(new object[] {
            "Ver las Disquerias y Companias con su respectivo Grupo",
            "Ver cantidad de temas por Autor y Album seleccionados por Genero",
            "Ver album\'s sacados por anio",
            "Calcular la antiguedad de los discos de un grupo",
            "ABM Generos"});
            this.cbx_SeleccionConsulta.Location = new System.Drawing.Point(130, 19);
            this.cbx_SeleccionConsulta.Name = "cbx_SeleccionConsulta";
            this.cbx_SeleccionConsulta.Size = new System.Drawing.Size(354, 21);
            this.cbx_SeleccionConsulta.TabIndex = 1;
            this.cbx_SeleccionConsulta.SelectedIndexChanged += new System.EventHandler(this.cbx_SeleccionConsulta_SelectedIndexChanged);
            // 
            // errorp_Consulta
            // 
            this.errorp_Consulta.ContainerControl = this;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 599);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.tv_Grupo);
            this.Controls.Add(this.tabc_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.tab_Info.ResumeLayout(false);
            this.gbx_Album.ResumeLayout(false);
            this.gbx_Album.PerformLayout();
            this.gbx_Grupo.ResumeLayout(false);
            this.gbx_Grupo.PerformLayout();
            this.tabc_Principal.ResumeLayout(false);
            this.tab_Consultas.ResumeLayout(false);
            this.gbx_Consultas.ResumeLayout(false);
            this.gbx_Consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbx_Consultas)).EndInit();
            this.tabc_Consultas.ResumeLayout(false);
            this.tab_Consulta01.ResumeLayout(false);
            this.tab_Consulta01.PerformLayout();
            this.tab_Consulta02.ResumeLayout(false);
            this.tab_Consulta02.PerformLayout();
            this.tab_Consulta03.ResumeLayout(false);
            this.tab_Consulta03.PerformLayout();
            this.tab_Consulta04.ResumeLayout(false);
            this.tab_Consulta04.PerformLayout();
            this.tab_Generos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgv_Consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorp_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripButton tsl_AcercaDe;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_AdministradorDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AdministradorDatos_Conectar;
        private System.Windows.Forms.ToolStripButton tsl_Consultas;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_Archivo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_Cerrar;
        private System.Windows.Forms.ToolStripLabel tsl_Buscar;
        private System.Windows.Forms.TabPage tab_Info;
        private System.Windows.Forms.GroupBox gbx_Grupo;
        private System.Windows.Forms.TextBox tbx_CantidadIntegrantes;
        private System.Windows.Forms.Label lbl_Grupo_Nombre;
        private System.Windows.Forms.TabControl tabc_Principal;
        private System.Windows.Forms.GroupBox gbx_Album;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cbx_Genero;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_FechaTerminado;
        private System.Windows.Forms.RichTextBox rtbx_Observaciones;
        private System.Windows.Forms.TextBox tbx_Duracion;
        private System.Windows.Forms.TextBox tbx_CantidadTemas;
        private System.Windows.Forms.DateTimePicker dtp_FechaLanzamiento;
        private System.Windows.Forms.DateTimePicker dtp_FechaTerminado;
        private System.Windows.Forms.Label lbl_FechaLanzamiento;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.Label lbl_DuracionAlbum;
        private System.Windows.Forms.Label lbl_CantidadTemas;
        private System.Windows.Forms.Label lbl_CantidadIntegrantes;
        private System.Windows.Forms.ComboBox cbx_Titulo;
        public System.Windows.Forms.TreeView tv_Grupo;
        public System.Windows.Forms.ToolStripStatusLabel tsslConexion;
        private System.Windows.Forms.Label lbl_Costo;
        private System.Windows.Forms.TextBox tbx_Costo;
        private System.Windows.Forms.TabPage tab_Consultas;
        private System.Windows.Forms.DataGridView dgv_Consultas;
        private System.Windows.Forms.GroupBox gbx_Consultas;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label lbl_SeleccionConsulta;
        private System.Windows.Forms.ComboBox cbx_SeleccionConsulta;
        private System.Windows.Forms.TextBox tbx_Consulta_NombreGrupo;
        private System.Windows.Forms.Label lbl_Consulta_NombreGrupo;
        private System.Windows.Forms.TextBox tbx_Resultado;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.TextBox tbx_IdGrupo;
        private System.Windows.Forms.Label lbl_IdGrupo;
        private System.Windows.Forms.Label lbl_PosicionArreglo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_IdCompania;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_IdDisqueria;
        private System.Windows.Forms.TextBox tbx_IdAlbum;
        private System.Windows.Forms.Label lbl_IdCompania;
        private System.Windows.Forms.Label lbl_IdDisqueria;
        private System.Windows.Forms.TextBox tbx_Consulta_Genero;
        private System.Windows.Forms.Label lbl_Consulta_Genero;
        private System.Windows.Forms.TextBox tbx_Consulta_Anio;
        private System.Windows.Forms.Label lbl_Consulta_Anio;
        private System.Windows.Forms.TextBox tbx_Consulta_NombreGrupo2;
        private System.Windows.Forms.Label lbl_Consulta_NombreGrupo2;
        private System.Windows.Forms.DateTimePicker dtp_Consulta_FechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_Consulta_FechaDesde;
        private System.Windows.Forms.Label lbl_Consulta_FechaDesde;
        private System.Windows.Forms.Label lbl_Consulta_FechaHasta;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AdministradorDatos_Desconectar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cbx_GrupoNombre;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TabControl tabc_Consultas;
        private System.Windows.Forms.TabPage tab_Consulta01;
        private System.Windows.Forms.TabPage tab_Consulta02;
        private System.Windows.Forms.TabPage tab_Consulta03;
        private System.Windows.Forms.TabPage tab_Consulta04;
        private System.Windows.Forms.TabPage tab_Generos;
        private System.Windows.Forms.Label lbl_Consulta_DuracionAlbum;
        private System.Windows.Forms.ComboBox cbx_Consulta_GenerosDescripcion;
        private System.Windows.Forms.PictureBox pbx_Consultas;
        private System.Windows.Forms.ComboBox cbx_Consulta_DuracionAlbum;
        private System.Windows.Forms.ErrorProvider errorp_Consulta;
        private System.Windows.Forms.ComboBox cbx_Consulta_SeleccionABM;
    }
}

