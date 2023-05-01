namespace Factory
{
    partial class Watchman
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
            this.WatchmanTable = new System.Windows.Forms.DataGridView();
            this.Came = new System.Windows.Forms.Button();
            this.Gone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WatchmanTable)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchmanTable
            // 
            this.WatchmanTable.AllowUserToResizeColumns = false;
            this.WatchmanTable.AllowUserToResizeRows = false;
            this.WatchmanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WatchmanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WatchmanTable.Location = new System.Drawing.Point(12, 43);
            this.WatchmanTable.Name = "WatchmanTable";
            this.WatchmanTable.Size = new System.Drawing.Size(776, 440);
            this.WatchmanTable.TabIndex = 1;
            // 
            // Came
            // 
            this.Came.Location = new System.Drawing.Point(12, 12);
            this.Came.Name = "Came";
            this.Came.Size = new System.Drawing.Size(75, 23);
            this.Came.TabIndex = 2;
            this.Came.Text = "Пришел";
            this.Came.UseVisualStyleBackColor = true;
            this.Came.Click += new System.EventHandler(this.Came_Click);
            // 
            // Gone
            // 
            this.Gone.Location = new System.Drawing.Point(93, 12);
            this.Gone.Name = "Gone";
            this.Gone.Size = new System.Drawing.Size(75, 23);
            this.Gone.TabIndex = 3;
            this.Gone.Text = "Ушел";
            this.Gone.UseVisualStyleBackColor = true;
            this.Gone.Click += new System.EventHandler(this.Gone_Click);
            // 
            // Watchman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.Gone);
            this.Controls.Add(this.Came);
            this.Controls.Add(this.WatchmanTable);
            this.Name = "Watchman";
            this.Text = "Watchman";
            this.Load += new System.EventHandler(this.Watchman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WatchmanTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WatchmanTable;
        private System.Windows.Forms.Button Came;
        private System.Windows.Forms.Button Gone;
    }
}