
namespace HMS_App.Pharmacy_Form
{
    partial class Pharmacy_Menu_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnDeleteMed = new System.Windows.Forms.Button();
            this.btnViewMedDemand = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnUpdateMedicine = new System.Windows.Forms.Button();
            this.btnViewExpiredMed = new System.Windows.Forms.Button();
            this.btnPurchaseMedicine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnDeleteMed);
            this.panel1.Controls.Add(this.btnViewMedDemand);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnUpdateMedicine);
            this.panel1.Controls.Add(this.btnViewExpiredMed);
            this.panel1.Controls.Add(this.btnPurchaseMedicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 473);
            this.panel1.TabIndex = 3;
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMedicine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.Image = global::HMS_App.Properties.Resources.View_Medicines_removebg_preview_1_;
            this.btnViewMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMedicine.Location = new System.Drawing.Point(11, 73);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(172, 55);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewMedicine.UseVisualStyleBackColor = false;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnDeleteMed
            // 
            this.btnDeleteMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteMed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMed.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMed.Image = global::HMS_App.Properties.Resources.DeleteMed;
            this.btnDeleteMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMed.Location = new System.Drawing.Point(11, 404);
            this.btnDeleteMed.Name = "btnDeleteMed";
            this.btnDeleteMed.Size = new System.Drawing.Size(172, 55);
            this.btnDeleteMed.TabIndex = 9;
            this.btnDeleteMed.Text = "Delete Medicine";
            this.btnDeleteMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMed.UseVisualStyleBackColor = false;
            this.btnDeleteMed.Click += new System.EventHandler(this.btnDeleteMed_Click);
            // 
            // btnViewMedDemand
            // 
            this.btnViewMedDemand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewMedDemand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewMedDemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMedDemand.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedDemand.Image = global::HMS_App.Properties.Resources.DemandMed_removebg_preview_1_;
            this.btnViewMedDemand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMedDemand.Location = new System.Drawing.Point(11, 327);
            this.btnViewMedDemand.Name = "btnViewMedDemand";
            this.btnViewMedDemand.Size = new System.Drawing.Size(172, 71);
            this.btnViewMedDemand.TabIndex = 8;
            this.btnViewMedDemand.Text = "View medicines in demand";
            this.btnViewMedDemand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewMedDemand.UseVisualStyleBackColor = false;
            this.btnViewMedDemand.Click += new System.EventHandler(this.btnViewMedDemand_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.Image = global::HMS_App.Properties.Resources.AddMedicine_removebg_preview_1_;
            this.btnAddMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedicine.Location = new System.Drawing.Point(11, 12);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(172, 54);
            this.btnAddMedicine.TabIndex = 0;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnUpdateMedicine
            // 
            this.btnUpdateMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMedicine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMedicine.Image = global::HMS_App.Properties.Resources.UpdateMedicine_removebg_preview_1_;
            this.btnUpdateMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMedicine.Location = new System.Drawing.Point(11, 134);
            this.btnUpdateMedicine.Name = "btnUpdateMedicine";
            this.btnUpdateMedicine.Size = new System.Drawing.Size(172, 55);
            this.btnUpdateMedicine.TabIndex = 12;
            this.btnUpdateMedicine.Text = "Update Medicine";
            this.btnUpdateMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMedicine.UseVisualStyleBackColor = false;
            this.btnUpdateMedicine.Click += new System.EventHandler(this.btnUpdateMedicine_Click);
            // 
            // btnViewExpiredMed
            // 
            this.btnViewExpiredMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewExpiredMed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewExpiredMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewExpiredMed.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExpiredMed.Image = global::HMS_App.Properties.Resources.ExpiredMed1_transformed_removebg_preview_1_;
            this.btnViewExpiredMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewExpiredMed.Location = new System.Drawing.Point(11, 258);
            this.btnViewExpiredMed.Name = "btnViewExpiredMed";
            this.btnViewExpiredMed.Size = new System.Drawing.Size(172, 63);
            this.btnViewExpiredMed.TabIndex = 10;
            this.btnViewExpiredMed.Text = "View Expired medicines";
            this.btnViewExpiredMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewExpiredMed.UseVisualStyleBackColor = false;
            this.btnViewExpiredMed.Click += new System.EventHandler(this.btnViewExpiredMed_Click);
            // 
            // btnPurchaseMedicine
            // 
            this.btnPurchaseMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPurchaseMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPurchaseMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseMedicine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseMedicine.Image = global::HMS_App.Properties.Resources.PurchaseMedicine_removebg_preview_1_;
            this.btnPurchaseMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseMedicine.Location = new System.Drawing.Point(11, 196);
            this.btnPurchaseMedicine.Name = "btnPurchaseMedicine";
            this.btnPurchaseMedicine.Size = new System.Drawing.Size(172, 56);
            this.btnPurchaseMedicine.TabIndex = 13;
            this.btnPurchaseMedicine.Text = "Purchase           Medicine";
            this.btnPurchaseMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchaseMedicine.UseVisualStyleBackColor = false;
            this.btnPurchaseMedicine.Click += new System.EventHandler(this.btnPurchaseMedicine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HMS_App.Properties.Resources.Pharmacy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(168, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 549);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(193, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(739, 31);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
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
            // Pharmacy_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pharmacy_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy_Menu_Form";
            this.Load += new System.EventHandler(this.Pharmacy_Menu_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnDeleteMed;
        private System.Windows.Forms.Button btnViewMedDemand;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnUpdateMedicine;
        private System.Windows.Forms.Button btnViewExpiredMed;
        private System.Windows.Forms.Button btnPurchaseMedicine;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}