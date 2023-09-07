
namespace HMS_App.Patient_Form
{
    partial class CheckDoctorSchedule_Form
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
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.doctorGV = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtdate
            // 
            this.dtdate.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dtdate.Location = new System.Drawing.Point(281, 37);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(223, 22);
            this.dtdate.TabIndex = 39;
            this.dtdate.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date:";
            // 
            // doctorGV
            // 
            this.doctorGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorGV.Location = new System.Drawing.Point(3, 115);
            this.doctorGV.Name = "doctorGV";
            this.doctorGV.RowHeadersWidth = 51;
            this.doctorGV.RowTemplate.Height = 24;
            this.doctorGV.Size = new System.Drawing.Size(730, 240);
            this.doctorGV.TabIndex = 40;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(12, 362);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 31);
            this.btnclose.TabIndex = 41;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(421, 78);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 31);
            this.btnCheck.TabIndex = 42;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.btnCheck_MouseEnter);
            this.btnCheck.MouseLeave += new System.EventHandler(this.btnCheck_MouseLeave);
            // 
            // CheckDoctorSchedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(737, 405);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.doctorGV);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckDoctorSchedule_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CheckDoctorSchedule_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView doctorGV;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnCheck;
    }
}