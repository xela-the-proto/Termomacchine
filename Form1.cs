using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;


namespace Termomacchine
{

    public partial class Form1 : Form
    {
        int i;
        int NumCommessa = 0;
        string NumSeriale = "";
        int prezzo = 0;
        int numPLC = 0;
        int numIngressi = 0;
        int numUscite = 0;
        int numMotori = 0;
        string codiceInterno = "";
        double voltaggio = 0;
        double ampere = 0;
        string omron = "";
        string scheneider = "";
        string siemens = "";



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
            string vero = "si";
            i = Int32.Parse(Interaction.InputBox("inserire il numero di macchine da mettere in lista", "input indice"));
            Macchina[] macchina = new Macchina[i];
            int f;
            f = 0;
            var check = MsgBoxResult.Cancel;
            bool continuare = false;

            for (int j = 0; j < i; j++)
            {
                Macchina input = new Macchina(NumCommessa, NumSeriale, prezzo, numPLC, numIngressi, numUscite, numMotori,
                    codiceInterno, voltaggio, ampere, omron, scheneider, siemens);

                input.NumCommessa = Int32.Parse(Interaction.InputBox("inserire il numero della commessa (solo numeri interi)", "input " + Convert.ToString(j + 1)));
                input.NumSeriale = Interaction.InputBox("inserire il numero di serie (numeri interi e caratteri alfabetici", "input" + Convert.ToString(j + 1));
                input.Prezzo = Int32.Parse(Interaction.InputBox("inserire il prezzo (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumPlc = Int32.Parse(Interaction.InputBox("inserire il numero di plkc richiesti (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumIngressi = Int32.Parse(Interaction.InputBox("inserire il numero di ingressi (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumUscite = Int32.Parse(Interaction.InputBox("inserire il numero di uscite (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.NumMotori = Int32.Parse(Interaction.InputBox("inserire il numero di motori richiesti (solo numeri interi)", "input" + Convert.ToString(j + 1)));
                input.CodiceInterno = Interaction.InputBox("inserire il codice interno (numeri interi e caratteri alfabetici)", "input" + Convert.ToString(j + 1));
                input.Voltaggio = Int32.Parse(Interaction.InputBox("inserire il voltaggio della macchina ", "input" + Convert.ToString(j + 1)));
                input.Ampere = Int32.Parse(Interaction.InputBox("Inserire il numero di ampere", "input" + Convert.ToString(j + 1)));
                if (vero.Equals(Interaction.InputBox("il plc è omron? (rispondere con \"si\" o \"no\"", "input" + Convert.ToString(j + 1))))
                {
                    input.Omron = "si";
                }
                else
                {
                    input.Omron = "no";
                }
                if (vero.Equals(Interaction.InputBox("il plc è schneider? (rispondere con \"si\" o \"no\"", "input" + Convert.ToString(j + 1))))
                {
                    input.Scheneider = "si";
                }
                else
                {
                    input.Scheneider = "no";
                }
                if (vero.Equals(Interaction.InputBox("il plc è siemens? (rispondere con \"si\" o \"no\"", "input" + Convert.ToString(j + 1))))
                {
                    input.Siemens = "si";
                }
                else
                {
                    input.Siemens = "no";
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

                }
                else if (check == MsgBoxResult.No)
                {
                    continuare = false;
                }

                if (continuare == false)
                {
                    save_file.Filter = "XML file|*.xml";
                    save_file.Title = "Save as XML";
                    if (save_file.ShowDialog() == DialogResult.OK)
                    {
                        for (int x = 0; x < j + 1; x++)
                        {
                            SaveViaDataContractSerialization(macchina[x],
                                save_file.FileName.Insert(save_file.FileName.Length - 4, " N° " + macchina[x].NumCommessa));

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

        private void btn_apertura_Click(object sender, EventArgs e)
        {
            open_file.Filter = "XML file|*.xml";
            open_file.Title = "Open XML";
            open_file.ShowDialog();

            Form2 form2 = new Form2();
            form2.Show();

            XmlTextReader xmlReader = new XmlTextReader(open_file.FileName);
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        form2.UpdateListBox(xmlReader.Name);
                        break;
                    case XmlNodeType.Text:
                        form2.UpdateListBox(xmlReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        form2.UpdateListBox("");
                        break;
                }
            }


            /*
            String url_file = "";
            
            

            url_file = open_file.FileName;

            XmlTextReader reader = new XmlTextReader(url_file);


            Form2 form2 = new Form2();
            form2.Show();


            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        form2.nome_nodo_inizio = "<" + reader.Name;

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            form2.attributo_nodo = " " + reader.Name + "='" + reader.Value + "'";
                        Console.Write(">");
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        form2.testo_nodo = reader.Value;
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        form2.nome_nodo_fine = "</" + reader.Name;
                        break;
                }
            }
            */

        }
    }


}
