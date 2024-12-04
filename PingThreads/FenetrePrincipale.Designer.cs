namespace PingThreads
{
    partial class FenetrePrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textAdresse = new TextBox();
            buttonPing = new Button();
            textQuantite = new Label();
            textBoxQuantite = new TextBox();
            tableauResultats = new ListView();
            adresse = new ColumnHeader();
            temps = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 57);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Adresse";
            // 
            // textAdresse
            // 
            textAdresse.Location = new Point(138, 54);
            textAdresse.Name = "textAdresse";
            textAdresse.Size = new Size(100, 23);
            textAdresse.TabIndex = 1;
            // 
            // buttonPing
            // 
            buttonPing.Location = new Point(287, 82);
            buttonPing.Name = "buttonPing";
            buttonPing.Size = new Size(75, 23);
            buttonPing.TabIndex = 2;
            buttonPing.Text = "Ping";
            buttonPing.UseVisualStyleBackColor = true;
            buttonPing.Click += buttonPing_Click;
            // 
            // textQuantite
            // 
            textQuantite.AutoSize = true;
            textQuantite.Location = new Point(57, 109);
            textQuantite.Name = "textQuantite";
            textQuantite.Size = new Size(53, 15);
            textQuantite.TabIndex = 4;
            textQuantite.Text = "Quantité";
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(138, 101);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(40, 23);
            textBoxQuantite.TabIndex = 5;
            // 
            // tableauResultats
            // 
            tableauResultats.Columns.AddRange(new ColumnHeader[] { adresse, temps });
            tableauResultats.FullRowSelect = true;
            tableauResultats.GridLines = true;
            tableauResultats.Location = new Point(57, 181);
            tableauResultats.MultiSelect = false;
            tableauResultats.Name = "tableauResultats";
            tableauResultats.Size = new Size(419, 144);
            tableauResultats.TabIndex = 6;
            tableauResultats.UseCompatibleStateImageBehavior = false;
            tableauResultats.View = View.Details;
            // 
            // adresse
            // 
            adresse.Text = "Adresse";
            adresse.Width = 250;
            // 
            // temps
            // 
            temps.Text = "Temps de reponse";
            temps.Width = 250;
            // 
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 360);
            Controls.Add(tableauResultats);
            Controls.Add(textBoxQuantite);
            Controls.Add(textQuantite);
            Controls.Add(buttonPing);
            Controls.Add(textAdresse);
            Controls.Add(label1);
            Name = "FenetrePrincipale";
            Text = "Ping";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textAdresse;
        private Button buttonPing;
        private Label textQuantite;
        private TextBox textBoxQuantite;
        private ListView tableauResultats;
        public ColumnHeader adresse;
        public ColumnHeader temps;
    }
}
