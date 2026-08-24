namespace Localization
{
    partial class Form1
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
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpLanguages = new System.Windows.Forms.GroupBox();
            this.rb_pt_BR = new System.Windows.Forms.RadioButton();
            this.rb_fr_FR = new System.Windows.Forms.RadioButton();
            this.rb_de_DE = new System.Windows.Forms.RadioButton();
            this.rb_en_US = new System.Windows.Forms.RadioButton();
            this.grpLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(26, 42);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(79, 13);
            this.lblTrans.TabIndex = 0;
            this.lblTrans.Text = "String (en-US) :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(135, 42);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(199, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "This is a demo application for localization";
            // 
            // grpLanguages
            // 
            this.grpLanguages.Controls.Add(this.rb_pt_BR);
            this.grpLanguages.Controls.Add(this.rb_fr_FR);
            this.grpLanguages.Controls.Add(this.rb_de_DE);
            this.grpLanguages.Controls.Add(this.rb_en_US);
            this.grpLanguages.Location = new System.Drawing.Point(29, 81);
            this.grpLanguages.Name = "grpLanguages";
            this.grpLanguages.Size = new System.Drawing.Size(274, 123);
            this.grpLanguages.TabIndex = 3;
            this.grpLanguages.TabStop = false;
            this.grpLanguages.Text = "Select a language";
            // 
            // rb_pt_BR
            // 
            this.rb_pt_BR.AutoSize = true;
            this.rb_pt_BR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_pt_BR.Location = new System.Drawing.Point(16, 91);
            this.rb_pt_BR.Name = "rb_pt_BR";
            this.rb_pt_BR.Size = new System.Drawing.Size(149, 17);
            this.rb_pt_BR.TabIndex = 3;
            this.rb_pt_BR.TabStop = true;
            this.rb_pt_BR.Tag = "fr-BE";
            this.rb_pt_BR.Text = "Portuguese - Brazil (pt-BR)";
            this.rb_pt_BR.UseVisualStyleBackColor = true;
            this.rb_pt_BR.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
            // 
            // rb_fr_FR
            // 
            this.rb_fr_FR.AutoSize = true;
            this.rb_fr_FR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_fr_FR.Location = new System.Drawing.Point(16, 67);
            this.rb_fr_FR.Name = "rb_fr_FR";
            this.rb_fr_FR.Size = new System.Drawing.Size(132, 17);
            this.rb_fr_FR.TabIndex = 2;
            this.rb_fr_FR.TabStop = true;
            this.rb_fr_FR.Tag = "fr-FR";
            this.rb_fr_FR.Text = "French - France (fr-FR)";
            this.rb_fr_FR.UseVisualStyleBackColor = true;
            this.rb_fr_FR.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
            // 
            // rb_de_DE
            // 
            this.rb_de_DE.AutoSize = true;
            this.rb_de_DE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_de_DE.Location = new System.Drawing.Point(16, 43);
            this.rb_de_DE.Name = "rb_de_DE";
            this.rb_de_DE.Size = new System.Drawing.Size(146, 17);
            this.rb_de_DE.TabIndex = 1;
            this.rb_de_DE.TabStop = true;
            this.rb_de_DE.Tag = "en-GB";
            this.rb_de_DE.Text = "German-Germany (de-DE)";
            this.rb_de_DE.UseVisualStyleBackColor = true;
            this.rb_de_DE.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
            // 
            // rb_en_US
            // 
            this.rb_en_US.AutoSize = true;
            this.rb_en_US.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_en_US.Location = new System.Drawing.Point(16, 19);
            this.rb_en_US.Name = "rb_en_US";
            this.rb_en_US.Size = new System.Drawing.Size(122, 17);
            this.rb_en_US.TabIndex = 0;
            this.rb_en_US.TabStop = true;
            this.rb_en_US.Tag = "en-US";
            this.rb_en_US.Text = "U.S. English (en-US)";
            this.rb_en_US.UseVisualStyleBackColor = true;
            this.rb_en_US.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 232);
            this.Controls.Add(this.grpLanguages);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTrans);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A demo application";
            this.grpLanguages.ResumeLayout(false);
            this.grpLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.GroupBox grpLanguages;
        internal System.Windows.Forms.RadioButton rb_pt_BR;
        internal System.Windows.Forms.RadioButton rb_fr_FR;
        internal System.Windows.Forms.RadioButton rb_de_DE;
        internal System.Windows.Forms.RadioButton rb_en_US;
    }
}

