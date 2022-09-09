using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stirbescu_Monica_Proiect_Paw
{
    public class Camera
    {
        public int NrCamera;
        public int Dimensiune;
        public double Pret;

        public Camera(int _nr, int _dim, double _pret)
        {
            NrCamera = _nr;
            Dimensiune = _dim;
            Pret = _pret;
        }

        public int nrCamera
        {
            get { return this.NrCamera; }
            set { this.NrCamera = value; }
        }

        public int dimensiune
        {
            get { return this.Dimensiune; }
            set { this.Dimensiune = value; }
        }

        public double pret
        {
            get { return this.Pret; }
            set { if(value>0) this.Pret = value; }
        }

    }
}
