using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    internal class Camera : ICloneable
    {
        private int numar;
        private string tip;
        private float pretNoapte;
        private int etaj;

        public Camera()
        {
            Numar = 0;
            Tip = "Anonim";
            PretNoapte=0;
            Etaj = 0;
        }
        public Camera(int numar, string tip, float pretNoapte, int etaj)
        {
            this.Numar = numar;
            this.Tip = tip;
            this.PretNoapte = pretNoapte;
            this.Etaj = etaj;
        }

        public int Numar { get => numar; set => numar = value; }
        public string Tip { get => tip; set => tip = value; }
        public float PretNoapte { get => pretNoapte; set => pretNoapte = value; }
        public int Etaj { get => etaj; set => etaj = value; }

        public object Clone()
        {
            Camera clona = (Camera) this.MemberwiseClone();
            clona.Numar = Numar;
            clona.Tip = Tip;
            clona.Etaj= Etaj;
            clona.pretNoapte = PretNoapte; 
            return clona;
        }

        public override string ToString()
        {
            return "Camera : " + numar + " | Tip : " + tip +" | Pret (noapte) : " + pretNoapte +
                " | Etaj : " + etaj;
        }
    }
}
