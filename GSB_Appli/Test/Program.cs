using Biblio_BD;
using Biblio_gsb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Medecin unMedecin = DBconnect.GetMedecin(1);
            Console.WriteLine("medecin = " + unMedecin.ToString());
            Console.ReadKey();

           List<Medecin> lesMedecins = DBconnect.GetMedecins();
            foreach (Medecin unmedecin in lesMedecins)
            {
                Console.WriteLine("liste = " + unmedecin.ToString());
            }
            Console.ReadKey();*/

            /*List<Specialite> lesSpecialite = DBconnect.GetSpecialites();
            foreach (Specialite uneSpecialite in lesSpecialite)
            {
                Console.WriteLine("liste = " + uneSpecialite.Libelle_specialite);
            }
            Console.ReadKey();*/

            List<Medicament> LesMedicaments = DBconnect.GetMedicaments();
            foreach (Medicament uneSpecialite in LesMedicaments)
            {
                Console.WriteLine(uneSpecialite.NomCommercial_medicament + " " + uneSpecialite.Famille.Libelle_famille);
            }
            Console.ReadKey();

        }
    }
}
