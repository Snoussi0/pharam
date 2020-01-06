using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHARAM.Models
{
    public class Pharmacie
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string MotPasse { get; set; }
        public bool Nuit { get; set; }

        public string Nom { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}