using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.DL;

namespace HMS_App.BL
{
    class Report
    {
        private string laboratorytest;
        private int cholestrolLevel;
        private string cholestrol;
        private string typhoid;
        private string malaria;
        private string anemia;
        private string diagnostictest;

        public Report() { }
        public Report(string laboratorytest, int cholestrolLevel,string cholestrol,string typhoid,string malaria,string anemia,string diagnostictest)
        {
            this.laboratorytest = laboratorytest;
            this.cholestrolLevel = cholestrolLevel;
            this.cholestrol = cholestrol;
            this.typhoid = typhoid;
            this.malaria = malaria;
            this.anemia = anemia;
            this.diagnostictest = diagnostictest;
        }
        public string getLaboratorytest() { return laboratorytest; }
        public int getCholestrolLevel() { return cholestrolLevel; }
        public string getCholestrol() { return cholestrol; }
        public string getTyphoid() { return typhoid; }
        public string getMalaria() { return malaria; }
        public string getAnemia() { return anemia; }
        public string getDiagnostictest() { return diagnostictest; }

        public void setLaboratorytest(string laboratorytest) { this.laboratorytest = laboratorytest; }
        public void setCholestrolLevel(int cholestrolLevel) { this.cholestrolLevel = cholestrolLevel; }
        public void setCholestrol(string cholestrol) { this.cholestrol = cholestrol; }
        public void setTyphoid(string typhoid) { this.typhoid = typhoid; }
        public void setMalaria(string malaria) { this.malaria = malaria; }
        public void setAnemia(string anemia) { this.anemia = anemia; }
        public void setDiagnostictest(string diagnostictest) { this.diagnostictest = diagnostictest; }

        public void Generatemedicalreport()
        {

            if (laboratorytest == "blood test")
            {
                if (cholestrolLevel < 100)
                {
                    cholestrol = "Optimum";
                }
                if (cholestrolLevel >= 100 && cholestrolLevel < 130)
                {
                    cholestrol = "Fairly Good";
                }
                if (cholestrolLevel >= 130 && cholestrolLevel < 160)
                {
                    cholestrol = "Borederline High";
                }
                if (cholestrolLevel >= 160 && cholestrolLevel < 190)
                {
                    cholestrol = "High";
                }
                if (cholestrolLevel >= 190)
                {
                    cholestrol = "Very High";
                }
            }
        }
    }
}
