using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Manager
{
    class Album
    {
        private int idAlbum;
        private int idGenero;
        private int idDisqueria;
        private int idCompania;
        private int idgrupo;
        private bool variosArtitas;
        private string titulo;
        private decimal costo;
        private DateTime fechaTerminado;
        private DateTime fechaLanzamiento;
        private int cantidadTemas;
        private int duracionAlbum;
        private string obsevaciones;

        public int IdAlbum
        {
            set { idAlbum = value; }
            get { return idAlbum; }
        }

        public int IdGenero
        {
            set { idGenero = value; }
            get { return idGenero; }
        }

        public int IdDisqueria
        {
            set { idDisqueria = value; }
            get { return idDisqueria; }
        }

        public int IdCompania
        {
            set { idCompania = value; }
            get { return idCompania; }
        }

        public int IdGrupo
        {
            set { idgrupo = value; }
            get { return idgrupo; }
        }

        public bool VariosArtitas
        {
            set { variosArtitas = value; }
            get { return variosArtitas; }
        }

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }

        public decimal Costo
        {
            set { costo = value; }
            get { return costo; }
        }

        public DateTime FechaTerminado
        {
            set { fechaTerminado = value; }
            get { return fechaTerminado; }
        }

        public DateTime FechaLanzamiento
        {
            set { fechaLanzamiento = value; }
            get { return fechaLanzamiento; }
        }

        public int CantidadTemas
        {
            set { cantidadTemas = value; }
            get { return cantidadTemas; }
        }

        public int DuracionAlbum
        {
            set { duracionAlbum = value; }
            get { return duracionAlbum; }
        }

        public string Obsevaciones
        {
            set { obsevaciones = value; }
            get { return obsevaciones; }
        }

        public Album()
        {
            this.IdAlbum = 0;
            this.IdGenero = 0;
            this.IdDisqueria = 0;
            this.IdCompania = 0;
            this.IdGrupo = 0;
            this.VariosArtitas = false;
            this.Titulo = null;
            this.Costo = 0;
            this.FechaTerminado = new DateTime();
            this.FechaLanzamiento = new DateTime();
            this.CantidadTemas = 0;
            this.DuracionAlbum = 0;
            this.Obsevaciones = null;
        }

        public string MostrarGenero ()
        {
            string[] arregloGenero = { "Jazz", "Rock", "Pop", "Heavy Metal", "Dead Metal", "Grunge", "ElectroPop"};

            return arregloGenero[IdGenero-1];
        }

        public string MostrarDisqueria ()
        {
            string[] arregloDisqueria = { "Eden", "Musimundo" };

            return arregloDisqueria[IdDisqueria-1];
        }

        public string MostrarCompania ()
        {
            string[] arregloCompania = { "Sony BMG", "BGM", "Warner Music Group", "EMI", "Universal Music Group" };

            return arregloCompania[IdCompania-1];
        }

        /*
        public Album(int IdAlbum, int IdGenero, int IdDisqueria, int IdCompania, int IdGrupo, bool VariosArtistas, decimal Costo, string FechaTerminado, string FechaLanzamiento, int CantidadTemas, int DuracionAlbum, string Obsevaciones)
        {
            this.IdAlbum = IdAlbum;
            this.IdGenero = IdAlbum;
            this.IdDisqueria = IdDisqueria;
            this.IdCompania = IdDisqueria;
            this.IdGrupo = IdGrupo;
            this.VariosArtitas = VariosArtistas;
            this.Costo = Costo;
            this.FechaTerminado = FechaTerminado;
            this.fechaLanzamiento = FechaLanzamiento;
            this.CantidadTemas = CantidadTemas;
            this.DuracionAlbum = DuracionAlbum;
            this.Obsevaciones = Obsevaciones;
        }
        */
    }
}