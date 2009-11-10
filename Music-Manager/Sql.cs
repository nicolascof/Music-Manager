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
                        + @"AttachDbFilename=C:\Archivos de programa\Microsoft SQL Server\MSSQL.1\MSSQL\Data\" 
                        + db + "_data" + ".mdf;"
                        + "Database=" + db + ";"
                        + "Trusted_Connection=Yes;MultipleActiveResultSets=True";
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
            try
            {
                Command1 = new SqlCommand();

                Command1.CommandText = "sp_SeleccionNombreGrupo";
                Command1.CommandType = CommandType.StoredProcedure;

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
         * PARAMETERS: string
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_SeleccionAlbumPorGrupo (string nombreGrupo)
        {
            try
            {
                Command2 = new SqlCommand();

                SqlParameter parametro = new SqlParameter("@nombreGrupo", SqlDbType.NVarChar);
                parametro.Value = nombreGrupo;

                Command2.CommandText = "sp_SeleccionAlbumPorGrupo";
                Command2.CommandType = CommandType.StoredProcedure;
                Command2.Parameters.Add(parametro);

                Command2.Connection = Conexion;
                DataReader2 = Command2.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_EliminacionAlbum
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS: int
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_EliminacionAlbum (int idAlbum)
        {
            try
            {
                Command1 = new SqlCommand();

                SqlParameter parametro = new SqlParameter("@idAlbum", SqlDbType.Int);
                parametro.Value = idAlbum;

                Command1.CommandText = "sp_EliminacionAlbum";
                Command1.CommandType = CommandType.StoredProcedure;
                Command1.Parameters.Add(parametro);

                Command1.Connection = Conexion;
                DataReader1 = Command1.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_AgregarAlbum
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS:
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_AgregarAlbum (int idGenero, int idDisqueria, int idCompania, int idGrupo, bool variosArtistas, 
            string titulo, decimal costo, DateTime fechaTerminado, DateTime fechaLanzamiento, int cantidadTemas, 
            int duracionAlbum, string observaciones)
        {
            try
            {
                Command1 = new SqlCommand();

                SqlParameter[] parametro = new SqlParameter[12];

                parametro[0] = new SqlParameter("@idGenero", SqlDbType.Int);
                parametro[0].Value = idGenero;

                parametro[1] = new SqlParameter("@idDisqueria", SqlDbType.Int);
                parametro[1].Value = idDisqueria;

                parametro[2] = new SqlParameter("@idCompania", SqlDbType.Int);
                parametro[2].Value = idCompania;

                parametro[3] = new SqlParameter("@idGrupo", SqlDbType.Int);
                parametro[3].Value = idGrupo;

                parametro[4] = new SqlParameter("@variosArtistas", SqlDbType.Bit);
                parametro[4].Value = variosArtistas;

                parametro[5] = new SqlParameter("@titulo", SqlDbType.NVarChar, 50);
                parametro[5].Value = titulo;

                parametro[6] = new SqlParameter("@costo", SqlDbType.Decimal);
                parametro[6].Value = costo;

                parametro[7] = new SqlParameter("@fechaTerminado", SqlDbType.DateTime);
                parametro[7].Value = fechaTerminado;

                parametro[8] = new SqlParameter("@fechaLanzamiento", SqlDbType.DateTime);
                parametro[8].Value = fechaLanzamiento;

                parametro[9] = new SqlParameter("@cantidadTemas", SqlDbType.Int);
                parametro[9].Value = cantidadTemas;

                parametro[10] = new SqlParameter("@duracionAlbum", SqlDbType.Int);
                parametro[10].Value = duracionAlbum;

                parametro[11] = new SqlParameter("@observaciones", SqlDbType.NVarChar, 80);
                parametro[11].Value = observaciones;

                Command1.CommandText = "sp_AgregarAlbum";
                Command1.CommandType = CommandType.StoredProcedure;
                Command1.Parameters.AddRange(parametro);

                Command1.Connection = Conexion;
                Command1.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_ModificarAlbum
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS: 
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_ModificarAlbum (int idAlbum, int idGenero, int idDisqueria, int idCompania, int idGrupo, 
            bool variosArtistas, string titulo, decimal costo, DateTime fechaTerminado, DateTime fechaLanzamiento, 
            int cantidadTemas, int duracionAlbum, string observaciones)
        {
            try
            {
                Command1 = new SqlCommand();

                SqlParameter[] parametro = new SqlParameter[13];

                parametro[0] = new SqlParameter("@idAlbum", SqlDbType.Int);
                parametro[0].Value = idAlbum;

                parametro[1] = new SqlParameter("@idGenero", SqlDbType.Int);
                parametro[1].Value = idGenero;

                parametro[2] = new SqlParameter("@idDisqueria", SqlDbType.Int);
                parametro[2].Value = idDisqueria;

                parametro[3] = new SqlParameter("@idCompania", SqlDbType.Int);
                parametro[3].Value = idCompania;

                parametro[4] = new SqlParameter("@idGrupo", SqlDbType.Int);
                parametro[4].Value = idGrupo;

                parametro[5] = new SqlParameter("@variosArtistas", SqlDbType.Bit);
                parametro[5].Value = variosArtistas;

                parametro[6] = new SqlParameter("@titulo", SqlDbType.NVarChar, 50);
                parametro[6].Value = titulo;

                parametro[7] = new SqlParameter("@costo", SqlDbType.Decimal);
                parametro[7].Value = costo;

                parametro[8] = new SqlParameter("@fechaTerminado", SqlDbType.DateTime);
                parametro[8].Value = fechaTerminado;

                parametro[9] = new SqlParameter("@fechaLanzamiento", SqlDbType.DateTime);
                parametro[9].Value = fechaLanzamiento;

                parametro[10] = new SqlParameter("@cantidadTemas", SqlDbType.Int);
                parametro[10].Value = cantidadTemas;

                parametro[11] = new SqlParameter("@duracionAlbum", SqlDbType.Int);
                parametro[11].Value = duracionAlbum;

                parametro[12] = new SqlParameter("@observaciones", SqlDbType.NVarChar, 80);
                parametro[12].Value = observaciones;

                Command1.CommandText = "sp_ModificarAlbum";
                Command1.CommandType = CommandType.StoredProcedure;
                Command1.Parameters.AddRange(parametro);

                Command1.Connection = Conexion;
                Command1.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        // Consultas de laboratorio
        public bool sp_Consulta01(string nombreGrupo)
        {
            try
            {
                Command2 = new SqlCommand();

                SqlParameter parametro = new SqlParameter("@nombreGrupo", SqlDbType.NVarChar, 25);
                parametro.Value = nombreGrupo;

                Command2.CommandText = "sp_Consulta01";
                Command2.CommandType = CommandType.StoredProcedure;
                Command2.Parameters.Add(parametro);

                Command2.Connection = Conexion;
                DataReader2 = Command2.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        public bool sp_Consulta02(string generoDescripcion)
        {
            try
            {
                Command2 = new SqlCommand();

                SqlParameter parametro = new SqlParameter("@generoDescripcion", SqlDbType.NVarChar, 25);
                parametro.Value = generoDescripcion;

                Command2.CommandText = "sp_Consulta02";
                Command2.CommandType = CommandType.StoredProcedure;
                Command2.Parameters.Add(parametro);

                Command2.Connection = Conexion;
                DataReader2 = Command2.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        public bool sp_Consulta03(int anio)
        {
            try
            {
                Command2 = new SqlCommand();

                SqlParameter parametro = new SqlParameter("@anio", SqlDbType.Int);
                parametro.Value = anio;

                Command2.CommandText = "sp_Consulta03";
                Command2.CommandType = CommandType.StoredProcedure;
                Command2.Parameters.Add(parametro);

                Command2.Connection = Conexion;
                DataReader2 = Command2.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        public bool sp_Consulta04(string nombreGrupo, DateTime fechaInicial, DateTime fechaFinal, int duracionAlbum)
        {
            try
            {
                Command2 = new SqlCommand();

                SqlParameter[] parametro = new SqlParameter[4];

                parametro[0] = new SqlParameter("@nombreGrupo", SqlDbType.NVarChar, 25);
                parametro[0].Value = nombreGrupo;

                parametro[1] = new SqlParameter("@fechaInicial", SqlDbType.DateTime);
                parametro[1].Value = fechaInicial;

                parametro[2] = new SqlParameter("@fechaFinal", SqlDbType.DateTime);
                parametro[2].Value = fechaFinal;

                parametro[3] = new SqlParameter("@duracionAlbum", SqlDbType.Int);
                parametro[3].Value = duracionAlbum;

                Command2.CommandText = "sp_Consulta04";
                Command2.CommandType = CommandType.StoredProcedure;
                Command2.Parameters.AddRange(parametro);

                Command2.Connection = Conexion;
                DataReader2 = Command2.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }
    }
}
