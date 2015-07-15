using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    public class Degree
    {
        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }

        private Course c;
        public Course C
        {
            get { return c; }
            set { c = value; }
        }

        private string degreeName;
        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
    }
}
