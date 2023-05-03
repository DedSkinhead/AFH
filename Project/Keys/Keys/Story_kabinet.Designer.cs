namespace Keys
{
    partial class Story_kabinet
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
            this.StoryTable = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StoryTable
            // 
            this.StoryTable.AllowUserToResizeColumns = false;
            this.StoryTable.AllowUserToResizeRows = false;
            this.StoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoryTable.Location = new System.Drawing.Point(12, 45);
            this.StoryTable.Name = "StoryTable";
            this.StoryTable.Size = new System.Drawing.Size(776, 361);
            this.StoryTable.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(713, 412);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 27);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Excel
            // 
            this.Excel.Location = new System.Drawing.Point(12, 412);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(111, 27);
            this.Excel.TabIndex = 11;
            this.Excel.Text = "Загрузить в Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Story_kabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.StoryTable);
            this.Name = "Story_kabinet";
            this.Text = "Story_kabinet";
            this.Load += new System.EventHandler(this.Story_kabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StoryTable;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Excel;
    }
}