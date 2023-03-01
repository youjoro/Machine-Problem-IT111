namespace Machine_Problem
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnSold = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(40, 83);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(195, 35);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show All Items";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(40, 165);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(195, 35);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Record Sale";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(40, 247);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(195, 35);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Manage Items";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSold
            // 
            this.btnSold.Location = new System.Drawing.Point(40, 329);
            this.btnSold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(195, 35);
            this.btnSold.TabIndex = 3;
            this.btnSold.Text = "Products Sold";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(40, 413);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(195, 35);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total Sales";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button button1;
    }
}