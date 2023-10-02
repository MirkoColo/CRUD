using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CRUD : Form
    {
        public struct Prodotto
        {
            public string nome;
            public float prezzo;
        }   
        public Prodotto[] p;

        public int dim;
        public CRUD()
        {
            InitializeComponent();
            p = new Prodotto[0];
            dim = 0;

            LISTA.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
            ConfermaDelete.Visible = false;
            ConfermaUpdate.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CREATE_Click(object sender, EventArgs e)
        {
            Array.Resize(ref p, p.Length + 1);
            p[dim].nome = NOME.Text;
            p[dim].prezzo = float.Parse(PREZZO.Text);
            dim++;
            //MessageBox.Show($"Il prodotto {NOME.Text} al prezzo di {PREZZO.Text} euro è stato aggiunto al carrello");
            NOME.Text = "";
            PREZZO.Text = "";
            AggiornaLista();
            LISTA.Visible = true;
            UPDATE.Visible = true;
            DELETE.Visible = true;
        }

        
        private void READ_Click(object sender, EventArgs e)
        {
            /*
            LISTA.Visible = true;
            UPDATE.Visible = true;
            DELETE.Visible = true;
            LISTA.Items.Clear();
            for(int i = 0; i < dim; i++)
            {
                LISTA.Items.Add(VisualizzaStringa(p[i]));
            }
            */
        }
        
        private void UPDATE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selezionare il prodotto da cancellare e poi Inserire il nome e il prezzo del nuovo prodotto");
            ConfermaUpdate.Visible = true;
        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void LISTA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selezionare il prodotto da cancellare");
            ConfermaDelete.Visible = true;
        }
        private void ConfermaUpdate_Click(object sender, EventArgs e)
        {
            int indiceLista = LISTA.SelectedIndex;
            if(NOME.Text == " " && PREZZO.Text == " ")
            {
                MessageBox.Show("Inserire il nome e il prezzo del nuovo prodotto");
            }
            else if(NOME.Text == " ")
            {
                MessageBox.Show("Inserire il prezzo del nuovo prodotto");
            }
            else if (PREZZO.Text == " ")
            {
                MessageBox.Show("Inserire il nome del nuovo prodotto");
            }
            else
            {
                p[indiceLista].nome = NOME.Text;
                p[indiceLista].prezzo = float.Parse(PREZZO.Text);
                AggiornaLista();
                ConfermaUpdate.Visible = false;
            }      
        }

        private void ConfermaDelete_Click(object sender, EventArgs e)
        {
            for (int i = LISTA.SelectedIndex; i < p.Length - 1; i++)
            {
                p[i].nome = p[i + 1].nome;
                p[i].prezzo = p[i + 1].prezzo;
            }      
            Array.Resize(ref p, p.Length - 1);
            dim--;
            AggiornaLista();
            ConfermaDelete.Visible = false;
            if(p.Length == 0)
            {
                LISTA.Visible = false;
                UPDATE.Visible = false;
                DELETE.Visible = false;
            }
        }

        private void ORDINAMENTO_Click(object sender, EventArgs e)
        {
            OrdinamentoAlfabetico();
            AggiornaLista();
        }
        private void Somma_Click(object sender, EventArgs e)
        {
            float somma = SommaPrezzi(p);
            MessageBox.Show($"La somma di tutti i prodottti è {SommaPrezzi(p)}");
        }

        private void PrezzoMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Il prezzo minimo è {TrovaMinimo(p)}");
        }

        private void PrezzoMassimo_Click(object sender, EventArgs e)
        {
            
        }

        //FUNZIONI DI SERVIZIO 
        public void AggiornaLista()
        {
            LISTA.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                LISTA.Items.Add($"{p[i].nome} - {p[i].prezzo}euro");
            }
        }

        public string VisualizzaStringa(Prodotto p)
        {
            return $"{p.nome} - {p.prezzo}euro";
        }

        private void USCITA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void OrdinamentoAlfabetico()
        {
            for(int i = 0; i < p.Length - 1; i++)
            {
                for(int j = i  +1; j < p.Length; j++)
                {
                    if (p[i].nome.CompareTo(p[j].nome) > 0)
                    {
                        string a = p[i].nome;
                        p[i].nome = p[j].nome;
                        p[j].nome = a;
                    }
                }
            }

        }

        public float SommaPrezzi(Prodotto[] p)
        {
            float somma = 0;

            for(int i = 0; i < dim; i++)
            {
                somma += p[i].prezzo;
            }
            return somma;
        }

        public float TrovaMinimo(Prodotto[] p)
        {
            float minimo = 100;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo < minimo)
                {
                    minimo = p[i].prezzo;
                }
            }
            return minimo;
        }
        public float TrovaMassimo(Prodotto[] p)
        {
            float massimo = 0;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo > massimo)
                {
                    massimo = p[i].prezzo;
                }
            }
            return massimo;
        }

    }
}
