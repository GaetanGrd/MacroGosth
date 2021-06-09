
namespace PhasmoSelectObjet
{
    partial class Parametre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbrez = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDelay = new System.Windows.Forms.TextBox();
            this.CheckListeObjet = new System.Windows.Forms.CheckedListBox();
            this.txtBoxSelectPlayer = new System.Windows.Forms.ComboBox();
            this.txtBoxScreenRes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveList = new System.Windows.Forms.Button();
            this.j1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbrez
            // 
            this.lbrez.AutoSize = true;
            this.lbrez.Location = new System.Drawing.Point(13, 39);
            this.lbrez.Name = "lbrez";
            this.lbrez.Size = new System.Drawing.Size(111, 15);
            this.lbrez.TabIndex = 1;
            this.lbrez.Text = "Résolution du jeux :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temps entre chaque clic :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Joueur à modifier :";
            // 
            // txtBoxDelay
            // 
            this.txtBoxDelay.Location = new System.Drawing.Point(13, 123);
            this.txtBoxDelay.Name = "txtBoxDelay";
            this.txtBoxDelay.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDelay.TabIndex = 4;
            this.txtBoxDelay.TextChanged += new System.EventHandler(this.txtBoxDelay_TextChanged);
            this.txtBoxDelay.Enter += new System.EventHandler(this.txtBoxDelay_Enter);
            this.txtBoxDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDelay_KeyPress);
            this.txtBoxDelay.Leave += new System.EventHandler(this.txtBoxDelay_Leave);
            // 
            // CheckListeObjet
            // 
            this.CheckListeObjet.FormattingEnabled = true;
            this.CheckListeObjet.Items.AddRange(new object[] {
            "Lecteur EMF",
            "Lampe de poche",
            "Appareil photo",
            "Briquet",
            "Bougie",
            "Lampe UV",
            "Crucifix",
            "Caméra vidéo",
            "Spirit Box",
            "Sel",
            "Bâton d\'encens",
            "Trépied",
            "Lampe de poche puissante",
            "Détecteur de mouvement",
            "Capteur sonore",
            "Thermomètre",
            "Pilules calmantes",
            "Livre d\'écriture fantomatique",
            "Capteur à lumière infrarouge",
            "Microphone Parabolique",
            "Bâton lumineux",
            "Caméra frontale"});
            this.CheckListeObjet.Location = new System.Drawing.Point(298, 12);
            this.CheckListeObjet.Name = "CheckListeObjet";
            this.CheckListeObjet.Size = new System.Drawing.Size(490, 418);
            this.CheckListeObjet.TabIndex = 5;
            // 
            // txtBoxSelectPlayer
            // 
            this.txtBoxSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxSelectPlayer.FormattingEnabled = true;
            this.txtBoxSelectPlayer.Items.AddRange(new object[] {
            "Joueur 1",
            "Joueur 2",
            "Joueur 3",
            "Joueur 4"});
            this.txtBoxSelectPlayer.Location = new System.Drawing.Point(12, 204);
            this.txtBoxSelectPlayer.Name = "txtBoxSelectPlayer";
            this.txtBoxSelectPlayer.Size = new System.Drawing.Size(121, 23);
            this.txtBoxSelectPlayer.TabIndex = 3;
            this.txtBoxSelectPlayer.SelectedIndexChanged += new System.EventHandler(this.txtBoxSelectPlayer_SelectedIndexChanged);
            // 
            // txtBoxScreenRes
            // 
            this.txtBoxScreenRes.Enabled = false;
            this.txtBoxScreenRes.FormattingEnabled = true;
            this.txtBoxScreenRes.Items.AddRange(new object[] {
            "1920 x 1080",
            "1650 x 1050",
            "1600 x 900",
            "1440 x 900",
            "1400 x 1050",
            "1366 x 768",
            "1360 x 768",
            "1280 x 1024",
            "1280 x 960",
            "1280 x 800",
            "1280 x 768",
            "1280 x 720 ",
            "1280 x 600",
            "1152 x 864",
            "1024 x 768",
            "800 x 600",
            "640 x 480",
            "640 x 400",
            "512 x 384",
            "400 x 300",
            "320 x 240",
            "320 x 200"});
            this.txtBoxScreenRes.Location = new System.Drawing.Point(13, 58);
            this.txtBoxScreenRes.Name = "txtBoxScreenRes";
            this.txtBoxScreenRes.Size = new System.Drawing.Size(121, 23);
            this.txtBoxScreenRes.TabIndex = 7;
            this.txtBoxScreenRes.SelectedIndexChanged += new System.EventHandler(this.txtBoxScreenRes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "( 1000 ms = 1sec)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ms";
            // 
            // SaveList
            // 
            this.SaveList.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveList.Location = new System.Drawing.Point(140, 203);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(100, 23);
            this.SaveList.TabIndex = 11;
            this.SaveList.Text = "Sauvegarder la liste";
            this.SaveList.UseVisualStyleBackColor = true;
            this.SaveList.Click += new System.EventHandler(this.SaveList_Click);
            // 
            // j1
            // 
            this.j1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.j1.BackColor = System.Drawing.SystemColors.Control;
            this.j1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.j1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.j1.FlatAppearance.BorderSize = 3;
            this.j1.Font = new System.Drawing.Font("Bradley Hand ITC", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.j1.ForeColor = System.Drawing.Color.Gray;
            this.j1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.j1.Location = new System.Drawing.Point(13, 292);
            this.j1.Name = "j1";
            this.j1.Size = new System.Drawing.Size(262, 76);
            this.j1.TabIndex = 12;
            this.j1.Text = "Valider";
            this.j1.UseVisualStyleBackColor = false;
            this.j1.Click += new System.EventHandler(this.j1_Click);
            // 
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.j1);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxScreenRes);
            this.Controls.Add(this.txtBoxSelectPlayer);
            this.Controls.Add(this.CheckListeObjet);
            this.Controls.Add(this.txtBoxDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbrez);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parametre";
            this.Text = "Parametre";
            this.Load += new System.EventHandler(this.Parametre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbrez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDelay;
        private System.Windows.Forms.CheckedListBox CheckListeObjet;
        private System.Windows.Forms.ComboBox txtBoxSelectPlayer;
        private System.Windows.Forms.ComboBox txtBoxScreenRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.Button j1;
    }
}