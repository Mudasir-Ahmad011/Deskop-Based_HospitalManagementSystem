
namespace HMS_App.Patient_Form
{
    partial class Manage_DoctorSchedule_Form
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
            this.dtDoctordate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoctorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorSpecialty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartingTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndingTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDoctordate
            // 
            this.dtDoctordate.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dtDoctordate.Location = new System.Drawing.Point(154, 63);
            this.dtDoctordate.Name = "dtDoctordate";
            this.dtDoctordate.Size = new System.Drawing.Size(223, 22);
            this.dtDoctordate.TabIndex = 39;
            this.dtDoctordate.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date:";
            // 
            // txtDoctorname
            // 
            this.txtDoctorname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDoctorname.Location = new System.Drawing.Point(154, 109);
            this.txtDoctorname.Multiline = true;
            this.txtDoctorname.Name = "txtDoctorname";
            this.txtDoctorname.Size = new System.Drawing.Size(223, 29);
            this.txtDoctorname.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Doctor name:";
            // 
            // txtDoctorSpecialty
            // 
            this.txtDoctorSpecialty.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDoctorSpecialty.Location = new System.Drawing.Point(153, 157);
            this.txtDoctorSpecialty.Multiline = true;
            this.txtDoctorSpecialty.Name = "txtDoctorSpecialty";
            this.txtDoctorSpecialty.Size = new System.Drawing.Size(223, 29);
            this.txtDoctorSpecialty.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Doctor Specialty:";
            // 
            // txtStartingTime
            // 
            this.txtStartingTime.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStartingTime.Location = new System.Drawing.Point(153, 243);
            this.txtStartingTime.Multiline = true;
            this.txtStartingTime.Name = "txtStartingTime";
            this.txtStartingTime.Size = new System.Drawing.Size(223, 29);
            this.txtStartingTime.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Starting time(1to12(am or pm)):";
            // 
            // txtEndingTime
            // 
            this.txtEndingTime.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEndingTime.Location = new System.Drawing.Point(153, 326);
            this.txtEndingTime.Multiline = true;
            this.txtEndingTime.Name = "txtEndingTime";
            this.txtEndingTime.Size = new System.Drawing.Size(223, 29);
            this.txtEndingTime.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ending time(1to12(am or pm)):";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(12, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
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
            // Manage_DoctorSchedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS_App.Properties.Resources.background12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEndingTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStartingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoctorSpecialty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoctorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDoctordate);
            this.Controls.Add(this.label6);
            this.Name = "Manage_DoctorSchedule_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_DoctorSchedule_Form";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDoctordate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoctorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorSpecialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}