namespace DzienniczekUI
{
    partial class KreatorKlas
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreatorKlas));
            this.label1 = new System.Windows.Forms.Label();
            this.RokComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NazwaKlasyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UczniowieListView = new System.Windows.Forms.ListView();
            this.nazwiskoimie = new System.Windows.Forms.ColumnHeader();
            this.pesel = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.UczenNazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UczenImieTextBox = new System.Windows.Forms.TextBox();
            this.UczenComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UczenDoKlasyButton = new System.Windows.Forms.Button();
            this.UczenPeselTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UczenNowyButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PrzedmiotNowyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PrzedmiotNazwaTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PrzedmiotNauczycielTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PrzedmiotComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PrzedmiotDoKlasyButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.AnulujButton = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.nazwa = new System.Windows.Forms.ColumnHeader();
            this.nauczyciel = new System.Windows.Forms.ColumnHeader();
            this.PrzedmiotyListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa klasy:";
            // 
            // RokComboBox
            // 
            this.RokComboBox.FormattingEnabled = true;
            this.RokComboBox.Location = new System.Drawing.Point(95, 22);
            this.RokComboBox.Name = "RokComboBox";
            this.RokComboBox.Size = new System.Drawing.Size(93, 45);
            this.RokComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rok:";
            // 
            // NazwaKlasyTextBox
            // 
            this.NazwaKlasyTextBox.Location = new System.Drawing.Point(389, 22);
            this.NazwaKlasyTextBox.Name = "NazwaKlasyTextBox";
            this.NazwaKlasyTextBox.Size = new System.Drawing.Size(232, 43);
            this.NazwaKlasyTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Uczniowie:";
            // 
            // UczniowieListView
            // 
            this.UczniowieListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nazwiskoimie,
            this.pesel});
            this.UczniowieListView.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UczniowieListView.FullRowSelect = true;
            this.UczniowieListView.GridLines = true;
            this.UczniowieListView.HideSelection = false;
            this.UczniowieListView.Location = new System.Drawing.Point(12, 173);
            this.UczniowieListView.Name = "UczniowieListView";
            this.UczniowieListView.Size = new System.Drawing.Size(500, 695);
            this.UczniowieListView.TabIndex = 4;
            this.UczniowieListView.UseCompatibleStateImageBehavior = false;
            this.UczniowieListView.View = System.Windows.Forms.View.Details;
            // 
            // nazwiskoimie
            // 
            this.nazwiskoimie.Name = "nazwiskoimie";
            this.nazwiskoimie.Text = "Imie i nazwisko";
            this.nazwiskoimie.Width = 280;
            // 
            // pesel
            // 
            this.pesel.Name = "pesel";
            this.pesel.Text = "PESEL";
            this.pesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pesel.Width = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(528, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nazwisko:";
            // 
            // UczenNazwiskoTextBox
            // 
            this.UczenNazwiskoTextBox.Location = new System.Drawing.Point(702, 532);
            this.UczenNazwiskoTextBox.Name = "UczenNazwiskoTextBox";
            this.UczenNazwiskoTextBox.Size = new System.Drawing.Size(348, 43);
            this.UczenNazwiskoTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(528, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Imię:";
            // 
            // UczenImieTextBox
            // 
            this.UczenImieTextBox.Location = new System.Drawing.Point(702, 486);
            this.UczenImieTextBox.Name = "UczenImieTextBox";
            this.UczenImieTextBox.Size = new System.Drawing.Size(348, 43);
            this.UczenImieTextBox.TabIndex = 3;
            // 
            // UczenComboBox
            // 
            this.UczenComboBox.FormattingEnabled = true;
            this.UczenComboBox.Location = new System.Drawing.Point(537, 180);
            this.UczenComboBox.Name = "UczenComboBox";
            this.UczenComboBox.Size = new System.Drawing.Size(513, 45);
            this.UczenComboBox.TabIndex = 2;
            this.UczenComboBox.SelectedIndexChanged += new System.EventHandler(this.UczenComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(528, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(534, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Wybierz ucznia z listy by dodać go do klasy:";
            // 
            // UczenDoKlasyButton
            // 
            this.UczenDoKlasyButton.Location = new System.Drawing.Point(537, 232);
            this.UczenDoKlasyButton.Name = "UczenDoKlasyButton";
            this.UczenDoKlasyButton.Size = new System.Drawing.Size(513, 47);
            this.UczenDoKlasyButton.TabIndex = 5;
            this.UczenDoKlasyButton.Text = "Dodaj";
            this.UczenDoKlasyButton.UseVisualStyleBackColor = true;
            this.UczenDoKlasyButton.Click += new System.EventHandler(this.UczenDoKlasyButton_Click);
            // 
            // UczenPeselTextBox
            // 
            this.UczenPeselTextBox.Location = new System.Drawing.Point(702, 578);
            this.UczenPeselTextBox.Name = "UczenPeselTextBox";
            this.UczenPeselTextBox.Size = new System.Drawing.Size(348, 43);
            this.UczenPeselTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(528, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pesel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(664, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "Stwórz nowego ucznia:";
            // 
            // UczenNowyButton
            // 
            this.UczenNowyButton.Location = new System.Drawing.Point(537, 627);
            this.UczenNowyButton.Name = "UczenNowyButton";
            this.UczenNowyButton.Size = new System.Drawing.Size(513, 47);
            this.UczenNowyButton.TabIndex = 5;
            this.UczenNowyButton.Text = "Dodaj";
            this.UczenNowyButton.UseVisualStyleBackColor = true;
            this.UczenNowyButton.Click += new System.EventHandler(this.UczenNowyButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1402, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 37);
            this.label10.TabIndex = 1;
            this.label10.Text = "Przedmioty:";
            // 
            // PrzedmiotNowyButton
            // 
            this.PrzedmiotNowyButton.Location = new System.Drawing.Point(537, 819);
            this.PrzedmiotNowyButton.Name = "PrzedmiotNowyButton";
            this.PrzedmiotNowyButton.Size = new System.Drawing.Size(513, 47);
            this.PrzedmiotNowyButton.TabIndex = 5;
            this.PrzedmiotNowyButton.Text = "Dodaj";
            this.PrzedmiotNowyButton.UseVisualStyleBackColor = true;
            this.PrzedmiotNowyButton.Click += new System.EventHandler(this.PrzedmiotNowyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(664, 681);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stwórz nowy przedmiot:";
            // 
            // PrzedmiotNazwaTextBox
            // 
            this.PrzedmiotNazwaTextBox.Location = new System.Drawing.Point(702, 721);
            this.PrzedmiotNazwaTextBox.Name = "PrzedmiotNazwaTextBox";
            this.PrzedmiotNazwaTextBox.Size = new System.Drawing.Size(348, 43);
            this.PrzedmiotNazwaTextBox.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(528, 724);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 37);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nazwa:";
            // 
            // PrzedmiotNauczycielTextBox
            // 
            this.PrzedmiotNauczycielTextBox.Location = new System.Drawing.Point(702, 767);
            this.PrzedmiotNauczycielTextBox.Name = "PrzedmiotNauczycielTextBox";
            this.PrzedmiotNauczycielTextBox.Size = new System.Drawing.Size(348, 43);
            this.PrzedmiotNauczycielTextBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(528, 771);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 37);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nauczyciel:";
            // 
            // PrzedmiotComboBox
            // 
            this.PrzedmiotComboBox.FormattingEnabled = true;
            this.PrzedmiotComboBox.Location = new System.Drawing.Point(537, 320);
            this.PrzedmiotComboBox.Name = "PrzedmiotComboBox";
            this.PrzedmiotComboBox.Size = new System.Drawing.Size(513, 45);
            this.PrzedmiotComboBox.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(528, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(527, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "Wybierz przedmiot z listy by przypisać go klasie:";
            // 
            // PrzedmiotDoKlasyButton
            // 
            this.PrzedmiotDoKlasyButton.Location = new System.Drawing.Point(537, 371);
            this.PrzedmiotDoKlasyButton.Name = "PrzedmiotDoKlasyButton";
            this.PrzedmiotDoKlasyButton.Size = new System.Drawing.Size(513, 47);
            this.PrzedmiotDoKlasyButton.TabIndex = 5;
            this.PrzedmiotDoKlasyButton.Text = "Dodaj";
            this.PrzedmiotDoKlasyButton.UseVisualStyleBackColor = true;
            this.PrzedmiotDoKlasyButton.Click += new System.EventHandler(this.PrzedmiotDoKlasyButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(1495, 11);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 64);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AnulujButton
            // 
            this.AnulujButton.Location = new System.Drawing.Point(1369, 11);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(112, 64);
            this.AnulujButton.TabIndex = 6;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // nazwa
            // 
            this.nazwa.Name = "nazwa";
            this.nazwa.Text = "Nazwa";
            this.nazwa.Width = 250;
            // 
            // nauczyciel
            // 
            this.nauczyciel.Name = "nauczyciel";
            this.nauczyciel.Text = "Nauczyciel";
            this.nauczyciel.Width = 250;
            // 
            // PrzedmiotyListView
            // 
            this.PrzedmiotyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nazwa,
            this.nauczyciel});
            this.PrzedmiotyListView.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrzedmiotyListView.FullRowSelect = true;
            this.PrzedmiotyListView.GridLines = true;
            this.PrzedmiotyListView.HideSelection = false;
            this.PrzedmiotyListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.PrzedmiotyListView.Location = new System.Drawing.Point(1070, 173);
            this.PrzedmiotyListView.Name = "PrzedmiotyListView";
            this.PrzedmiotyListView.Size = new System.Drawing.Size(500, 695);
            this.PrzedmiotyListView.TabIndex = 4;
            this.PrzedmiotyListView.UseCompatibleStateImageBehavior = false;
            this.PrzedmiotyListView.View = System.Windows.Forms.View.Details;
            // 
            // KreatorKlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 905);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PrzedmiotDoKlasyButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PrzedmiotComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PrzedmiotNauczycielTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PrzedmiotNazwaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrzedmiotNowyButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PrzedmiotyListView);
            this.Controls.Add(this.UczenNowyButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UczenPeselTextBox);
            this.Controls.Add(this.UczenDoKlasyButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UczenComboBox);
            this.Controls.Add(this.UczenImieTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UczenNazwiskoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UczniowieListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NazwaKlasyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RokComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "KreatorKlas";
            this.Text = "Dzienniczek - kreator klas";
            this.Load += new System.EventHandler(this.KreatorKlas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RokComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NazwaKlasyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView UczniowieListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UczenNazwiskoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UczenImieTextBox;
        private System.Windows.Forms.ComboBox UczenComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UczenDoKlasyButton;
        private System.Windows.Forms.TextBox UczenPeselTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button UczenNowyButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button PrzedmiotNowyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PrzedmiotNazwaTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PrzedmiotNauczycielTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox PrzedmiotComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button PrzedmiotDoKlasyButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.ColumnHeader nazwiskoimie;
        private System.Windows.Forms.ColumnHeader pesel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader nazwa;
        private System.Windows.Forms.ColumnHeader nauczyciel;
        private System.Windows.Forms.ListView PrzedmiotyListView;
    }
}