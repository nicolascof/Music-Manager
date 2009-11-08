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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tv_Grupo = new System.Windows.Forms.TreeView();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsddb_Archivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_Archivo_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddb_AdministradorDatos = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_AdministradorDatos_Conectar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_Consultas = new System.Windows.Forms.ToolStripButton();
            this.tsl_Buscar = new System.Windows.Forms.ToolStripLabel();
            this.tsl_AcercaDe = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab_Agregar = new System.Windows.Forms.TabPage();
            this.tab_Info = new System.Windows.Forms.TabPage();
            this.gbx_Album = new System.Windows.Forms.GroupBox();
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
            this.lbl_CantidadIntegrantes = new System.Windows.Forms.Label();
            this.tbx_CantidadIntegrantes = new System.Windows.Forms.TextBox();
            this.tbx_GrupoNombre = new System.Windows.Forms.TextBox();
            this.lbl_Grupo_Nombre = new System.Windows.Forms.Label();
            this.tc_Agregar = new System.Windows.Forms.TabControl();
            this.tbx_Costo = new System.Windows.Forms.TextBox();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.tab_Consultas = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbx_Consultas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.cbx_SeleccionConsulta = new System.Windows.Forms.ComboBox();
            this.lbl_SeleccionConsulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.tbx_Resultado = new System.Windows.Forms.TextBox();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.tab_Agregar.SuspendLayout();
            this.tab_Info.SuspendLayout();
            this.gbx_Album.SuspendLayout();
            this.gbx_Grupo.SuspendLayout();
            this.tc_Agregar.SuspendLayout();
            this.tab_Consultas.SuspendLayout();
            this.gbx_Consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tsmi_Archivo_Cerrar.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tsddb_AdministradorDatos
            // 
            this.tsddb_AdministradorDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AdministradorDatos_Conectar});
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
            this.tsmi_AdministradorDatos_Conectar.Click += new System.EventHandler(this.tsddbABD_Conectar_Click);
            // 
            // tsl_Consultas
            // 
            this.tsl_Consultas.Image = global::Music_Manager.Properties.Resources.Edit;
            this.tsl_Consultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_Consultas.Name = "tsl_Consultas";
            this.tsl_Consultas.Size = new System.Drawing.Size(74, 22);
            this.tsl_Consultas.Text = "Consultas";
            this.tsl_Consultas.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.tsl_AcercaDe.Click += new System.EventHandler(this.tsbAcercaDe_Click);
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
            // tab_Agregar
            // 
            this.tab_Agregar.Controls.Add(this.groupBox1);
            this.tab_Agregar.Location = new System.Drawing.Point(4, 22);
            this.tab_Agregar.Name = "tab_Agregar";
            this.tab_Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Agregar.Size = new System.Drawing.Size(610, 520);
            this.tab_Agregar.TabIndex = 2;
            this.tab_Agregar.Text = "Agregar";
            this.tab_Agregar.UseVisualStyleBackColor = true;
            // 
            // tab_Info
            // 
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
            // gbx_Album
            // 
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
            this.gbx_Album.Location = new System.Drawing.Point(6, 95);
            this.gbx_Album.Name = "gbx_Album";
            this.gbx_Album.Size = new System.Drawing.Size(598, 388);
            this.gbx_Album.TabIndex = 11;
            this.gbx_Album.TabStop = false;
            this.gbx_Album.Text = "Album";
            // 
            // cbx_Titulo
            // 
            this.cbx_Titulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Titulo.FormattingEnabled = true;
            this.cbx_Titulo.Location = new System.Drawing.Point(129, 19);
            this.cbx_Titulo.Name = "cbx_Titulo";
            this.cbx_Titulo.Size = new System.Drawing.Size(358, 21);
            this.cbx_Titulo.TabIndex = 14;
            this.cbx_Titulo.SelectedIndexChanged += new System.EventHandler(this.cbx_Titulo_SelectedIndexChanged);
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.AutoSize = true;
            this.lbl_Observaciones.Location = new System.Drawing.Point(45, 205);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.lbl_Observaciones.TabIndex = 13;
            this.lbl_Observaciones.Text = "Observaciones";
            // 
            // lbl_DuracionAlbum
            // 
            this.lbl_DuracionAlbum.AutoSize = true;
            this.lbl_DuracionAlbum.Location = new System.Drawing.Point(41, 153);
            this.lbl_DuracionAlbum.Name = "lbl_DuracionAlbum";
            this.lbl_DuracionAlbum.Size = new System.Drawing.Size(82, 13);
            this.lbl_DuracionAlbum.TabIndex = 12;
            this.lbl_DuracionAlbum.Text = "Duración Album";
            // 
            // lbl_CantidadTemas
            // 
            this.lbl_CantidadTemas.AutoSize = true;
            this.lbl_CantidadTemas.Location = new System.Drawing.Point(39, 127);
            this.lbl_CantidadTemas.Name = "lbl_CantidadTemas";
            this.lbl_CantidadTemas.Size = new System.Drawing.Size(84, 13);
            this.lbl_CantidadTemas.TabIndex = 11;
            this.lbl_CantidadTemas.Text = "Cantidad Temas";
            // 
            // lbl_FechaLanzamiento
            // 
            this.lbl_FechaLanzamiento.AutoSize = true;
            this.lbl_FechaLanzamiento.Location = new System.Drawing.Point(23, 102);
            this.lbl_FechaLanzamiento.Name = "lbl_FechaLanzamiento";
            this.lbl_FechaLanzamiento.Size = new System.Drawing.Size(100, 13);
            this.lbl_FechaLanzamiento.TabIndex = 10;
            this.lbl_FechaLanzamiento.Text = "Fecha Lanzamiento";
            // 
            // lbl_FechaTerminado
            // 
            this.lbl_FechaTerminado.AutoSize = true;
            this.lbl_FechaTerminado.Location = new System.Drawing.Point(33, 76);
            this.lbl_FechaTerminado.Name = "lbl_FechaTerminado";
            this.lbl_FechaTerminado.Size = new System.Drawing.Size(90, 13);
            this.lbl_FechaTerminado.TabIndex = 9;
            this.lbl_FechaTerminado.Text = "Fecha Terminado";
            // 
            // rtbx_Observaciones
            // 
            this.rtbx_Observaciones.Location = new System.Drawing.Point(129, 202);
            this.rtbx_Observaciones.Name = "rtbx_Observaciones";
            this.rtbx_Observaciones.Size = new System.Drawing.Size(358, 174);
            this.rtbx_Observaciones.TabIndex = 8;
            this.rtbx_Observaciones.Text = "";
            // 
            // tbx_Duracion
            // 
            this.tbx_Duracion.Location = new System.Drawing.Point(129, 150);
            this.tbx_Duracion.Name = "tbx_Duracion";
            this.tbx_Duracion.Size = new System.Drawing.Size(100, 20);
            this.tbx_Duracion.TabIndex = 7;
            // 
            // tbx_CantidadTemas
            // 
            this.tbx_CantidadTemas.Location = new System.Drawing.Point(129, 124);
            this.tbx_CantidadTemas.Name = "tbx_CantidadTemas";
            this.tbx_CantidadTemas.Size = new System.Drawing.Size(100, 20);
            this.tbx_CantidadTemas.TabIndex = 6;
            // 
            // dtp_FechaLanzamiento
            // 
            this.dtp_FechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaLanzamiento.Location = new System.Drawing.Point(129, 98);
            this.dtp_FechaLanzamiento.Name = "dtp_FechaLanzamiento";
            this.dtp_FechaLanzamiento.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaLanzamiento.TabIndex = 5;
            // 
            // dtp_FechaTerminado
            // 
            this.dtp_FechaTerminado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaTerminado.Location = new System.Drawing.Point(129, 72);
            this.dtp_FechaTerminado.Name = "dtp_FechaTerminado";
            this.dtp_FechaTerminado.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaTerminado.TabIndex = 4;
            this.dtp_FechaTerminado.Value = new System.DateTime(2009, 11, 8, 0, 0, 0, 0);
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(81, 48);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_Genero.TabIndex = 3;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(90, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // cbx_Genero
            // 
            this.cbx_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Genero.FormattingEnabled = true;
            this.cbx_Genero.Location = new System.Drawing.Point(129, 45);
            this.cbx_Genero.Name = "cbx_Genero";
            this.cbx_Genero.Size = new System.Drawing.Size(174, 21);
            this.cbx_Genero.TabIndex = 1;
            // 
            // gbx_Grupo
            // 
            this.gbx_Grupo.Controls.Add(this.lbl_CantidadIntegrantes);
            this.gbx_Grupo.Controls.Add(this.tbx_CantidadIntegrantes);
            this.gbx_Grupo.Controls.Add(this.tbx_GrupoNombre);
            this.gbx_Grupo.Controls.Add(this.lbl_Grupo_Nombre);
            this.gbx_Grupo.Location = new System.Drawing.Point(6, 6);
            this.gbx_Grupo.Name = "gbx_Grupo";
            this.gbx_Grupo.Size = new System.Drawing.Size(598, 83);
            this.gbx_Grupo.TabIndex = 10;
            this.gbx_Grupo.TabStop = false;
            this.gbx_Grupo.Text = "Conjunto / Solista";
            // 
            // lbl_CantidadIntegrantes
            // 
            this.lbl_CantidadIntegrantes.AutoSize = true;
            this.lbl_CantidadIntegrantes.Location = new System.Drawing.Point(19, 48);
            this.lbl_CantidadIntegrantes.Name = "lbl_CantidadIntegrantes";
            this.lbl_CantidadIntegrantes.Size = new System.Drawing.Size(105, 13);
            this.lbl_CantidadIntegrantes.TabIndex = 11;
            this.lbl_CantidadIntegrantes.Text = "Cantidad Integrantes";
            // 
            // tbx_CantidadIntegrantes
            // 
            this.tbx_CantidadIntegrantes.Location = new System.Drawing.Point(130, 45);
            this.tbx_CantidadIntegrantes.Name = "tbx_CantidadIntegrantes";
            this.tbx_CantidadIntegrantes.Size = new System.Drawing.Size(211, 20);
            this.tbx_CantidadIntegrantes.TabIndex = 10;
            // 
            // tbx_GrupoNombre
            // 
            this.tbx_GrupoNombre.Location = new System.Drawing.Point(130, 19);
            this.tbx_GrupoNombre.Name = "tbx_GrupoNombre";
            this.tbx_GrupoNombre.Size = new System.Drawing.Size(211, 20);
            this.tbx_GrupoNombre.TabIndex = 9;
            // 
            // lbl_Grupo_Nombre
            // 
            this.lbl_Grupo_Nombre.AutoSize = true;
            this.lbl_Grupo_Nombre.Location = new System.Drawing.Point(80, 22);
            this.lbl_Grupo_Nombre.Name = "lbl_Grupo_Nombre";
            this.lbl_Grupo_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Grupo_Nombre.TabIndex = 0;
            this.lbl_Grupo_Nombre.Text = "Nombre";
            // 
            // tc_Agregar
            // 
            this.tc_Agregar.Controls.Add(this.tab_Info);
            this.tc_Agregar.Controls.Add(this.tab_Agregar);
            this.tc_Agregar.Controls.Add(this.tab_Consultas);
            this.tc_Agregar.HotTrack = true;
            this.tc_Agregar.Location = new System.Drawing.Point(205, 24);
            this.tc_Agregar.Name = "tc_Agregar";
            this.tc_Agregar.SelectedIndex = 0;
            this.tc_Agregar.Size = new System.Drawing.Size(618, 546);
            this.tc_Agregar.TabIndex = 2;
            // 
            // tbx_Costo
            // 
            this.tbx_Costo.Location = new System.Drawing.Point(129, 176);
            this.tbx_Costo.Name = "tbx_Costo";
            this.tbx_Costo.Size = new System.Drawing.Size(100, 20);
            this.tbx_Costo.TabIndex = 15;
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Location = new System.Drawing.Point(89, 179);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Costo.TabIndex = 16;
            this.lbl_Costo.Text = "Costo";
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbx_Consultas
            // 
            this.gbx_Consultas.Controls.Add(this.tbx_Resultado);
            this.gbx_Consultas.Controls.Add(this.btn_Ejecutar);
            this.gbx_Consultas.Controls.Add(this.textBox2);
            this.gbx_Consultas.Controls.Add(this.label4);
            this.gbx_Consultas.Controls.Add(this.label3);
            this.gbx_Consultas.Controls.Add(this.label2);
            this.gbx_Consultas.Controls.Add(this.dateTimePicker2);
            this.gbx_Consultas.Controls.Add(this.dateTimePicker1);
            this.gbx_Consultas.Controls.Add(this.textBox1);
            this.gbx_Consultas.Controls.Add(this.label1);
            this.gbx_Consultas.Controls.Add(this.lbl_SeleccionConsulta);
            this.gbx_Consultas.Controls.Add(this.cbx_SeleccionConsulta);
            this.gbx_Consultas.Controls.Add(this.dataGridView1);
            this.gbx_Consultas.Location = new System.Drawing.Point(6, 6);
            this.gbx_Consultas.Name = "gbx_Consultas";
            this.gbx_Consultas.Size = new System.Drawing.Size(598, 508);
            this.gbx_Consultas.TabIndex = 0;
            this.gbx_Consultas.TabStop = false;
            this.gbx_Consultas.Text = "Consultas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(529, 489);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // cbx_SeleccionConsulta
            // 
            this.cbx_SeleccionConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SeleccionConsulta.FormattingEnabled = true;
            this.cbx_SeleccionConsulta.Items.AddRange(new object[] {
            "Ver las Disquerias y Companias con su respectivo Grupo",
            "Ver cantidad de temas por Autor y Album seleccionados por Genero",
            "Ver album\'s sacados por anio",
            "Calcular la antiguedad de los discos de un grupo"});
            this.cbx_SeleccionConsulta.Location = new System.Drawing.Point(130, 19);
            this.cbx_SeleccionConsulta.Name = "cbx_SeleccionConsulta";
            this.cbx_SeleccionConsulta.Size = new System.Drawing.Size(381, 21);
            this.cbx_SeleccionConsulta.TabIndex = 1;
            this.cbx_SeleccionConsulta.SelectedIndexChanged += new System.EventHandler(this.cbx_SeleccionConsulta_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(130, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(517, 17);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ejecutar.TabIndex = 11;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            // 
            // tbx_Resultado
            // 
            this.tbx_Resultado.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Resultado.ForeColor = System.Drawing.Color.Red;
            this.tbx_Resultado.Location = new System.Drawing.Point(6, 126);
            this.tbx_Resultado.Name = "tbx_Resultado";
            this.tbx_Resultado.Size = new System.Drawing.Size(586, 20);
            this.tbx_Resultado.TabIndex = 12;
            this.tbx_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 599);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.tv_Grupo);
            this.Controls.Add(this.tc_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.tab_Agregar.ResumeLayout(false);
            this.tab_Info.ResumeLayout(false);
            this.gbx_Album.ResumeLayout(false);
            this.gbx_Album.PerformLayout();
            this.gbx_Grupo.ResumeLayout(false);
            this.gbx_Grupo.PerformLayout();
            this.tc_Agregar.ResumeLayout(false);
            this.tab_Consultas.ResumeLayout(false);
            this.gbx_Consultas.ResumeLayout(false);
            this.gbx_Consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabPage tab_Agregar;
        private System.Windows.Forms.TabPage tab_Info;
        private System.Windows.Forms.GroupBox gbx_Grupo;
        private System.Windows.Forms.TextBox tbx_CantidadIntegrantes;
        private System.Windows.Forms.TextBox tbx_GrupoNombre;
        private System.Windows.Forms.Label lbl_Grupo_Nombre;
        private System.Windows.Forms.TabControl tc_Agregar;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbx_Consultas;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label lbl_SeleccionConsulta;
        private System.Windows.Forms.ComboBox cbx_SeleccionConsulta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbx_Resultado;
        private System.Windows.Forms.Button btn_Ejecutar;
    }
}

