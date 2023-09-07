
namespace HMS_App.Patient_Form
{
    partial class ManageAppointments_form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AppointmentsGV = new System.Windows.Forms.DataGridView();
            this.btnShiftAppointment = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGV)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AppointmentsGV, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.38168F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 131);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AppointmentsGV
            // 
            this.AppointmentsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsGV.Location = new System.Drawing.Point(3, 3);
            this.AppointmentsGV.Name = "AppointmentsGV";
            this.AppointmentsGV.RowHeadersWidth = 51;
            this.AppointmentsGV.RowTemplate.Height = 24;
            this.AppointmentsGV.Size = new System.Drawing.Size(782, 125);
            this.AppointmentsGV.TabIndex = 0;
            // 
            // btnShiftAppointment
            // 
            this.btnShiftAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShiftAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShiftAppointment.FlatAppearance.BorderSize = 0;
            this.btnShiftAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnShiftAppointment.Location = new System.Drawing.Point(89, 318);
            this.btnShiftAppointment.Name = "btnShiftAppointment";
            this.btnShiftAppointment.Size = new System.Drawing.Size(199, 38);
            this.btnShiftAppointment.TabIndex = 16;
            this.btnShiftAppointment.Text = "Shift Appointment";
            this.btnShiftAppointment.UseVisualStyleBackColor = false;
            this.btnShiftAppointment.Click += new System.EventHandler(this.btnShiftAppointment_Click);
            this.btnShiftAppointment.MouseEnter += new System.EventHandler(this.btnShiftAppointment_MouseEnter);
            this.btnShiftAppointment.MouseLeave += new System.EventHandler(this.btnShiftAppointment_MouseLeave);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelAppointment.FlatAppearance.BorderSize = 0;
            this.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAppointment.Location = new System.Drawing.Point(461, 318);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(199, 38);
            this.btnCancelAppointment.TabIndex = 17;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            this.btnCancelAppointment.MouseEnter += new System.EventHandler(this.btnCancelAppointment_MouseEnter);
            this.btnCancelAppointment.MouseLeave += new System.EventHandler(this.btnCancelAppointment_MouseLeave);
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
            this.menuStrip2.TabIndex = 18;
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
            // ManageAppointments_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS_App.Properties.Resources.background12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnShiftAppointment);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageAppointments_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAppointments_form";
            this.Load += new System.EventHandler(this.ManageAppointments_form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGV)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView AppointmentsGV;
        private System.Windows.Forms.Button btnShiftAppointment;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}