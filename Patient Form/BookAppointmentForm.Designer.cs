
namespace HMS_App.Patient_Form
{
    partial class BookAppointmentForm
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
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdoctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblavailableTime = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimetakeAppointment = new System.Windows.Forms.TextBox();
            this.btnbookappointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtDate
            // 
            this.dtDate.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dtDate.Location = new System.Drawing.Point(391, 32);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(223, 22);
            this.dtDate.TabIndex = 39;
            this.dtDate.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Doctor Name:";
            // 
            // txtdoctorName
            // 
            this.txtdoctorName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtdoctorName.Location = new System.Drawing.Point(391, 74);
            this.txtdoctorName.Multiline = true;
            this.txtdoctorName.Name = "txtdoctorName";
            this.txtdoctorName.Size = new System.Drawing.Size(223, 29);
            this.txtdoctorName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Name from which you want to book appointment:";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtname.Location = new System.Drawing.Point(389, 119);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(223, 29);
            this.txtname.TabIndex = 43;
            // 
            // lblavailableTime
            // 
            this.lblavailableTime.AutoSize = true;
            this.lblavailableTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailableTime.Location = new System.Drawing.Point(138, 213);
            this.lblavailableTime.Name = "lblavailableTime";
            this.lblavailableTime.Size = new System.Drawing.Size(0, 20);
            this.lblavailableTime.TabIndex = 44;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Location = new System.Drawing.Point(531, 163);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(83, 31);
            this.btncheck.TabIndex = 45;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            this.btncheck.MouseEnter += new System.EventHandler(this.btncheck_MouseEnter);
            this.btncheck.MouseLeave += new System.EventHandler(this.btncheck_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Enter time you want to take appointmet:";
            // 
            // txttimetakeAppointment
            // 
            this.txttimetakeAppointment.BackColor = System.Drawing.SystemColors.Menu;
            this.txttimetakeAppointment.Location = new System.Drawing.Point(389, 257);
            this.txttimetakeAppointment.Multiline = true;
            this.txttimetakeAppointment.Name = "txttimetakeAppointment";
            this.txttimetakeAppointment.Size = new System.Drawing.Size(223, 29);
            this.txttimetakeAppointment.TabIndex = 47;
            // 
            // btnbookappointment
            // 
            this.btnbookappointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbookappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbookappointment.Location = new System.Drawing.Point(433, 321);
            this.btnbookappointment.Name = "btnbookappointment";
            this.btnbookappointment.Size = new System.Drawing.Size(179, 31);
            this.btnbookappointment.TabIndex = 48;
            this.btnbookappointment.Text = "Book Appointment";
            this.btnbookappointment.UseVisualStyleBackColor = false;
            this.btnbookappointment.Click += new System.EventHandler(this.btnbookappointment_Click);
            this.btnbookappointment.MouseEnter += new System.EventHandler(this.btnbookappointment_MouseEnter);
            this.btnbookappointment.MouseLeave += new System.EventHandler(this.btnbookappointment_MouseLeave);
            // 
            // BookAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(676, 405);
            this.ControlBox = false;
            this.Controls.Add(this.btnbookappointment);
            this.Controls.Add(this.txttimetakeAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.lblavailableTime);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdoctorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblavailableTime;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimetakeAppointment;
        private System.Windows.Forms.Button btnbookappointment;
    }
}