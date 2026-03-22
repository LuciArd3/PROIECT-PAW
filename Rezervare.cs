using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]
    public class Rezervare :ICloneable , IComparable
    {
        private int id;
        private Client client;
        private Camera camera;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;
        private string status;


        public Rezervare()
        {

        }
        public Rezervare(int id, Client client, Camera camera, DateTime dataCheckIn, DateTime dataCheckOut, string status)
        {
            this.id = id;
            this.client = client;
            this.camera = camera;
            this.dataCheckIn = dataCheckIn;
            this.dataCheckOut = dataCheckOut;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataCheckIn { get => dataCheckIn; set => dataCheckIn = value; }
        public DateTime DataCheckOut { get => dataCheckOut; set => dataCheckOut = value; }
        public string Status { get => status; set => status = value; }
        internal Client Client { get => client; set => client = value; }
        internal Camera Camera { get => camera; set => camera = value; }


        public int noptiSedere()
        {
            int sedere = (dataCheckOut - dataCheckIn).Days;
            return sedere;
        }

        public float costTotal()
        {
            return noptiSedere() * camera.PretNoapte;
        }


        public override string ToString()
        {
            return "Rezervare : " + id + " | Client : " + client.Nume + " | Camera : " + camera.Numar +
                " | Data check-in : " + dataCheckIn.ToShortDateString() + " | Data check-out : " + dataCheckOut.ToShortDateString() 
                + " | Nopti sedere : " + noptiSedere() + " | Cost total : " + costTotal();
        }

        public object Clone()
        {
            Rezervare clona = (Rezervare) this.MemberwiseClone();
            clona.id = id;
            clona.client = client;
            clona.camera = camera;
            clona.dataCheckIn= dataCheckIn;
            clona.dataCheckOut= dataCheckOut;
            clona.status = status;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Rezervare r = (Rezervare)obj;
            if (this.Camera.PretNoapte < r.Camera.PretNoapte) return -1;
            if (this.Camera.PretNoapte > r.Camera.PretNoapte) return 1;
            return 0;
        }


    }
}
