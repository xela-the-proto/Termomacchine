using System;
using System.Windows.Forms;

namespace Termomacchine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        public void UpdateListBox(string lstValue)
        {
            listBox1.Items.Add(lstValue);
        }


        /*
                public string nome_nodo_inizio
                {
                    get
                    {
                        return this.lbl_nome_nodo_inizio.Text;
                    }

                    set
                    {
                        this.lbl_nome_nodo_inizio.Text = value;
                    }
                }

                public string valore_nodo
                {
                    get
                    {
                        return this.lbl_valore.Text;
                    }

                    set
                    {
                        this.lbl_valore.Text = value;
                    }
                }

                public string attributo_nodo
                {
                    get
                    {
                        return this.lbl_attributo.Text;
                    }
                    set
                    {
                        this.lbl_attributo.Text = value;
                    }
                }

                public string testo_nodo
                {
                    get
                    {
                        return this.lbl_testo.Text;
                    }

                    set
                    {
                        this.lbl_testo.Text = value;
                    }
                }


                public string nome_nodo_fine
                {
                    get
                    {
                        return this.lbl_nome_nodo_fine.Text;
                    }

                    set
                    {
                        this.lbl_nome_nodo_fine.Text = value;
                    }
                }
        */


    }
}
