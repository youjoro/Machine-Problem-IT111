namespace Machine_Problem
{
    partial class Insert_Products
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmitprod = new System.Windows.Forms.Button();
            this.btnExitprod = new System.Windows.Forms.Button();
            this.txtProdname = new System.Windows.Forms.TextBox();
            this.txtProdnum = new System.Windows.Forms.TextBox();
            this.prod_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // btnSubmitprod
            // 
            this.btnSubmitprod.Location = new System.Drawing.Point(68, 127);
            this.btnSubmitprod.Name = "btnSubmitprod";
            this.btnSubmitprod.Size = new System.Drawing.Size(91, 23);
            this.btnSubmitprod.TabIndex = 3;
            this.btnSubmitprod.Text = "Submit";
            this.btnSubmitprod.UseVisualStyleBackColor = true;
            this.btnSubmitprod.Click += new System.EventHandler(this.btnSubmitprod_Click);
            // 
            // btnExitprod
            // 
            this.btnExitprod.Location = new System.Drawing.Point(179, 127);
            this.btnExitprod.Name = "btnExitprod";
            this.btnExitprod.Size = new System.Drawing.Size(91, 23);
            this.btnExitprod.TabIndex = 4;
            this.btnExitprod.Text = "Exit";
            this.btnExitprod.UseVisualStyleBackColor = true;
            this.btnExitprod.Click += new System.EventHandler(this.btnExitprod_Click);
            // 
            // txtProdname
            // 
            this.txtProdname.Location = new System.Drawing.Point(170, 23);
            this.txtProdname.Name = "txtProdname";
            this.txtProdname.Size = new System.Drawing.Size(100, 20);
            this.txtProdname.TabIndex = 5;
            // 
            // txtProdnum
            // 
            this.txtProdnum.Location = new System.Drawing.Point(170, 54);
            this.txtProdnum.Name = "txtProdnum";
            this.txtProdnum.Size = new System.Drawing.Size(100, 20);
            this.txtProdnum.TabIndex = 6;
            // 
            // prod_price
            // 
            this.prod_price.Location = new System.Drawing.Point(170, 91);
            this.prod_price.Name = "prod_price";
            this.prod_price.Size = new System.Drawing.Size(100, 20);
            this.prod_price.TabIndex = 8;
            this.prod_price.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Price per each item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Insert_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 172);
            this.Controls.Add(this.prod_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdnum);
            this.Controls.Add(this.txtProdname);
            this.Controls.Add(this.btnExitprod);
            this.Controls.Add(this.btnSubmitprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Insert_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Products to Inventory";
            this.Load += new System.EventHandler(this.Insert_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmitprod;
        private System.Windows.Forms.Button btnExitprod;
        private System.Windows.Forms.TextBox txtProdname;
        private System.Windows.Forms.TextBox txtProdnum;
        private System.Windows.Forms.TextBox prod_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}