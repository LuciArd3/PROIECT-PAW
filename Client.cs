using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]
    public class Client : ICloneable
    {
        private string nume;
        private char sex;
        private string nrTelefon;
      
        public Client()
        {
            nume = "Anonim";
            sex = 'N';
            nrTelefon = "Anonim";
        }

        public Client(string nume, char sex, string nrTelefon)
        {
            this.nume = nume;
            this.sex = sex;
            this.nrTelefon = nrTelefon;
        }

        public string Nume { get => nume; set => nume = value; }
        public char Sex { get => sex; set => sex = value; }
        public string NrTelefon { get => nrTelefon; set => nrTelefon = value; }

        public object Clone()
        {
            Client clone = (Client)MemberwiseClone();
            clone.nume = nume;
            clone.sex = sex;
            clone.nrTelefon= nrTelefon;
            return clone;
        }

        public override string ToString()
        {
            return "Client : " + nume + " | Sex : " + sex + " | NrTelefon : " + nrTelefon;
        }

    } 
}
