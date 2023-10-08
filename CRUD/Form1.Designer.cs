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
            this.Ordinamento = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.PrezzoMin = new System.Windows.Forms.Button();
            this.PrezzoMassimo = new System.Windows.Forms.Button();
            this.Salva = new System.Windows.Forms.Button();
            this.Leggi = new System.Windows.Forms.Button();
            this.SommaPercentuale = new System.Windows.Forms.Button();
            this.SottraiPercentuale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CREATE
            // 
            this.CREATE.Location = new System.Drawing.Point(379, 172);
            this.CREATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(189, 62);
            this.CREATE.TabIndex = 1;
            this.CREATE.Text = "Create(Aggiungi)";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(379, 400);
            this.DELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(189, 62);
            this.DELETE.TabIndex = 2;
            this.DELETE.Text = "Delete(Cancella)";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(379, 295);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(189, 62);
            this.UPDATE.TabIndex = 3;
            this.UPDATE.Text = "Update(Modifica)";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // NOME
            // 
            this.NOME.Location = new System.Drawing.Point(117, 158);
            this.NOME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(193, 22);
            this.NOME.TabIndex = 5;
            // 
            // PREZZO
            // 
            this.PREZZO.Location = new System.Drawing.Point(117, 233);
            this.PREZZO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PREZZO.Name = "PREZZO";
            this.PREZZO.Size = new System.Drawing.Size(193, 22);
            this.PREZZO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezzo";
            // 
            // LISTA
            // 
            this.LISTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTA.FormattingEnabled = true;
            this.LISTA.ItemHeight = 31;
            this.LISTA.Location = new System.Drawing.Point(616, 108);
            this.LISTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(416, 438);
            this.LISTA.TabIndex = 9;
            this.LISTA.SelectedIndexChanged += new System.EventHandler(this.LISTA_SelectedIndexChanged);
            // 
            // ConfermaUpdate
            // 
            this.ConfermaUpdate.Location = new System.Drawing.Point(120, 295);
            this.ConfermaUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfermaUpdate.Name = "ConfermaUpdate";
            this.ConfermaUpdate.Size = new System.Drawing.Size(189, 62);
            this.ConfermaUpdate.TabIndex = 10;
            this.ConfermaUpdate.Text = "Conferma Update";
            this.ConfermaUpdate.UseVisualStyleBackColor = true;
            this.ConfermaUpdate.Click += new System.EventHandler(this.ConfermaUpdate_Click);
            // 
            // ConfermaDelete
            // 
            this.ConfermaDelete.Location = new System.Drawing.Point(120, 400);
            this.ConfermaDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfermaDelete.Name = "ConfermaDelete";
            this.ConfermaDelete.Size = new System.Drawing.Size(189, 62);
            this.ConfermaDelete.TabIndex = 11;
            this.ConfermaDelete.Text = "Conferma Delete";
            this.ConfermaDelete.UseVisualStyleBackColor = true;
            this.ConfermaDelete.Click += new System.EventHandler(this.ConfermaDelete_Click);
            // 
            // USCITA
            // 
            this.USCITA.Location = new System.Drawing.Point(379, 532);
            this.USCITA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.USCITA.Name = "USCITA";
            this.USCITA.Size = new System.Drawing.Size(189, 62);
            this.USCITA.TabIndex = 12;
            this.USCITA.Text = "ESCI";
            this.USCITA.UseVisualStyleBackColor = true;
            this.USCITA.Click += new System.EventHandler(this.USCITA_Click);
            // 
            // Ordinamento
            // 
            this.Ordinamento.Location = new System.Drawing.Point(1072, 108);
            this.Ordinamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ordinamento.Name = "Ordinamento";
            this.Ordinamento.Size = new System.Drawing.Size(189, 62);
            this.Ordinamento.TabIndex = 13;
            this.Ordinamento.Text = "Ordinamento Alfabetico";
            this.Ordinamento.UseVisualStyleBackColor = true;
            this.Ordinamento.Click += new System.EventHandler(this.ORDINAMENTO_Click);
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(1072, 213);
            this.Somma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(189, 62);
            this.Somma.TabIndex = 14;
            this.Somma.Text = "Somma Prezzi";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // PrezzoMin
            // 
            this.PrezzoMin.Location = new System.Drawing.Point(1072, 306);
            this.PrezzoMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrezzoMin.Name = "PrezzoMin";
            this.PrezzoMin.Size = new System.Drawing.Size(189, 62);
            this.PrezzoMin.TabIndex = 15;
            this.PrezzoMin.Text = "Prezzo Minimo";
            this.PrezzoMin.UseVisualStyleBackColor = true;
            this.PrezzoMin.Click += new System.EventHandler(this.PrezzoMin_Click);
            // 
            // PrezzoMassimo
            // 
            this.PrezzoMassimo.Location = new System.Drawing.Point(1072, 400);
            this.PrezzoMassimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrezzoMassimo.Name = "PrezzoMassimo";
            this.PrezzoMassimo.Size = new System.Drawing.Size(189, 62);
            this.PrezzoMassimo.TabIndex = 16;
            this.PrezzoMassimo.Text = "Prezzo Massimo";
            this.PrezzoMassimo.UseVisualStyleBackColor = true;
            this.PrezzoMassimo.Click += new System.EventHandler(this.PrezzoMassimo_Click);
            // 
            // Salva
            // 
            this.Salva.Location = new System.Drawing.Point(1072, 500);
            this.Salva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(189, 62);
            this.Salva.TabIndex = 17;
            this.Salva.Text = "Salva su File";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // Leggi
            // 
            this.Leggi.Location = new System.Drawing.Point(723, 588);
            this.Leggi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Leggi.Name = "Leggi";
            this.Leggi.Size = new System.Drawing.Size(189, 62);
            this.Leggi.TabIndex = 18;
            this.Leggi.Text = "Leggi da File";
            this.Leggi.UseVisualStyleBackColor = true;
            this.Leggi.Click += new System.EventHandler(this.Leggi_Click);
            // 
            // SommaPercentuale
            // 
            this.SommaPercentuale.Location = new System.Drawing.Point(1325, 257);
            this.SommaPercentuale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SommaPercentuale.Name = "SommaPercentuale";
            this.SommaPercentuale.Size = new System.Drawing.Size(189, 62);
            this.SommaPercentuale.TabIndex = 19;
            this.SommaPercentuale.Text = "Somma Percentuale";
            this.SommaPercentuale.UseVisualStyleBackColor = true;
            this.SommaPercentuale.Click += new System.EventHandler(this.SommaPercentuale_Click);
            // 
            // SottraiPercentuale
            // 
            this.SottraiPercentuale.Location = new System.Drawing.Point(1325, 364);
            this.SottraiPercentuale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SottraiPercentuale.Name = "SottraiPercentuale";
            this.SottraiPercentuale.Size = new System.Drawing.Size(189, 62);
            this.SottraiPercentuale.TabIndex = 20;
            this.SottraiPercentuale.Text = "Sottrai Percentuale";
            this.SottraiPercentuale.UseVisualStyleBackColor = true;
            this.SottraiPercentuale.Click += new System.EventHandler(this.SottraiPercentuale_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 795);
            this.Controls.Add(this.SottraiPercentuale);
            this.Controls.Add(this.SommaPercentuale);
            this.Controls.Add(this.Leggi);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.PrezzoMassimo);
            this.Controls.Add(this.PrezzoMin);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.Ordinamento);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button Ordinamento;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button PrezzoMin;
        private System.Windows.Forms.Button PrezzoMassimo;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button Leggi;
        private System.Windows.Forms.Button SommaPercentuale;
        private System.Windows.Forms.Button SottraiPercentuale;
    }
}

