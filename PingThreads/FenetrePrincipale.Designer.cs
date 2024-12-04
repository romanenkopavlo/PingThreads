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
            label1.Location = new Point(65, 76);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Adresse";
            // 
            // textAdresse
            // 
            textAdresse.Location = new Point(158, 72);
            textAdresse.Margin = new Padding(3, 4, 3, 4);
            textAdresse.Name = "textAdresse";
            textAdresse.Size = new Size(114, 27);
            textAdresse.TabIndex = 1;
            // 
            // buttonPing
            // 
            buttonPing.Location = new Point(328, 109);
            buttonPing.Margin = new Padding(3, 4, 3, 4);
            buttonPing.Name = "buttonPing";
            buttonPing.Size = new Size(86, 31);
            buttonPing.TabIndex = 2;
            buttonPing.Text = "Ping";
            buttonPing.UseVisualStyleBackColor = true;
            buttonPing.Click += buttonPing_Click;
            // 
            // textQuantite
            // 
            textQuantite.AutoSize = true;
            textQuantite.Location = new Point(65, 145);
            textQuantite.Name = "textQuantite";
            textQuantite.Size = new Size(64, 20);
            textQuantite.TabIndex = 4;
            textQuantite.Text = "Nombre";
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(158, 135);
            textBoxQuantite.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(45, 27);
            textBoxQuantite.TabIndex = 5;
            // 
            // tableauResultats
            // 
            tableauResultats.Columns.AddRange(new ColumnHeader[] { adresse, temps });
            tableauResultats.FullRowSelect = true;
            tableauResultats.GridLines = true;
            tableauResultats.Location = new Point(65, 241);
            tableauResultats.Margin = new Padding(3, 4, 3, 4);
            tableauResultats.MultiSelect = false;
            tableauResultats.Name = "tableauResultats";
            tableauResultats.Size = new Size(555, 191);
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
            temps.Width = 300;
            // 
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 480);
            Controls.Add(tableauResultats);
            Controls.Add(textBoxQuantite);
            Controls.Add(textQuantite);
            Controls.Add(buttonPing);
            Controls.Add(textAdresse);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
