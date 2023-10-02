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
            this.SuspendLayout();
            // 
            // CREATE
            // 
            this.CREATE.Location = new System.Drawing.Point(379, 172);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(190, 61);
            this.CREATE.TabIndex = 1;
            this.CREATE.Text = "Create(Aggiungi)";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(379, 400);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(190, 61);
            this.DELETE.TabIndex = 2;
            this.DELETE.Text = "Delete(Cancella)";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(379, 296);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(190, 61);
            this.UPDATE.TabIndex = 3;
            this.UPDATE.Text = "Update(Modifica)";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // NOME
            // 
            this.NOME.Location = new System.Drawing.Point(117, 157);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(193, 22);
            this.NOME.TabIndex = 5;
            // 
            // PREZZO
            // 
            this.PREZZO.Location = new System.Drawing.Point(117, 233);
            this.PREZZO.Name = "PREZZO";
            this.PREZZO.Size = new System.Drawing.Size(193, 22);
            this.PREZZO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezzo";
            // 
            // LISTA
            // 
            this.LISTA.FormattingEnabled = true;
            this.LISTA.ItemHeight = 16;
            this.LISTA.Location = new System.Drawing.Point(616, 108);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(416, 452);
            this.LISTA.TabIndex = 9;
            this.LISTA.SelectedIndexChanged += new System.EventHandler(this.LISTA_SelectedIndexChanged);
            // 
            // ConfermaUpdate
            // 
            this.ConfermaUpdate.Location = new System.Drawing.Point(120, 296);
            this.ConfermaUpdate.Name = "ConfermaUpdate";
            this.ConfermaUpdate.Size = new System.Drawing.Size(190, 61);
            this.ConfermaUpdate.TabIndex = 10;
            this.ConfermaUpdate.Text = "Conferma Update";
            this.ConfermaUpdate.UseVisualStyleBackColor = true;
            this.ConfermaUpdate.Click += new System.EventHandler(this.ConfermaUpdate_Click);
            // 
            // ConfermaDelete
            // 
            this.ConfermaDelete.Location = new System.Drawing.Point(120, 400);
            this.ConfermaDelete.Name = "ConfermaDelete";
            this.ConfermaDelete.Size = new System.Drawing.Size(190, 61);
            this.ConfermaDelete.TabIndex = 11;
            this.ConfermaDelete.Text = "Conferma Delete";
            this.ConfermaDelete.UseVisualStyleBackColor = true;
            this.ConfermaDelete.Click += new System.EventHandler(this.ConfermaDelete_Click);
            // 
            // USCITA
            // 
            this.USCITA.Location = new System.Drawing.Point(379, 532);
            this.USCITA.Name = "USCITA";
            this.USCITA.Size = new System.Drawing.Size(190, 61);
            this.USCITA.TabIndex = 12;
            this.USCITA.Text = "ESCI";
            this.USCITA.UseVisualStyleBackColor = true;
            this.USCITA.Click += new System.EventHandler(this.USCITA_Click);
            // 
            // ORDINAMENTO
            // 
            this.ORDINAMENTO.Location = new System.Drawing.Point(1072, 108);
            this.ORDINAMENTO.Name = "ORDINAMENTO";
            this.ORDINAMENTO.Size = new System.Drawing.Size(190, 61);
            this.ORDINAMENTO.TabIndex = 13;
            this.ORDINAMENTO.Text = "Ordinamento Alfabetico";
            this.ORDINAMENTO.UseVisualStyleBackColor = true;
            this.ORDINAMENTO.Click += new System.EventHandler(this.ORDINAMENTO_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 700);
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
    }
}

