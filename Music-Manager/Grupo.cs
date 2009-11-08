using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Manager
{
    class Grupo
    {
        private int idGrupo;
        private string descripcion;
        private int idCompania;
        private byte cantidadIntegrantes;
        private bool solistaConjunto;
        private Album[] oAlbum;

        public int IdGrupo
        {
            set { idGrupo = value; }
            get { return idGrupo; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public int IdCompania
        {
            set { idCompania = value; }
            get { return idCompania; }
        }

        public byte CantidadIntegrantes
        {
            set { cantidadIntegrantes = value; }
            get { return cantidadIntegrantes; }
        }

        public bool SolistaConjunto
        {
            set { solistaConjunto = value; }
            get { return solistaConjunto; }
        }

        public Album[] OAlbum
        {
            set { oAlbum = value; }
            get { return oAlbum; }
        }

        public Grupo(int CantidadAlbums)
        {
            this.IdGrupo = 0;
            this.Descripcion = null;
            this.IdCompania = 0;
            this.CantidadIntegrantes = 0;
            this.solistaConjunto = false;
            OAlbum = new Album[CantidadAlbums];
        }

        /*
        public Grupo(int IdGrupos, string Descripcion, int IdCompania, Int16 CantidadIntegrantes, bool SolistaConjunto)
        {
            this.IdGrupo = IdGrupos;
            this.Descripcion = Descripcion;
            this.IdCompania = IdCompania;
            this.CantidadIntegrantes = CantidadIntegrantes;
            this.SolistaConjunto = SolistaConjunto;
            oAlbum = new Album[10];
        }
        */
    }
}
