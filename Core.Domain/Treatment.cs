using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Treatment
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Description { get; set; }
        public string TreatmentRoom { get; set; }
        public string Notes { get; set; }
        public string TreatmentBy { get; } //Keuzelijst uit fysiotherapeuten en studenten, standaard is de hoofdbehandelaar
        public DateTime TreatmentDate { get; set; } //Gebruiker moet datum kunnen kiezen dmv datumprikker
    }
}
