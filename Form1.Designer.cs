namespace ProjectNF
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
            this.closeButton = new System.Windows.Forms.Button();
            this.btn_Netflix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.BackgroundImage = global::ProjectNF.Properties.Resources.Power_icon;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 3;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Location = new System.Drawing.Point(502, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(127, 125);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // btn_Netflix
            // 
            this.btn_Netflix.BackgroundImage = global::ProjectNF.Properties.Resources.netflix_logo;
            this.btn_Netflix.Location = new System.Drawing.Point(24, 240);
            this.btn_Netflix.Name = "btn_Netflix";
            this.btn_Netflix.Size = new System.Drawing.Size(50, 51);
            this.btn_Netflix.TabIndex = 1;
            this.btn_Netflix.UseVisualStyleBackColor = true;
            this.btn_Netflix.Click += new System.EventHandler(this.btn_Netflix_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectNF.Properties.Resources.jarvis_theme_by_zenoxen;
            this.ClientSize = new System.Drawing.Size(641, 400);
            this.Controls.Add(this.btn_Netflix);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button btn_Netflix;
    }
}

