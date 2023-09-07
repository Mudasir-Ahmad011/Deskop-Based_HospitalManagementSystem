
namespace HMS_App.Pharmacy_Form
{
    partial class UpdateMedicine_Form
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
            this.txtchange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtupdatebox = new System.Windows.Forms.TextBox();
            this.lbldepend = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btncontinue = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtchange
            // 
            this.txtchange.BackColor = System.Drawing.SystemColors.Menu;
            this.txtchange.Location = new System.Drawing.Point(354, 198);
            this.txtchange.Multiline = true;
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(223, 29);
            this.txtchange.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "What you want to change:";
            // 
            // txtMedicine
            // 
            this.txtMedicine.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMedicine.Location = new System.Drawing.Point(354, 96);
            this.txtMedicine.Multiline = true;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(223, 29);
            this.txtMedicine.TabIndex = 40;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(494, 142);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 31);
            this.btnCheck.TabIndex = 39;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.btnCheck_MouseEnter);
            this.btnCheck.MouseLeave += new System.EventHandler(this.btnCheck_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Medicine name:";
            // 
            // txtupdatebox
            // 
            this.txtupdatebox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtupdatebox.Location = new System.Drawing.Point(354, 299);
            this.txtupdatebox.Multiline = true;
            this.txtupdatebox.Name = "txtupdatebox";
            this.txtupdatebox.Size = new System.Drawing.Size(223, 29);
            this.txtupdatebox.TabIndex = 45;
            // 
            // lbldepend
            // 
            this.lbldepend.AutoSize = true;
            this.lbldepend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepend.Location = new System.Drawing.Point(219, 299);
            this.lbldepend.Name = "lbldepend";
            this.lbldepend.Size = new System.Drawing.Size(14, 20);
            this.lbldepend.TabIndex = 46;
            this.lbldepend.Text = ";";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(494, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 31);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btncontinue
            // 
            this.btncontinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontinue.Location = new System.Drawing.Point(494, 242);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(83, 31);
            this.btncontinue.TabIndex = 48;
            this.btncontinue.Text = "Continue";
            this.btncontinue.UseVisualStyleBackColor = false;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            this.btncontinue.MouseEnter += new System.EventHandler(this.btncontinue_MouseEnter);
            this.btncontinue.MouseLeave += new System.EventHandler(this.btncontinue_MouseLeave);
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
            this.menuStrip2.TabIndex = 49;
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
            // UpdateMedicine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btncontinue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbldepend);
            this.Controls.Add(this.txtupdatebox);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicine);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMedicine_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMedicine_Form";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtupdatebox;
        private System.Windows.Forms.Label lbldepend;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}