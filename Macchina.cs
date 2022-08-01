using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Termomacchine
{
    [DataContract]
    public class Macchina
    {
        [DataMember]
        private int numCom;
        [DataMember]
        private string numSer;
        [DataMember]
        private int prezzo;
        [DataMember]
        private int numPLC;
        [DataMember]
        private int numIngressi;
        [DataMember]
        private int numUscite;
        [DataMember]
        private int numMotori;
        [DataMember]
        private string codiceInterno;
        [DataMember]
        private double voltaggio;
        [DataMember]
        private double ampere;
        [DataMember]
        private bool omron;
        [DataMember]
        private bool scheneider;
        [DataMember]
        private bool siemens;

        public Macchina(int numCom, string numSer, int prezzo, int numPLC,
            int numIngressi, int numUscite, int numMotori, string codiceInterno, double voltaggio,
            double ampere, bool omron, bool scheneider, bool siemens)
        {
            this.numCom = numCom;
            this.numSer = numSer;
            this.prezzo = prezzo;
            this.numPLC = numPLC;
            this.numIngressi = numIngressi;
            this.numUscite = numUscite;
            this.numMotori = numMotori;
            this.codiceInterno = codiceInterno;
            this.voltaggio = voltaggio;
            this.ampere = ampere;
            this.omron = omron;
            this.scheneider = scheneider;
            this.siemens = siemens;
        }

        public Macchina(){}

        public int NumCom
        {
            get => numCom;
            set => numCom = value;
        }

        public string NumSer
        {
            get => numSer;
            set => numSer = value;
        }

        public int Prezzo
        {
            get => prezzo;
            set => prezzo = value;
        }

        public int NumPlc
        {
            get => numPLC;
            set => numPLC = value;
        }

        public int NumIngressi
        {
            get => numIngressi;
            set => numIngressi = value;
        }

        public int NumUscite
        {
            get => numUscite;
            set => numUscite = value;
        }

        public int NumMotori
        {
            get => numMotori;
            set => numMotori = value;
        }

        public string CodiceInterno
        {
            get => codiceInterno;
            set => codiceInterno = value;
        }

        public double Voltaggio
        {
            get => voltaggio;
            set => voltaggio = value;
        }

        public double Ampere
        {
            get => ampere;
            set => ampere = value;
        }

        public bool Omron
        {
            get => omron;
            set => omron = value;
        }

        public bool Scheneider
        {
            get => scheneider;
            set => scheneider = value;
        }

        public bool Siemens
        {
            get => siemens;
            set => siemens = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
