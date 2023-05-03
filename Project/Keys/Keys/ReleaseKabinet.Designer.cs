namespace Keys
{
    partial class ReleaseKabinet
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReleaseConfirmation = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Освободить кабинет?";
            // 
            // ReleaseConfirmation
            // 
            this.ReleaseConfirmation.Location = new System.Drawing.Point(86, 185);
            this.ReleaseConfirmation.Name = "ReleaseConfirmation";
            this.ReleaseConfirmation.Size = new System.Drawing.Size(75, 23);
            this.ReleaseConfirmation.TabIndex = 1;
            this.ReleaseConfirmation.Text = "да";
            this.ReleaseConfirmation.UseVisualStyleBackColor = true;
            this.ReleaseConfirmation.Click += new System.EventHandler(this.ReleaseConfirmation_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(314, 185);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "нет";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReleaseKabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 303);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReleaseConfirmation);
            this.Controls.Add(this.label1);
            this.Name = "ReleaseKabinet";
            this.Text = "ReleaseKabinet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReleaseConfirmation;
        private System.Windows.Forms.Button ExitButton;
    }
}