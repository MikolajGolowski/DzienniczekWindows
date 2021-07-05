namespace DzienniczekUI
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.TekstPowitalny = new System.Windows.Forms.Label();
            this.DodajOcenePrzycisk = new System.Windows.Forms.Button();
            this.PodejrzyjOcenyPrzycisk = new System.Windows.Forms.Button();
            this.KreatorKlasPrzycisk = new System.Windows.Forms.Button();
            this.WyjsciePrzycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TekstPowitalny
            // 
            this.TekstPowitalny.AutoSize = true;
            this.TekstPowitalny.BackColor = System.Drawing.Color.Transparent;
            this.TekstPowitalny.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TekstPowitalny.Location = new System.Drawing.Point(34, 29);
            this.TekstPowitalny.Name = "TekstPowitalny";
            this.TekstPowitalny.Size = new System.Drawing.Size(272, 43);
            this.TekstPowitalny.TabIndex = 0;
            this.TekstPowitalny.Text = "Witaj w Dzienniczku!";
            this.TekstPowitalny.UseCompatibleTextRendering = true;
            // 
            // DodajOcenePrzycisk
            // 
            this.DodajOcenePrzycisk.BackColor = System.Drawing.Color.White;
            this.DodajOcenePrzycisk.Location = new System.Drawing.Point(77, 105);
            this.DodajOcenePrzycisk.Name = "DodajOcenePrzycisk";
            this.DodajOcenePrzycisk.Size = new System.Drawing.Size(229, 49);
            this.DodajOcenePrzycisk.TabIndex = 1;
            this.DodajOcenePrzycisk.Text = "Dodaj ocenę";
            this.DodajOcenePrzycisk.UseVisualStyleBackColor = false;
            this.DodajOcenePrzycisk.Click += new System.EventHandler(this.DodajOcenePrzycisk_Click);
            // 
            // PodejrzyjOcenyPrzycisk
            // 
            this.PodejrzyjOcenyPrzycisk.BackColor = System.Drawing.Color.White;
            this.PodejrzyjOcenyPrzycisk.Location = new System.Drawing.Point(340, 105);
            this.PodejrzyjOcenyPrzycisk.Name = "PodejrzyjOcenyPrzycisk";
            this.PodejrzyjOcenyPrzycisk.Size = new System.Drawing.Size(229, 49);
            this.PodejrzyjOcenyPrzycisk.TabIndex = 1;
            this.PodejrzyjOcenyPrzycisk.Text = "Podejrzyj oceny";
            this.PodejrzyjOcenyPrzycisk.UseVisualStyleBackColor = false;
            this.PodejrzyjOcenyPrzycisk.Click += new System.EventHandler(this.PodejrzyjOcenyPrzycisk_Click);
            // 
            // KreatorKlasPrzycisk
            // 
            this.KreatorKlasPrzycisk.BackColor = System.Drawing.Color.White;
            this.KreatorKlasPrzycisk.Location = new System.Drawing.Point(77, 246);
            this.KreatorKlasPrzycisk.Name = "KreatorKlasPrzycisk";
            this.KreatorKlasPrzycisk.Size = new System.Drawing.Size(229, 49);
            this.KreatorKlasPrzycisk.TabIndex = 1;
            this.KreatorKlasPrzycisk.Text = "Kreator klas";
            this.KreatorKlasPrzycisk.UseVisualStyleBackColor = false;
            this.KreatorKlasPrzycisk.Click += new System.EventHandler(this.KreatorKlasPrzycisk_Click);
            // 
            // WyjsciePrzycisk
            // 
            this.WyjsciePrzycisk.BackColor = System.Drawing.Color.White;
            this.WyjsciePrzycisk.Location = new System.Drawing.Point(340, 246);
            this.WyjsciePrzycisk.Name = "WyjsciePrzycisk";
            this.WyjsciePrzycisk.Size = new System.Drawing.Size(229, 49);
            this.WyjsciePrzycisk.TabIndex = 1;
            this.WyjsciePrzycisk.Text = "Wyjście";
            this.WyjsciePrzycisk.UseVisualStyleBackColor = false;
            this.WyjsciePrzycisk.Click += new System.EventHandler(this.WyjsciePrzycisk_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 342);
            this.Controls.Add(this.WyjsciePrzycisk);
            this.Controls.Add(this.KreatorKlasPrzycisk);
            this.Controls.Add(this.PodejrzyjOcenyPrzycisk);
            this.Controls.Add(this.DodajOcenePrzycisk);
            this.Controls.Add(this.TekstPowitalny);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Start";
            this.Text = "Dzienniczek - start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TekstPowitalny;
        private System.Windows.Forms.Button DodajOcenePrzycisk;
        private System.Windows.Forms.Button PodejrzyjOcenyPrzycisk;
        private System.Windows.Forms.Button KreatorKlasPrzycisk;
        private System.Windows.Forms.Button WyjsciePrzycisk;
    }
}

