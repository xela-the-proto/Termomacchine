using System.Runtime.Serialization;

namespace Termomacchine
{
    [DataContract]
    public class Macchina
    {
        [DataMember]
        private int numCommessa;
        [DataMember]
        private string numSeriale;
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
        private string omron;
        [DataMember]
        private string scheneider;
        [DataMember]
        private string siemens;

        public Macchina(int NumCommessa, string NumSeriale, int prezzo, int numPLC,
            int numIngressi, int numUscite, int numMotori, string codiceInterno, double voltaggio,
            double ampere, string omron, string scheneider, string siemens)
        {
            this.numCommessa = NumCommessa;
            this.numSeriale = NumSeriale;
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

        public Macchina()
        {
            numCommessa = 0;
            numSeriale = "";
            prezzo = 0;
            numPLC = 0;
            numIngressi = 0;
            numUscite = 0;
            numMotori = 0;
            codiceInterno = "";
            voltaggio = 0;
            ampere = 0;
            omron = "";
            scheneider = "";
            siemens = "";
        }

        public int NumCommessa
        {
            get => numCommessa;
            set => numCommessa = value;
        }

        public string NumSeriale
        {
            get => numSeriale;
            set => numSeriale = value;
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

        public string Omron
        {
            get => omron;
            set => omron = value;
        }

        public string Scheneider
        {
            get => scheneider;
            set => scheneider = value;
        }

        public string Siemens
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
