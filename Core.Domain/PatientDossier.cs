using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class PatientDossier
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public int Age { get; set; } //Automatisch berekend
        public string IssueNotes { get; set; }
        public int DiagnoseCode { get; set; }
        public string DiagnoseNotes { get; set; }
        public Role Role { get; set; }
        //public Employee IntakeBy{get;set;} default mag ingelogde zijn, moet aan te passen zijn
        //public Employee IntakeSupervisor{get;set;} default mag ingelogde zijn, moet aan te passen zijn
        //public Employee Therapist, keuzelijst van medewerkers
        public DateTime SignUp { get; set; }
        public DateTime LastTreatment { get; set; }
        public string Notes { get; set; }
        public string TreatmentPlan { get; set; }
        public int Treatments { get; set; } //Geen idee of dit een count moet zijn of een beschrijving van een behandeling
    }
}
