namespace CRUD
{
    partial class CRUD
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.CREATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.NOME = new System.Windows.Forms.TextBox();
            this.PREZZO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LISTA = new System.Windows.Forms.ListBox();
            this.ConfermaUpdate = new System.Windows.Forms.Button();
            this.ConfermaDelete = new System.Windows.Forms.Button();
            this.USCITA = new System.Windows.Forms.Button();
            this.ORDINAMENTO = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.PrezzoMin = new System.Windows.Forms.Button();
            this.PrezzoMassimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CREATE
            // 
            this.CREATE.Location = new System.Drawing.Point(284, 140);
            this.CREATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(142, 50);
            this.CREATE.TabIndex = 1;
            this.CREATE.Text = "Create(Aggiungi)";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(284, 325);
            this.DELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(142, 50);
            this.DELETE.TabIndex = 2;
            this.DELETE.Text = "Delete(Cancella)";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(284, 240);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(142, 50);
            this.UPDATE.TabIndex = 3;
            this.UPDATE.Text = "Update(Modifica)";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // NOME
            // 
            this.NOME.Location = new System.Drawing.Point(88, 128);
            this.NOME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(146, 20);
            this.NOME.TabIndex = 5;
            // 
            // PREZZO
            // 
            this.PREZZO.Location = new System.Drawing.Point(88, 189);
            this.PREZZO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PREZZO.Name = "PREZZO";
            this.PREZZO.Size = new System.Drawing.Size(146, 20);
            this.PREZZO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezzo";
            // 
            // LISTA
            // 
            this.LISTA.FormattingEnabled = true;
            this.LISTA.Location = new System.Drawing.Point(462, 88);
            this.LISTA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(313, 368);
            this.LISTA.TabIndex = 9;
            this.LISTA.SelectedIndexChanged += new System.EventHandler(this.LISTA_SelectedIndexChanged);
            // 
            // ConfermaUpdate
            // 
            this.ConfermaUpdate.Location = new System.Drawing.Point(90, 240);
            this.ConfermaUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfermaUpdate.Name = "ConfermaUpdate";
            this.ConfermaUpdate.Size = new System.Drawing.Size(142, 50);
            this.ConfermaUpdate.TabIndex = 10;
            this.ConfermaUpdate.Text = "Conferma Update";
            this.ConfermaUpdate.UseVisualStyleBackColor = true;
            this.ConfermaUpdate.Click += new System.EventHandler(this.ConfermaUpdate_Click);
            // 
            // ConfermaDelete
            // 
            this.ConfermaDelete.Location = new System.Drawing.Point(90, 325);
            this.ConfermaDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfermaDelete.Name = "ConfermaDelete";
            this.ConfermaDelete.Size = new System.Drawing.Size(142, 50);
            this.ConfermaDelete.TabIndex = 11;
            this.ConfermaDelete.Text = "Conferma Delete";
            this.ConfermaDelete.UseVisualStyleBackColor = true;
            this.ConfermaDelete.Click += new System.EventHandler(this.ConfermaDelete_Click);
            // 
            // USCITA
            // 
            this.USCITA.Location = new System.Drawing.Point(284, 432);
            this.USCITA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.USCITA.Name = "USCITA";
            this.USCITA.Size = new System.Drawing.Size(142, 50);
            this.USCITA.TabIndex = 12;
            this.USCITA.Text = "ESCI";
            this.USCITA.UseVisualStyleBackColor = true;
            this.USCITA.Click += new System.EventHandler(this.USCITA_Click);
            // 
            // ORDINAMENTO
            // 
            this.ORDINAMENTO.Location = new System.Drawing.Point(804, 88);
            this.ORDINAMENTO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ORDINAMENTO.Name = "ORDINAMENTO";
            this.ORDINAMENTO.Size = new System.Drawing.Size(142, 50);
            this.ORDINAMENTO.TabIndex = 13;
            this.ORDINAMENTO.Text = "Ordinamento Alfabetico";
            this.ORDINAMENTO.UseVisualStyleBackColor = true;
            this.ORDINAMENTO.Click += new System.EventHandler(this.ORDINAMENTO_Click);
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(804, 159);
            this.Somma.Margin = new System.Windows.Forms.Padding(2);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(142, 50);
            this.Somma.TabIndex = 14;
            this.Somma.Text = "Somma Prezzi";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // PrezzoMin
            // 
            this.PrezzoMin.Location = new System.Drawing.Point(804, 230);
            this.PrezzoMin.Margin = new System.Windows.Forms.Padding(2);
            this.PrezzoMin.Name = "PrezzoMin";
            this.PrezzoMin.Size = new System.Drawing.Size(142, 50);
            this.PrezzoMin.TabIndex = 15;
            this.PrezzoMin.Text = "Prezzo Minimo";
            this.PrezzoMin.UseVisualStyleBackColor = true;
            this.PrezzoMin.Click += new System.EventHandler(this.PrezzoMin_Click);
            // 
            // PrezzoMassimo
            // 
            this.PrezzoMassimo.Location = new System.Drawing.Point(804, 296);
            this.PrezzoMassimo.Margin = new System.Windows.Forms.Padding(2);
            this.PrezzoMassimo.Name = "PrezzoMassimo";
            this.PrezzoMassimo.Size = new System.Drawing.Size(142, 50);
            this.PrezzoMassimo.TabIndex = 16;
            this.PrezzoMassimo.Text = "Prezzo Massimo";
            this.PrezzoMassimo.UseVisualStyleBackColor = true;
            this.PrezzoMassimo.Click += new System.EventHandler(this.PrezzoMassimo_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 569);
            this.Controls.Add(this.PrezzoMassimo);
            this.Controls.Add(this.PrezzoMin);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.ORDINAMENTO);
            this.Controls.Add(this.USCITA);
            this.Controls.Add(this.ConfermaDelete);
            this.Controls.Add(this.ConfermaUpdate);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PREZZO);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.CREATE);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CREATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.TextBox NOME;
        private System.Windows.Forms.TextBox PREZZO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LISTA;
        private System.Windows.Forms.Button ConfermaUpdate;
        private System.Windows.Forms.Button ConfermaDelete;
        private System.Windows.Forms.Button USCITA;
        private System.Windows.Forms.Button ORDINAMENTO;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button PrezzoMin;
        private System.Windows.Forms.Button PrezzoMassimo;
    }
}

