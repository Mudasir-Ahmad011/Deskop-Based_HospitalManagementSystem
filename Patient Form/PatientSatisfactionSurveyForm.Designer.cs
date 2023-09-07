
namespace HMS_App.Patient_Form
{
    partial class PatientSatisfactionSurveyForm
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
            this.txtsatisfyservices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbehaviour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numrate = new System.Windows.Forms.NumericUpDown();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numrate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Are you satisfy with our services(yes or no or maybe):";
            // 
            // txtsatisfyservices
            // 
            this.txtsatisfyservices.FormattingEnabled = true;
            this.txtsatisfyservices.Items.AddRange(new object[] {
            "yes",
            "no",
            "maybe"});
            this.txtsatisfyservices.Location = new System.Drawing.Point(445, 53);
            this.txtsatisfyservices.Name = "txtsatisfyservices";
            this.txtsatisfyservices.Size = new System.Drawing.Size(121, 24);
            this.txtsatisfyservices.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "What is the behaviour of hospital staff(very caring or nice or not good):";
            // 
            // txtbehaviour
            // 
            this.txtbehaviour.FormattingEnabled = true;
            this.txtbehaviour.Items.AddRange(new object[] {
            "very caring",
            "nice",
            "not good"});
            this.txtbehaviour.Location = new System.Drawing.Point(568, 109);
            this.txtbehaviour.Name = "txtbehaviour";
            this.txtbehaviour.Size = new System.Drawing.Size(121, 24);
            this.txtbehaviour.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Out of 5 how much you rate us:";
            // 
            // numrate
            // 
            this.numrate.Location = new System.Drawing.Point(279, 167);
            this.numrate.Margin = new System.Windows.Forms.Padding(4);
            this.numrate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numrate.Name = "numrate";
            this.numrate.Size = new System.Drawing.Size(160, 22);
            this.numrate.TabIndex = 96;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(12, 213);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 31);
            this.btnclose.TabIndex = 97;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // PatientSatisfactionSurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(729, 256);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.numrate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbehaviour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsatisfyservices);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PatientSatisfactionSurveyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numrate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtsatisfyservices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtbehaviour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numrate;
        private System.Windows.Forms.Button btnclose;
    }
}