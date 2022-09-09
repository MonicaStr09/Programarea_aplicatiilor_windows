using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stirbescu_Monica_Proiect_Paw
{
    public class Rezervare
    {
        public string NumeClient;
        public string PrenumeClient;
        public int zi;
        public int luna;
        public int an;
        public Camera camera;

        public Rezervare(string _nume, string _prenume, int _zi, int _luna, int _an)
         
        {
            NumeClient = _nume;
            PrenumeClient = _prenume;
            zi = _zi;
            luna = _luna;
            an = _an;
        }

        public string numeClient
        {
            get { return NumeClient; }
            set { this.NumeClient = value; }
        }

        public string prenumeClient
        {
            get { return PrenumeClient; }
            set { this.PrenumeClient = value; }
        }

        public int Zi
        {
            get { return zi; }
            set { this.zi = value; }
        }

        public int Luna
        {
            get { return luna; }
            set { this.luna = value; }
        }

        public int An
        {
            get { return an; }
            set { this.an = value; }
        }


    }
}
