using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFive
{
    public class UProgram
    {
        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }

        private Degree d;
        public Degree D
        {
            get { return d; }
            set { d = value; }
        }

        private string programName;
        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }
    }
}
