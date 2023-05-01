namespace Factory
{
    partial class FactoryWorker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.Возраст = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.WorkerTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(141, 22);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(34, 13);
            this.FIOLabel.TabIndex = 1;
            this.FIOLabel.Text = "ФИО";
            // 
            // Возраст
            // 
            this.Возраст.AutoSize = true;
            this.Возраст.Location = new System.Drawing.Point(141, 47);
            this.Возраст.Name = "Возраст";
            this.Возраст.Size = new System.Drawing.Size(49, 13);
            this.Возраст.TabIndex = 2;
            this.Возраст.Text = "Возраст";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(190, 22);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(0, 13);
            this.FIO.TabIndex = 4;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(196, 47);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(0, 13);
            this.Age.TabIndex = 5;
            // 
            // WorkerTable
            // 
            this.WorkerTable.AllowUserToResizeColumns = false;
            this.WorkerTable.AllowUserToResizeRows = false;
            this.WorkerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerTable.Location = new System.Drawing.Point(12, 160);
            this.WorkerTable.Name = "WorkerTable";
            this.WorkerTable.Size = new System.Drawing.Size(776, 285);
            this.WorkerTable.TabIndex = 6;
            // 
            // FactoryWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkerTable);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Возраст);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FactoryWorker";
            this.Text = "FactoryWorker";
            this.Load += new System.EventHandler(this.FactoryWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label Возраст;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.DataGridView WorkerTable;
    }
}