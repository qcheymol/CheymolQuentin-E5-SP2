using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Famille
    {
        private string libelle_famille;
        private int id_famille;

        public Famille()
        {

        }
        public Famille(int id_famille, string libelle_famille)
        {
            this.id_famille = id_famille;
            this.libelle_famille = libelle_famille;
        }

        public int Id_famille { get => id_famille; set => id_famille = value; }
        public string Libelle_famille { get => libelle_famille; set => libelle_famille = value; }
    
}
}
