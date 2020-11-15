using System;
using System.Collections.Generic;
using System.Text;

namespace RevisionLINQ
{
    class Musique
    {
        public int Id { get; set; }
        public int Longueur { get; set; }
        public string titre { get; set; }
        public Artiste artiste { get; set; }
    }
}
