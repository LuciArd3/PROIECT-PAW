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
        private string CNP;
      
        public Client()
        {
            nume = "Anonim";
            sex = 'N';
            nrTelefon = "Anonim";
            CNP = "Anonim";
        }

        public Client(string nume, char sex, string nrTelefon, string cNP)
        {
            this.nume = nume;
            this.sex = sex;
            this.nrTelefon = nrTelefon;
            CNP = cNP;
        }

        public string Nume { get => nume; set => nume = value; }
        public char Sex { get => sex; set => sex = value; }
        public string NrTelefon { get => nrTelefon; set => nrTelefon = value; }
        public string CNP1 { get => CNP; set => CNP = value; }

        public object Clone()
        {
            Client clone = (Client)MemberwiseClone();
            clone.nume = nume;
            clone.sex = sex;
            clone.CNP = CNP;
            clone.nrTelefon= nrTelefon;
            return clone;
        }

        public override string ToString()
        {
            return "Client : " + nume + " | Sex : " + sex  + " | NrTelefon : " + nrTelefon + 
             " | CNP : " +CNP;
        }

    } 
}
