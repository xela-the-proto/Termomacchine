using System;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Xml;
using Termomacchine;


namespace Termomacchine
{

    public partial class Form1 : Form
    {
        int i;
        int numCom = 0;
        string numSer = "";
        int prezzo = 0;
        int numPLC = 0;
        int numIngressi = 0;
        int numUscite = 0;
        int numMotori = 0;
        string codiceInterno = "";
        double voltaggio = 0;
        double ampere = 0;
        bool omron = false;
        bool scheneider = false;
        bool siemens = false;



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_inserisci_Click(object sender, EventArgs e)
        {
            Stream stream;
            string vero = "vero";
            i = Int32.Parse(Interaction.InputBox("inserire il numero di macchine da mettere in lista", "input indice"));
            Macchina[] macchina = new Macchina[i];
            int f;
            f = 0;
            var check = MsgBoxResult.Cancel;
            bool continuare = false;

            for (int j = 0; j < i; j++)
            {
                Macchina input = new Macchina(numCom, numSer, prezzo, numPLC, numIngressi, numUscite, numMotori,
                    codiceInterno, voltaggio, ampere, omron, scheneider, siemens);

                input.NumCom  = Int32.Parse(Interaction.InputBox("inserire il numero della commessa (solo numeri interi)", "input " + Convert.ToString(j + 1)));
                input.NumSer = Interaction.InputBox("inserire il numero di serie (numeri interi e caratteri alfabetici", "input" + Convert.ToString(j + 1));
                input.Prezzo = Int32.Parse(Interaction.InputBox("inserire il prezzo (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumPlc = Int32.Parse(Interaction.InputBox("inserire il numero di plkc richiesti (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumIngressi = Int32.Parse(Interaction.InputBox("inserire il numero di ingressi (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumUscite = Int32.Parse(Interaction.InputBox("inserire il numero di uscite (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumMotori = Int32.Parse(Interaction.InputBox("inserire il numero di motori richiesti (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.CodiceInterno = Interaction.InputBox("inserire il codice interno (numeri interi e caratteri alfabetici)", "input" + Convert.ToString(j + 1));
                input.Voltaggio = Int32.Parse(Interaction.InputBox("inserire il voltaggio della macchina ", "input" + Convert.ToString(j + 1)));
                input.Ampere = Int32.Parse(Interaction.InputBox("Inserire il numero di ampere", "input" + Convert.ToString(j + 1)));
                if (vero.Equals(Interaction.InputBox("il plc è omron? (rispondere con \"vero\" o \"falso\"", "input" + Convert.ToString(j + 1))))
                {
                    input.Omron = true;
                }
                else
                {
                    input.Omron = false;
                }
                if (vero.Equals(Interaction.InputBox("il plc è schneider? (rispondere con \"vero\" o \"falso\"", "input" + Convert.ToString(j + 1))))
                {
                    input.Scheneider = true;
                }
                else
                {
                    input.Scheneider = false;
                }
                if (vero.Equals(Interaction.InputBox("il plc è siemens? (rispondere con \"vero\" o \"falso\"", "input" + Convert.ToString(j + 1))))
                {
                    input.Siemens = true;
                }
                else
                {
                    input.Siemens = false;
                }

                macchina[j] = input;

                if (j + 1 != i)
                {
                    check = Interaction.MsgBox("Si vuole ocntinuare l'inseriemnto di dati pe rla prossima macchina",
                        MsgBoxStyle.YesNo);
                }
                else
                {
                    check = MsgBoxResult.No;
                }

                if (check == MsgBoxResult.Yes)
                {
                    continuare = true;

                }else if (check == MsgBoxResult.No)
                {
                    continuare = false;
                }

                if (continuare == false )
                {
                    save_file.Filter = "XML file|*.xml";
                    save_file.Title = "Save as XML";
                    if (save_file.ShowDialog() == DialogResult.OK)
                    {
                        for (int x = 0; x < j + 1; x++)
                        {
                            SaveViaDataContractSerialization(macchina[x],
                                save_file.FileName.Insert(save_file.FileName.Length - 4, " N° " + macchina[x].NumCom));

                        }
                    }

                    break;
                }

            }



            

        }

        void SaveViaDataContractSerialization<T>(T serializableObject, string filepath)
        {
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filepath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }   

    }
    

}
