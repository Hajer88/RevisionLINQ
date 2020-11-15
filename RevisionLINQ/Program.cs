using System;
using System.Collections.Generic;
using System.Linq;

namespace RevisionLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Etudiant> etudiants = new List<Etudiant>()
            {
                new Etudiant {Id=1, Nom="etudiant1", Age=18,Classe="classe1"},
                new Etudiant {Id=2, Nom="etudiant2", Age=22,Classe="classe 2"},
                new Etudiant {Id=3, Nom="etudiant3", Age=25, Classe="Classe 3"},
                new Etudiant {Id=4, Nom="etudiant4", Age=22, Classe="Classe 3"},
            };
            //Dot Notation Syntax
            var query1 = etudiants.Where(a => a.Age > 12 && a.Age < 20).ToList();
            // Ajout dans une liste avec Add etudiants.Add(new Etudiant { });
            //Etudiant avec Id=1
            var query2 = etudiants.Where(a => a.Id == 1).SingleOrDefault();
            var query3 = etudiants.Where(a => a.Age == 18 && a.Classe == "classe1");
            //Query With Group By Into
            var query4 = from e in etudiants
                         group e by e.Classe into c
                         select c;
            //Query Syntax
            var quert5 = from e in etudiants
                         orderby e.Age descending
                         select e;
            //Exercice 1
            string[] nomArtistes = new string[]
            {
                "Artiste1","Artiste2","Artiste3"
            };
            string[] nomMusique = new string[]
            {
                "Morc1","Morc2","Morc3"
            };
            List<Artiste> artistes = new List<Artiste>();
            List<Musique> musiques = new List<Musique>();
            //Remplir les listes d'artistes et de musiques à partir des tableaux de string
            //Notez qu'un artiste peut avoir plusieurs morceaux de musique
            foreach(string nom in nomArtistes)
            {
                Artiste artiste = new Artiste { Nom = nom };
                artistes.Add(artiste);
                foreach(string nomMus in nomMusique)
                {
                    Musique musique = new Musique
                    {
                        artiste = artiste,
                        titre = nomMus,
                        Longueur = new int(),
                    };
                    musiques.Add(musique);
                }
            }
            foreach(Musique m in musiques)
            {
                Console.WriteLine("Artiste {0} titre {1} long {2}",m.artiste.Nom,m.titre,m.Longueur );
            }

        }
    }
}
