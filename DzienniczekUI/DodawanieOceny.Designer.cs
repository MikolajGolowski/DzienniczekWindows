namespace DzienniczekUI
{
    partial class DodawanieOceny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieOceny));
            this.DodawanieOcenyNapis = new System.Windows.Forms.Label();
            this.KlasaNapis = new System.Windows.Forms.Label();
            this.KlasaComboBox = new System.Windows.Forms.ComboBox();
            this.UczenTekst = new System.Windows.Forms.Label();
            this.UczenComboBox = new System.Windows.Forms.ComboBox();
            this.PrzedmiotTekst = new System.Windows.Forms.Label();
            this.PrzedmiotComboBox = new System.Windows.Forms.ComboBox();
            this.OcenaNapis = new System.Windows.Forms.Label();
            this.OcenaComboBox = new System.Windows.Forms.ComboBox();
            this.WagaTekst = new System.Windows.Forms.Label();
            this.WagaComboBox = new System.Windows.Forms.ComboBox();
            this.OpisTekst = new System.Windows.Forms.Label();
            this.OpisTextBox = new System.Windows.Forms.RichTextBox();
            this.DodajOceneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DodawanieOcenyNapis
            // 
            this.DodawanieOcenyNapis.AutoSize = true;
            this.DodawanieOcenyNapis.BackColor = System.Drawing.Color.Transparent;
            this.DodawanieOcenyNapis.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DodawanieOcenyNapis.Location = new System.Drawing.Point(33, 24);
            this.DodawanieOcenyNapis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DodawanieOcenyNapis.Name = "DodawanieOcenyNapis";
            this.DodawanieOcenyNapis.Size = new System.Drawing.Size(278, 45);
            this.DodawanieOcenyNapis.TabIndex = 0;
            this.DodawanieOcenyNapis.Text = "Dodawanie oceny";
            // 
            // KlasaNapis
            // 
            this.KlasaNapis.AutoSize = true;
            this.KlasaNapis.BackColor = System.Drawing.Color.Transparent;
            this.KlasaNapis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KlasaNapis.Location = new System.Drawing.Point(71, 113);
            this.KlasaNapis.Name = "KlasaNapis";
            this.KlasaNapis.Size = new System.Drawing.Size(85, 37);
            this.KlasaNapis.TabIndex = 1;
            this.KlasaNapis.Text = "Klasa:";
            // 
            // KlasaComboBox
            // 
            this.KlasaComboBox.FormattingEnabled = true;
            this.KlasaComboBox.Location = new System.Drawing.Point(181, 116);
            this.KlasaComboBox.Name = "KlasaComboBox";
            this.KlasaComboBox.Size = new System.Drawing.Size(279, 38);
            this.KlasaComboBox.TabIndex = 2;
            this.KlasaComboBox.SelectedIndexChanged += new System.EventHandler(this.KlasaComboBox_SelectedIndexChanged);
            // 
            // UczenTekst
            // 
            this.UczenTekst.AutoSize = true;
            this.UczenTekst.BackColor = System.Drawing.Color.Transparent;
            this.UczenTekst.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UczenTekst.Location = new System.Drawing.Point(61, 172);
            this.UczenTekst.Name = "UczenTekst";
            this.UczenTekst.Size = new System.Drawing.Size(95, 37);
            this.UczenTekst.TabIndex = 1;
            this.UczenTekst.Text = "Uczeń:";
            // 
            // UczenComboBox
            // 
            this.UczenComboBox.FormattingEnabled = true;
            this.UczenComboBox.Location = new System.Drawing.Point(181, 175);
            this.UczenComboBox.Name = "UczenComboBox";
            this.UczenComboBox.Size = new System.Drawing.Size(279, 38);
            this.UczenComboBox.TabIndex = 2;
            this.UczenComboBox.SelectedIndexChanged += new System.EventHandler(this.UczenComboBox_SelectedIndexChanged);
            // 
            // PrzedmiotTekst
            // 
            this.PrzedmiotTekst.AutoSize = true;
            this.PrzedmiotTekst.BackColor = System.Drawing.Color.Transparent;
            this.PrzedmiotTekst.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrzedmiotTekst.Location = new System.Drawing.Point(12, 231);
            this.PrzedmiotTekst.Name = "PrzedmiotTekst";
            this.PrzedmiotTekst.Size = new System.Drawing.Size(144, 37);
            this.PrzedmiotTekst.TabIndex = 1;
            this.PrzedmiotTekst.Text = "Przedmiot:";
            // 
            // PrzedmiotComboBox
            // 
            this.PrzedmiotComboBox.FormattingEnabled = true;
            this.PrzedmiotComboBox.Location = new System.Drawing.Point(181, 234);
            this.PrzedmiotComboBox.Name = "PrzedmiotComboBox";
            this.PrzedmiotComboBox.Size = new System.Drawing.Size(279, 38);
            this.PrzedmiotComboBox.TabIndex = 2;
            // 
            // OcenaNapis
            // 
            this.OcenaNapis.AutoSize = true;
            this.OcenaNapis.BackColor = System.Drawing.Color.Transparent;
            this.OcenaNapis.Location = new System.Drawing.Point(57, 316);
            this.OcenaNapis.Name = "OcenaNapis";
            this.OcenaNapis.Size = new System.Drawing.Size(78, 30);
            this.OcenaNapis.TabIndex = 3;
            this.OcenaNapis.Text = "Ocena:";
            // 
            // OcenaComboBox
            // 
            this.OcenaComboBox.FormattingEnabled = true;
            this.OcenaComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OcenaComboBox.Location = new System.Drawing.Point(141, 313);
            this.OcenaComboBox.Name = "OcenaComboBox";
            this.OcenaComboBox.Size = new System.Drawing.Size(48, 38);
            this.OcenaComboBox.TabIndex = 4;
            // 
            // WagaTekst
            // 
            this.WagaTekst.AutoSize = true;
            this.WagaTekst.BackColor = System.Drawing.Color.Transparent;
            this.WagaTekst.Location = new System.Drawing.Point(247, 316);
            this.WagaTekst.Name = "WagaTekst";
            this.WagaTekst.Size = new System.Drawing.Size(71, 30);
            this.WagaTekst.TabIndex = 3;
            this.WagaTekst.Text = "Waga:";
            // 
            // WagaComboBox
            // 
            this.WagaComboBox.FormattingEnabled = true;
            this.WagaComboBox.Location = new System.Drawing.Point(331, 313);
            this.WagaComboBox.Name = "WagaComboBox";
            this.WagaComboBox.Size = new System.Drawing.Size(48, 38);
            this.WagaComboBox.TabIndex = 4;
            // 
            // OpisTekst
            // 
            this.OpisTekst.AutoSize = true;
            this.OpisTekst.BackColor = System.Drawing.Color.Transparent;
            this.OpisTekst.Location = new System.Drawing.Point(40, 384);
            this.OpisTekst.Name = "OpisTekst";
            this.OpisTekst.Size = new System.Drawing.Size(60, 30);
            this.OpisTekst.TabIndex = 3;
            this.OpisTekst.Text = "Opis:";
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(117, 384);
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(276, 228);
            this.OpisTextBox.TabIndex = 5;
            this.OpisTextBox.Text = "";
            this.OpisTextBox.TextChanged += new System.EventHandler(this.OpisTextBox_TextChanged);
            // 
            // DodajOceneButton
            // 
            this.DodajOceneButton.BackColor = System.Drawing.Color.White;
            this.DodajOceneButton.Location = new System.Drawing.Point(452, 417);
            this.DodajOceneButton.Name = "DodajOceneButton";
            this.DodajOceneButton.Size = new System.Drawing.Size(108, 105);
            this.DodajOceneButton.TabIndex = 6;
            this.DodajOceneButton.Text = "Dodaj ocenę";
            this.DodajOceneButton.UseVisualStyleBackColor = false;
            this.DodajOceneButton.Click += new System.EventHandler(this.DodajOceneButton_Click);
            // 
            // DodawanieOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 648);
            this.Controls.Add(this.DodajOceneButton);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.OpisTekst);
            this.Controls.Add(this.WagaComboBox);
            this.Controls.Add(this.WagaTekst);
            this.Controls.Add(this.OcenaComboBox);
            this.Controls.Add(this.OcenaNapis);
            this.Controls.Add(this.PrzedmiotComboBox);
            this.Controls.Add(this.PrzedmiotTekst);
            this.Controls.Add(this.UczenComboBox);
            this.Controls.Add(this.UczenTekst);
            this.Controls.Add(this.KlasaComboBox);
            this.Controls.Add(this.KlasaNapis);
            this.Controls.Add(this.DodawanieOcenyNapis);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DodawanieOceny";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DodawanieOceny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DodawanieOcenyNapis;
        private System.Windows.Forms.Label KlasaNapis;
        private System.Windows.Forms.ComboBox KlasaComboBox;
        private System.Windows.Forms.Label UczenTekst;
        private System.Windows.Forms.ComboBox UczenComboBox;
        private System.Windows.Forms.Label PrzedmiotTekst;
        private System.Windows.Forms.ComboBox PrzedmiotComboBox;
        private System.Windows.Forms.Label OcenaNapis;
        private System.Windows.Forms.ComboBox OcenaComboBox;
        private System.Windows.Forms.Label WagaTekst;
        private System.Windows.Forms.ComboBox WagaComboBox;
        private System.Windows.Forms.Label OpisTekst;
        private System.Windows.Forms.RichTextBox OpisTextBox;
        private System.Windows.Forms.Button DodajOceneButton;
    }
}