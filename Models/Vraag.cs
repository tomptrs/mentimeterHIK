using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentiMeterTest.Models
{
    public class Vraag
    {
        public int VraagId { get; set; }
        public string Text { get; set; }
    }

    public class Antwoord
    {
        public int AntwoordId { get; set; }
        public int VraagId { get; set; }
        public Vraag Vraag { get; set; }
        public string Text { get; set; }
    }

    public class Les
    {
        public int LesId { get; set; }
        public List<Vraag> Vragen { get; set; }
    }
}
