using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            dim = 0;
            p = new Prodotto[dim];

            LISTA.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
            ConfermaDelete.Visible = false;
            ConfermaUpdate.Visible = false;
            Ordinamento.Visible = false;
            Somma.Visible = false;
            PrezzoMin.Visible = false;
            PrezzoMassimo.Visible = false;
            Salva.Visible = false;
            SommaPercentuale.Visible = false;
            SottraiPercentuale.Visible = false;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //FUNZIONE AGGIUNGI
        private void CREATE_Click(object sender, EventArgs e)
        {
            bool controllo = ControlloInserimento(NOME.Text, PREZZO.Text);

            if (NOME.Text == "" && PREZZO.Text == "")
            {
                MessageBox.Show("Inserire il nome e il prezzo del prodotto");
            }
            else if (NOME.Text == "")
            {
                MessageBox.Show("Inserire il nome del prodotto");
            }
            else if (PREZZO.Text == "")
            {
                MessageBox.Show("Inserire il prezzo del prodotto");
            }
            else if (controllo == true)
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
                Ordinamento.Visible = true;
                Somma.Visible = true;
                PrezzoMin.Visible = true;
                PrezzoMassimo.Visible = true;
                Salva.Visible = true;
                SommaPercentuale.Visible = true;
                SottraiPercentuale.Visible = true;
            }
            else
            {
                MessageBox.Show("Il prodotto non è stato inserito");
                NOME.Text = "";
                PREZZO.Text = "";
            }
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
            bool controllo = ControlloInserimento(NOME.Text, PREZZO.Text);
            
                if (NOME.Text == "" && PREZZO.Text == "")
                {
                    MessageBox.Show("Inserire il nome e il prezzo del nuovo prodotto");
                }
                else if (NOME.Text == "")
                {
                    MessageBox.Show("Inserire il nome del nuovo prodotto");
                }
                else if (PREZZO.Text == "")
                {
                    MessageBox.Show("Inserire il prezzo del nuovo prodotto");
                }
                else if(controllo == true)
                {
                    int indiceLista = LISTA.SelectedIndex;
                    p[indiceLista].nome = NOME.Text;
                    p[indiceLista].prezzo = float.Parse(PREZZO.Text);
                    AggiornaLista();
                    ConfermaUpdate.Visible = false;
                    NOME.Text = "";
                    PREZZO.Text = "";
                }
                else
                {
                    MessageBox.Show("Il prodotto non è stato inserito");
                    NOME.Text = "";
                    PREZZO.Text = "";
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
            if(dim == 0)
            {
                LISTA.Visible = false;
                UPDATE.Visible = false;
                DELETE.Visible = false;
                Ordinamento.Visible = false;
                Somma.Visible = false;
                PrezzoMin.Visible = false;
                PrezzoMassimo.Visible = false;
                Salva.Visible = false;
                SommaPercentuale.Visible = false;
                SottraiPercentuale.Visible = false;
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
            MessageBox.Show($"Il prezzo massimo è {TrovaMassimo(p)}");
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            SalvaSuFile();
        }

        private void Leggi_Click(object sender, EventArgs e)
        {
            LeggiDaFile();
            UPDATE.Visible = true;
            DELETE.Visible = true;
            Ordinamento.Visible = true;
            Somma.Visible = true;
            PrezzoMin.Visible = true;
            PrezzoMassimo.Visible = true;
            Salva.Visible = true;
            SommaPercentuale.Visible = true;
            SottraiPercentuale.Visible = true;
        }

        private void SommaPercentuale_Click(object sender, EventArgs e)
        {
            int percentuale = InputPercentuale(p);
            float[] PrezziScontati = new float[dim];
            for (int i = 0; i < dim; i++)
            {
                PrezziScontati[i] = p[i].prezzo + (p[i].prezzo * percentuale / 100);
            }
            LISTA.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                LISTA.Items.Add($"{p[i].nome};{PrezziScontati[i]}euro");
            }
        }

        private void SottraiPercentuale_Click(object sender, EventArgs e)
        {
            int percentuale = InputPercentuale(p);
            float[] PrezziScontati = new float[dim];
            for (int i = 0; i < dim; i++)
            {
                PrezziScontati[i] = p[i].prezzo - (p[i].prezzo * percentuale / 100);
            }
            LISTA.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                LISTA.Items.Add($"{p[i].nome};{PrezziScontati[i]}euro");
            }
        }

        private void PercentualeVB_Click(object sender, EventArgs e)
        {

        }
        private void USCITA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //FUNZIONI DI SERVIZIO 
        public void AggiornaLista()
        {
            LISTA.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                LISTA.Items.Add($"{p[i].nome};{p[i].prezzo}euro");
            }
        }

        //BUBBLE SORT CON FUNZIONE CompareTo
        public void OrdinamentoAlfabetico()
        {
            for(int i = 0; i < p.Length - 1; i++)
            {
                for(int j = i + 1; j < p.Length; j++)
                {
                    if (p[i].nome.CompareTo(p[j].nome) > 0)
                    {
                        string a = p[i].nome;
                        p[i].nome = p[j].nome;
                        p[j].nome = a;
                        float b = p[i].prezzo;
                        p[i].prezzo = p[j].prezzo;
                        p[j].prezzo = b;
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
            float minimo = 10000;
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

        public void SalvaSuFile()
        {
            StreamWriter sw = new StreamWriter("LISTA.txt");
            for (int i = 0; i < dim; i++)
            {
                sw.WriteLine($"{p[i].nome};{p[i].prezzo}");
            }
            sw.Close();
        }    

        public void LeggiDaFile()
        {
            dim = 0;
            LISTA.Items.Clear();
            StreamReader sr = new StreamReader(@"LeggiLista.txt");
            string line = sr.ReadLine();
            while (line != null)
            {            
                string[] rigaSplit = Split(line);
                Array.Resize(ref p, p.Length + 1);
                p[dim].nome = rigaSplit[0];
                p[dim].prezzo = float.Parse(rigaSplit[1]);
                dim++;
                line = sr.ReadLine();
            }
            sr.Close();
            LISTA.Visible = true;
            AggiornaLista();

        }

        //GESTIONE INPUT CON VISUAL BASIC
        public int InputPercentuale(Prodotto[] p)
        {
            string message //ISTRUZIONI FORNITE ALL'UTENTE
                , title, //TITOLO MESSAGGIO
                defaultValue; //MESSAGGIO DI BASE
            string percentuale;
            bool controllo = false;
            int percentuale2 = 0;
            message = "Inserisci la percentuale";
            title = "Percentuale Input";
            defaultValue = "";
            do
            {
                percentuale = Interaction.InputBox(message, title, defaultValue);
                if ((string)percentuale != "" && percentuale.All(char.IsNumber))
                {
                    Interaction.MsgBox("La percentuale è stata inserita correttamente");
                    percentuale2 = (int)Convert.ToInt64(percentuale);
                    controllo = true;
                }
                else
                {
                    percentuale = defaultValue;
                    Interaction.MsgBox("La percentuale non è stata inserita correttamente");
                }
            } while (controllo == false);
            

            return percentuale2;
        }

        //GESTIONE INSERIMENTO DEL NOME E DEL PREZZO DEL PRODOTTO
        public bool ControlloInserimento(string nome, string prezzo)
        {
            bool uscitaPrezzo = false;
            if (prezzo.All(char.IsNumber))
            {
                uscitaPrezzo = true;
            }
            return uscitaPrezzo;
        }
        static string[] Split(string stringa)
        {

            string[] array = new string[2];
            string frase = "";
            int p = 0;
            for (int i = 0; i < stringa.Length; i++)
            {
                if (stringa[i] == ';')
                {
                    array[p] = frase;
                    p++;
                    frase = "";
                }
                else
                {
                    frase += stringa[i];
                }

                if (i == stringa.Length - 1)
                {
                    array[p] = frase;
                }
            }
            return array;
        }


    }
}
