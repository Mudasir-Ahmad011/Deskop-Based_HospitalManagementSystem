
namespace HMS_App.Pharmacy_Form
{
    partial class PurchaseMedicine_Form
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
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmedicinename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmedicineExpense = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name:";
            // 
            // txtCustomername
            // 
            this.txtCustomername.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCustomername.Location = new System.Drawing.Point(331, 121);
            this.txtCustomername.Multiline = true;
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(223, 29);
            this.txtCustomername.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Medicine name:";
            // 
            // txtmedicinename
            // 
            this.txtmedicinename.BackColor = System.Drawing.SystemColors.Menu;
            this.txtmedicinename.Location = new System.Drawing.Point(331, 208);
            this.txtmedicinename.Multiline = true;
            this.txtmedicinename.Name = "txtmedicinename";
            this.txtmedicinename.Size = new System.Drawing.Size(223, 29);
            this.txtmedicinename.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Quantity:";
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.SystemColors.Menu;
            this.txtquantity.Location = new System.Drawing.Point(331, 273);
            this.txtquantity.Multiline = true;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(223, 29);
            this.txtquantity.TabIndex = 45;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(471, 323);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(83, 31);
            this.btnadd.TabIndex = 46;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.MouseEnter += new System.EventHandler(this.btnadd_MouseEnter);
            this.btnadd.MouseLeave += new System.EventHandler(this.btnadd_MouseLeave);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Location = new System.Drawing.Point(471, 156);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(83, 31);
            this.btnnext.TabIndex = 48;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            this.btnnext.MouseEnter += new System.EventHandler(this.btnnext_MouseEnter);
            this.btnnext.MouseLeave += new System.EventHandler(this.btnnext_MouseLeave);
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchase.Location = new System.Drawing.Point(705, 407);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(83, 31);
            this.btnpurchase.TabIndex = 49;
            this.btnpurchase.Text = "Purchase";
            this.btnpurchase.UseVisualStyleBackColor = false;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            this.btnpurchase.MouseEnter += new System.EventHandler(this.btnpurchase_MouseEnter);
            this.btnpurchase.MouseLeave += new System.EventHandler(this.btnpurchase_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Medicine Expense:";
            // 
            // lblmedicineExpense
            // 
            this.lblmedicineExpense.AutoSize = true;
            this.lblmedicineExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedicineExpense.Location = new System.Drawing.Point(348, 372);
            this.lblmedicineExpense.Name = "lblmedicineExpense";
            this.lblmedicineExpense.Size = new System.Drawing.Size(14, 20);
            this.lblmedicineExpense.TabIndex = 51;
            this.lblmedicineExpense.Text = ":";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 31);
            this.menuStrip2.TabIndex = 52;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HomeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.HomeToolStripMenuItem.Text = "Home";
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(54, 27);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // PurchaseMedicine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.lblmedicineExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmedicinename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomername);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseMedicine_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseMedicine_Form";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmedicinename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmedicineExpense;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}