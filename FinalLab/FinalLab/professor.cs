using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
   public class professor
    {
        int pID;
        string fn;
        string ln;
        string ct;

        public professor(int ID, string fN, string lN, string classN)
        {
            pID = ID;
            fn = fN;
            ln = lN;
            ct = classN;
        }

        public int getID
        {
            set { pID = value; }
            get { return pID; }
        }

        public string getfirstName
        {
            set { fn = value; }
            get { return fn; }
        }

        public string getlastName
        {
            set { ln = value; }
            get { return ln ; }
        }

        public string getClass
        {
            set { ct = value; }
            get { return ct; }
        }

    }
}
