using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Music_Manager
{
    class Sql
    {
        private SqlConnection conexion;
        private SqlCommand command1;
        private SqlCommand command2;
        private SqlDataReader dataReader1;
        private SqlDataReader dataReader2;
        private string stringConexion, consulta;

        public SqlConnection Conexion
        {
            set { conexion = value; }
            get { return conexion; }
        }

        public SqlCommand Command1
        {
            set { command1 = value; }
            get { return command1; }
        }

        public SqlCommand Command2
        {
            set { command2 = value; }
            get { return command2; }
        }

        public SqlDataReader DataReader1
        {
            set { dataReader1 = value; }
            get { return dataReader1; }
        }

        public SqlDataReader DataReader2
        {
            set { dataReader2 = value; }
            get { return dataReader2; }
        }

        public string StringConexion
        {
            set { stringConexion = value; }
            get { return stringConexion; }
        }

        public string Consulta
        {
            set { consulta = value; }
            get { return consulta; }
        }

        public Sql()
        {
            Conexion = new SqlConnection();
            Command1 = new SqlCommand();
            Command2 = new SqlCommand();
            DataReader1 = null;
            DataReader2 = null;
            Consulta = null;
        }

        /* NAME: Conectar 
         * DESCRIPTION: conexion a una base de datos
         * PARAMETERS: int, string, servidor, usuario, contrasenia
         * RETURNS: true:conexion exitosa false:conexion fallida
         */
        public bool Conectar(int tipoAutenticacion, string db, string servidor, string usuario, string contrasenia)
        {
            switch (tipoAutenticacion)
            {
                case 0:
                    StringConexion = @"Data Source=.\" + servidor + ";"
                        + @"AttachDbFilename=C:\Archivos de programa\Microsoft SQL Server\MSSQL.1\MSSQL\Data\" + db + "_data" + ".mdf;"
                        + "Database=" + db + ";"
                        + "Trusted_Connection=Yes;"
                        + "MultipleActiveResultSets=True";
                    break;
                case 1:
                    StringConexion = @"Data Source=" + servidor + ";"
                        + "Initial Catalog=" + servidor + ";" 
                        + "User Id=" + usuario + ";"
                        + "Password=" + contrasenia + ";";
                    break;
            }

            try
            {
                Conexion.ConnectionString = StringConexion;
                Conexion.Open();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_SeleccionNombreConjunto_Solista
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS: none
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_SeleccionNombreGrupo ()
        {
            Command1.CommandText = "sp_SeleccionNombreGrupo";
            Command1.CommandType = CommandType.StoredProcedure;

            try 
            {
                Command1.Connection = Conexion;
                DataReader1 = Command1.ExecuteReader();
            } 
            catch (SqlException) 
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_SeleccionAlbumPorGrupo
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS: int
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_SeleccionAlbumPorGrupo (string nombreGrupo)
        {
            SqlParameter parametro = new SqlParameter("@nombreGrupo", SqlDbType.NVarChar);
            parametro.Value = nombreGrupo;

            Command2.CommandText = "sp_SeleccionAlbumPorGrupo";
            Command2.CommandType = CommandType.StoredProcedure;
            Command2.Parameters.Add(parametro);

            try
            {
                Command2.Connection = Conexion;
                DataReader2 = Command2.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        public bool sp_SeleccionAlbum(string nombreAlbum, string nombreGrupo)
        {
            return false;
        }
    }
}
