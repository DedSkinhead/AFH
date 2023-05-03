namespace Keys
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TakeButton = new System.Windows.Forms.Button();
            this.ReleaseButton = new System.Windows.Forms.Button();
            this.Story = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WatchmanTable)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchmanTable
            // 
            this.WatchmanTable.AllowUserToResizeColumns = false;
            this.WatchmanTable.AllowUserToResizeRows = false;
            this.WatchmanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WatchmanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WatchmanTable.Location = new System.Drawing.Point(12, 38);
            this.WatchmanTable.Name = "WatchmanTable";
            this.WatchmanTable.Size = new System.Drawing.Size(776, 361);
            this.WatchmanTable.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(164, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(48, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(110, 20);
            this.SearchTextBox.TabIndex = 5;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(39, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Поиск";
            // 
            // TakeButton
            // 
            this.TakeButton.Location = new System.Drawing.Point(596, 411);
            this.TakeButton.Name = "TakeButton";
            this.TakeButton.Size = new System.Drawing.Size(75, 27);
            this.TakeButton.TabIndex = 7;
            this.TakeButton.Text = "Занять";
            this.TakeButton.UseVisualStyleBackColor = true;
            this.TakeButton.Click += new System.EventHandler(this.TakeButton_Click);
            // 
            // ReleaseButton
            // 
            this.ReleaseButton.Location = new System.Drawing.Point(713, 411);
            this.ReleaseButton.Name = "ReleaseButton";
            this.ReleaseButton.Size = new System.Drawing.Size(75, 27);
            this.ReleaseButton.TabIndex = 8;
            this.ReleaseButton.Text = "Освободить";
            this.ReleaseButton.UseVisualStyleBackColor = true;
            this.ReleaseButton.Click += new System.EventHandler(this.ReleaseButton_Click);
            // 
            // Story
            // 
            this.Story.Location = new System.Drawing.Point(15, 411);
            this.Story.Name = "Story";
            this.Story.Size = new System.Drawing.Size(75, 27);
            this.Story.TabIndex = 9;
            this.Story.Text = "История ";
            this.Story.UseVisualStyleBackColor = true;
            this.Story.Click += new System.EventHandler(this.Story_Click);
            // 
            // Watchman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Story);
            this.Controls.Add(this.ReleaseButton);
            this.Controls.Add(this.TakeButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.WatchmanTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Watchman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вахтер";
            this.Load += new System.EventHandler(this.Watchman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WatchmanTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WatchmanTable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button TakeButton;
        private System.Windows.Forms.Button ReleaseButton;
        private System.Windows.Forms.Button Story;
    }
}