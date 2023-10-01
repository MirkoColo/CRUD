using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            p = new Prodotto[100];
            dim = 0;

            LISTA.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CREATE_Click(object sender, EventArgs e)
        {
            p[dim].nome = NOME.Text;
            p[dim].prezzo = float.Parse(PREZZO.Text);
            dim++;
            MessageBox.Show($"Il prodotto {NOME.Text} al prezzo di {PREZZO.Text} euro è stato aggiunto al carrello");
            NOME.Text = "";
            PREZZO.Text = "";
        }

        private void READ_Click(object sender, EventArgs e)
        {
            LISTA.Visible = true;
            LISTA.Items.Clear();
            for(int i = 0; i < dim; i++)
            {
                LISTA.Items.Add(VisualizzaStringa(p[i]));
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void DELETE_Click(object sender, EventArgs e)
        {

        }

        //FUNZIONI DI SERVIZIO 

        public string VisualizzaStringa(Prodotto p)
        {
            return $"{p.nome} - {p.prezzo}euro";
        }
    }
}
