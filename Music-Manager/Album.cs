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
        private bool varios_Artitas;
        private decimal costo;
        private string fecha_Terminado;
        private string fecha_Lanzamiento;
        private int cantidad_Temas;
        private int duracion_Album;
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

        public bool Varios_Artitas
        {
            set { varios_Artitas = value; }
            get { return varios_Artitas; }
        }

        public decimal Costo
        {
            set { costo = value; }
            get { return costo; }
        }

        public string Fecha_Terminado
        {
            set { fecha_Terminado = value; }
            get { return fecha_Terminado; }
        }

        public string Fecha_Lanzamiento
        {
            set { fecha_Lanzamiento = value; }
            get { return fecha_Lanzamiento; }
        }

        public int Cantidad_Temas
        {
            set { cantidad_Temas = value; }
            get { return cantidad_Temas; }
        }

        public int Duracion_Album
        {
            set { duracion_Album = value; }
            get { return duracion_Album; }
        }

        public string Obsevaciones
        {
            set { obsevaciones = value; }
            get { return obsevaciones; }
        }

        public Album()
        {
            this.idAlbum = 0;
            this.idGenero = 0;
            this.IdDisqueria = 0;
            this.IdCompania = 0;
            this.IdGrupo = 0;
            this.Varios_Artitas = false;
            this.Costo = 0;
            this.Fecha_Terminado = null;
            this.fecha_Lanzamiento = null;
            this.Cantidad_Temas = 0;
            this.Duracion_Album = 0;
            this.Obsevaciones = null;
        }

        public Album(int IdAlbum, int IdGenero, int IdDisqueria, int IdCompania, int IdGrupo, bool VariosArtistas, decimal Costo, string FechaTerminado, string FechaLanzamiento, int CantidadTemas, int DuracionAlbum, string Obsevaciones)
        {
            this.IdAlbum = IdAlbum;
            this.IdGenero = IdAlbum;
            this.IdDisqueria = IdDisqueria;
            this.IdCompania = IdDisqueria;
            this.IdGrupo = IdGrupo;
            this.Varios_Artitas = VariosArtistas;
            this.Costo = Costo;
            this.Fecha_Terminado = FechaTerminado;
            this.fecha_Lanzamiento = FechaLanzamiento;
            this.Cantidad_Temas = CantidadTemas;
            this.Duracion_Album = DuracionAlbum;
            this.Obsevaciones = Obsevaciones;
        }
    }
}