
namespace HMS_App.Patient_Form
{
    partial class Billing_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculatebill = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numpatientdaysinhospital = new System.Windows.Forms.NumericUpDown();
            this.numlabbill = new System.Windows.Forms.NumericUpDown();
            this.numunitdaycharge = new System.Windows.Forms.NumericUpDown();
            this.txttotalBill = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numpatientdaysinhospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numlabbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numunitdaycharge)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Number of days patient stayed in hospital:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "One day bed charge:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Laboratory test bill:";
            // 
            // btnCalculatebill
            // 
            this.btnCalculatebill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculatebill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculatebill.FlatAppearance.BorderSize = 0;
            this.btnCalculatebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculatebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatebill.ForeColor = System.Drawing.Color.Black;
            this.btnCalculatebill.Location = new System.Drawing.Point(652, 400);
            this.btnCalculatebill.Name = "btnCalculatebill";
            this.btnCalculatebill.Size = new System.Drawing.Size(136, 38);
            this.btnCalculatebill.TabIndex = 39;
            this.btnCalculatebill.Text = "Calculate Bill";
            this.btnCalculatebill.UseVisualStyleBackColor = false;
            this.btnCalculatebill.Click += new System.EventHandler(this.btnCalculatebill_Click);
            this.btnCalculatebill.MouseEnter += new System.EventHandler(this.btnCalculatebill_MouseEnter);
            this.btnCalculatebill.MouseLeave += new System.EventHandler(this.btnCalculatebill_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(416, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // txtService
            // 
            this.txtService.FormattingEnabled = true;
            this.txtService.Items.AddRange(new object[] {
            "hospitalization",
            "emergency room service"});
            this.txtService.Location = new System.Drawing.Point(416, 73);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(176, 24);
            this.txtService.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Service:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Total Bill:";
            // 
            // numpatientdaysinhospital
            // 
            this.numpatientdaysinhospital.Location = new System.Drawing.Point(416, 201);
            this.numpatientdaysinhospital.Name = "numpatientdaysinhospital";
            this.numpatientdaysinhospital.Size = new System.Drawing.Size(223, 22);
            this.numpatientdaysinhospital.TabIndex = 45;
            // 
            // numlabbill
            // 
            this.numlabbill.Location = new System.Drawing.Point(416, 309);
            this.numlabbill.Name = "numlabbill";
            this.numlabbill.Size = new System.Drawing.Size(223, 22);
            this.numlabbill.TabIndex = 47;
            // 
            // numunitdaycharge
            // 
            this.numunitdaycharge.Location = new System.Drawing.Point(416, 253);
            this.numunitdaycharge.Name = "numunitdaycharge";
            this.numunitdaycharge.Size = new System.Drawing.Size(223, 22);
            this.numunitdaycharge.TabIndex = 48;
            // 
            // txttotalBill
            // 
            this.txttotalBill.BackColor = System.Drawing.SystemColors.Menu;
            this.txttotalBill.Location = new System.Drawing.Point(416, 365);
            this.txttotalBill.Multiline = true;
            this.txttotalBill.Name = "txttotalBill";
            this.txttotalBill.Size = new System.Drawing.Size(223, 29);
            this.txttotalBill.TabIndex = 44;
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
            this.menuStrip2.TabIndex = 50;
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
            // Billing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS_App.Properties.Resources.background12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.numunitdaycharge);
            this.Controls.Add(this.numlabbill);
            this.Controls.Add(this.numpatientdaysinhospital);
            this.Controls.Add(this.txttotalBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculatebill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Billing_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_Form";
            ((System.ComponentModel.ISupportInitialize)(this.numpatientdaysinhospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numlabbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numunitdaycharge)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculatebill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox txtService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numpatientdaysinhospital;
        private System.Windows.Forms.NumericUpDown numlabbill;
        private System.Windows.Forms.NumericUpDown numunitdaycharge;
        private System.Windows.Forms.TextBox txttotalBill;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}