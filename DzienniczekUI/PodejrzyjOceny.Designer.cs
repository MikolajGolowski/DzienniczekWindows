namespace DzienniczekUI
{
    partial class PodejrzyjOceny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodejrzyjOceny));
            this.PodejrzyjOcenyTekst = new System.Windows.Forms.Label();
            this.PrzedmiotComboBox = new System.Windows.Forms.ComboBox();
            this.PrzedmiotTekst = new System.Windows.Forms.Label();
            this.UczenComboBox = new System.Windows.Forms.ComboBox();
            this.UczenTekst = new System.Windows.Forms.Label();
            this.KlasaComboBox = new System.Windows.Forms.ComboBox();
            this.KlasaTekst = new System.Windows.Forms.Label();
            this.OcenyLista = new System.Windows.Forms.ListView();
            this.OkButton = new System.Windows.Forms.Button();
            this.ocena = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.opis = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // PodejrzyjOcenyTekst
            // 
            this.PodejrzyjOcenyTekst.AutoSize = true;
            this.PodejrzyjOcenyTekst.BackColor = System.Drawing.Color.Transparent;
            this.PodejrzyjOcenyTekst.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PodejrzyjOcenyTekst.Location = new System.Drawing.Point(22, 24);
            this.PodejrzyjOcenyTekst.Name = "PodejrzyjOcenyTekst";
            this.PodejrzyjOcenyTekst.Size = new System.Drawing.Size(146, 25);
            this.PodejrzyjOcenyTekst.TabIndex = 0;
            this.PodejrzyjOcenyTekst.Text = "Podejrzyj oceny";
            // 
            // PrzedmiotComboBox
            // 
            this.PrzedmiotComboBox.FormattingEnabled = true;
            this.PrzedmiotComboBox.Location = new System.Drawing.Point(204, 214);
            this.PrzedmiotComboBox.Name = "PrzedmiotComboBox";
            this.PrzedmiotComboBox.Size = new System.Drawing.Size(279, 33);
            this.PrzedmiotComboBox.TabIndex = 2;
            // 
            // PrzedmiotTekst
            // 
            this.PrzedmiotTekst.AutoSize = true;
            this.PrzedmiotTekst.BackColor = System.Drawing.Color.Transparent;
            this.PrzedmiotTekst.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrzedmiotTekst.Location = new System.Drawing.Point(35, 211);
            this.PrzedmiotTekst.Name = "PrzedmiotTekst";
            this.PrzedmiotTekst.Size = new System.Drawing.Size(144, 37);
            this.PrzedmiotTekst.TabIndex = 1;
            this.PrzedmiotTekst.Text = "Przedmiot:";
            // 
            // UczenComboBox
            // 
            this.UczenComboBox.FormattingEnabled = true;
            this.UczenComboBox.Location = new System.Drawing.Point(204, 155);
            this.UczenComboBox.Name = "UczenComboBox";
            this.UczenComboBox.Size = new System.Drawing.Size(279, 33);
            this.UczenComboBox.TabIndex = 2;
            // 
            // UczenTekst
            // 
            this.UczenTekst.AutoSize = true;
            this.UczenTekst.BackColor = System.Drawing.Color.Transparent;
            this.UczenTekst.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UczenTekst.Location = new System.Drawing.Point(84, 152);
            this.UczenTekst.Name = "UczenTekst";
            this.UczenTekst.Size = new System.Drawing.Size(95, 37);
            this.UczenTekst.TabIndex = 1;
            this.UczenTekst.Text = "Uczeń:";
            // 
            // KlasaComboBox
            // 
            this.KlasaComboBox.FormattingEnabled = true;
            this.KlasaComboBox.Location = new System.Drawing.Point(204, 96);
            this.KlasaComboBox.Name = "KlasaComboBox";
            this.KlasaComboBox.Size = new System.Drawing.Size(279, 33);
            this.KlasaComboBox.TabIndex = 2;
            this.KlasaComboBox.SelectedIndexChanged += new System.EventHandler(this.KlasaComboBox_SelectedIndexChanged_1);
            // 
            // KlasaTekst
            // 
            this.KlasaTekst.AutoSize = true;
            this.KlasaTekst.BackColor = System.Drawing.Color.Transparent;
            this.KlasaTekst.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KlasaTekst.Location = new System.Drawing.Point(94, 93);
            this.KlasaTekst.Name = "KlasaTekst";
            this.KlasaTekst.Size = new System.Drawing.Size(85, 37);
            this.KlasaTekst.TabIndex = 1;
            this.KlasaTekst.Text = "Klasa:";
            // 
            // OcenyLista
            // 
            this.OcenyLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ocena,
            this.opis});
            this.OcenyLista.FullRowSelect = true;
            this.OcenyLista.GridLines = true;
            this.OcenyLista.HideSelection = false;
            this.OcenyLista.Location = new System.Drawing.Point(35, 288);
            this.OcenyLista.Name = "OcenyLista";
            this.OcenyLista.Size = new System.Drawing.Size(567, 415);
            this.OcenyLista.TabIndex = 3;
            this.OcenyLista.UseCompatibleStateImageBehavior = false;
            this.OcenyLista.View = System.Windows.Forms.View.Details;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(542, 199);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(73, 60);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ocena
            // 
            this.ocena.Name = "ocena";
            this.ocena.Text = "Ocena";
            this.ocena.Width = 100;
            // 
            // opis
            // 
            this.opis.Name = "opis";
            this.opis.Text = "Opis";
            this.opis.Width = 462;
            // 
            // PodejrzyjOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 727);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.OcenyLista);
            this.Controls.Add(this.KlasaTekst);
            this.Controls.Add(this.KlasaComboBox);
            this.Controls.Add(this.UczenTekst);
            this.Controls.Add(this.UczenComboBox);
            this.Controls.Add(this.PrzedmiotTekst);
            this.Controls.Add(this.PrzedmiotComboBox);
            this.Controls.Add(this.PodejrzyjOcenyTekst);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PodejrzyjOceny";
            this.Text = "Dzienniczek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PodejrzyjOcenyTekst;
        private System.Windows.Forms.ComboBox PrzedmiotComboBox;
        private System.Windows.Forms.Label PrzedmiotTekst;
        private System.Windows.Forms.ComboBox UczenComboBox;
        private System.Windows.Forms.Label UczenTekst;
        private System.Windows.Forms.ComboBox KlasaComboBox;
        private System.Windows.Forms.Label KlasaTekst;
        private System.Windows.Forms.ListView OcenyLista;
        private System.Windows.Forms.ColumnHeader ocena;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}