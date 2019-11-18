namespace TicTacToe
{
    partial class StartForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HumanVsHuman = new System.Windows.Forms.Button();
            this.HumanVsComputer = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.OnePlayerNameTXT = new System.Windows.Forms.TextBox();
            this.TwoPlayerNameTXT = new System.Windows.Forms.TextBox();
            this.CreditsLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // HumanVsHuman
            // 
            this.HumanVsHuman.BackColor = System.Drawing.Color.Gainsboro;
            this.HumanVsHuman.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanVsHuman.Location = new System.Drawing.Point(44, 110);
            this.HumanVsHuman.Name = "HumanVsHuman";
            this.HumanVsHuman.Size = new System.Drawing.Size(414, 66);
            this.HumanVsHuman.TabIndex = 1;
            this.HumanVsHuman.Text = "Human vs Human";
            this.HumanVsHuman.UseVisualStyleBackColor = false;
            this.HumanVsHuman.Click += new System.EventHandler(this.HumanVsHuman_Click);
            // 
            // HumanVsComputer
            // 
            this.HumanVsComputer.BackColor = System.Drawing.Color.Gainsboro;
            this.HumanVsComputer.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanVsComputer.Location = new System.Drawing.Point(44, 182);
            this.HumanVsComputer.Name = "HumanVsComputer";
            this.HumanVsComputer.Size = new System.Drawing.Size(414, 66);
            this.HumanVsComputer.TabIndex = 2;
            this.HumanVsComputer.Text = "Human vs Computer";
            this.HumanVsComputer.UseVisualStyleBackColor = false;
            this.HumanVsComputer.Click += new System.EventHandler(this.HumanVsComputer_Click_1);
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.Gainsboro;
            this.Credits.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.Location = new System.Drawing.Point(44, 254);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(414, 66);
            this.Credits.TabIndex = 3;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = false;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Gainsboro;
            this.Settings.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(44, 326);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(414, 66);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gainsboro;
            this.Back.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(44, 326);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(414, 66);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Gainsboro;
            this.Save.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(44, 254);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(414, 66);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OnePlayerNameTXT
            // 
            this.OnePlayerNameTXT.Location = new System.Drawing.Point(45, 112);
            this.OnePlayerNameTXT.Name = "OnePlayerNameTXT";
            this.OnePlayerNameTXT.Size = new System.Drawing.Size(413, 20);
            this.OnePlayerNameTXT.TabIndex = 7;
            this.OnePlayerNameTXT.Text = "One Player Name";
            this.OnePlayerNameTXT.Visible = false;
            // 
            // TwoPlayerNameTXT
            // 
            this.TwoPlayerNameTXT.Location = new System.Drawing.Point(45, 182);
            this.TwoPlayerNameTXT.Name = "TwoPlayerNameTXT";
            this.TwoPlayerNameTXT.Size = new System.Drawing.Size(413, 20);
            this.TwoPlayerNameTXT.TabIndex = 8;
            this.TwoPlayerNameTXT.Text = "Two Player Name";
            this.TwoPlayerNameTXT.Visible = false;
            // 
            // CreditsLBL
            // 
            this.CreditsLBL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreditsLBL.Location = new System.Drawing.Point(44, 110);
            this.CreditsLBL.Name = "CreditsLBL";
            this.CreditsLBL.Size = new System.Drawing.Size(414, 208);
            this.CreditsLBL.TabIndex = 9;
            this.CreditsLBL.Text = "Program Authors: \r\nPatryk Buszman \r\n";
            this.CreditsLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreditsLBL.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 426);
            this.Controls.Add(this.CreditsLBL);
            this.Controls.Add(this.TwoPlayerNameTXT);
            this.Controls.Add(this.OnePlayerNameTXT);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.HumanVsComputer);
            this.Controls.Add(this.HumanVsHuman);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HumanVsHuman;
        private System.Windows.Forms.Button HumanVsComputer;
        private System.Windows.Forms.Button Credits;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox OnePlayerNameTXT;
        private System.Windows.Forms.TextBox TwoPlayerNameTXT;
        private System.Windows.Forms.Label CreditsLBL;
    }
}

