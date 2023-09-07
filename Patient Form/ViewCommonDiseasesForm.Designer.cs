
namespace HMS_App.Patient_Form
{
    partial class ViewCommonDiseasesForm
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
            this.lblCommonDisease = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCommonDisease
            // 
            this.lblCommonDisease.AutoSize = true;
            this.lblCommonDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonDisease.Location = new System.Drawing.Point(29, 56);
            this.lblCommonDisease.Name = "lblCommonDisease";
            this.lblCommonDisease.Size = new System.Drawing.Size(404, 100);
            this.lblCommonDisease.TabIndex = 0;
            this.lblCommonDisease.Text = "\"Most usual medicine for fever is Panadol\"\r\n\"Most usual medicine for flu is influ" +
    "enza\"\r\n\"Most usual medicine for cough is Hydryllin\"\r\n\"Most usual medicine for he" +
    "adache is aspirin\"";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(12, 210);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 31);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ViewCommonDiseasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(455, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblCommonDisease);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewCommonDiseasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommonDisease;
        private System.Windows.Forms.Button btnclose;
    }
}