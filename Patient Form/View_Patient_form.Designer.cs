
namespace HMS_App.Patient_Form
{
    partial class View_Patient_form
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
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.HometoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.txtCnicSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientGV
            // 
            this.PatientGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(3, 3);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersWidth = 51;
            this.PatientGV.RowTemplate.Height = 24;
            this.PatientGV.Size = new System.Drawing.Size(779, 325);
            this.PatientGV.TabIndex = 0;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PatientGV, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 331);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HometoolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 31);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // HometoolStripMenuItem1
            // 
            this.HometoolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HometoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.HometoolStripMenuItem1.Name = "HometoolStripMenuItem1";
            this.HometoolStripMenuItem1.Size = new System.Drawing.Size(72, 27);
            this.HometoolStripMenuItem1.Text = "Home";
            this.HometoolStripMenuItem1.Click += new System.EventHandler(this.HometoolStripMenuItem1_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearchBox.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBox.Location = new System.Drawing.Point(110, 68);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(223, 29);
            this.txtSearchBox.TabIndex = 23;
            this.txtSearchBox.Text = "Search By Name";
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.Enter += new System.EventHandler(this.txtSearchBox_Enter);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // txtCnicSearch
            // 
            this.txtCnicSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCnicSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtCnicSearch.Location = new System.Drawing.Point(494, 68);
            this.txtCnicSearch.Multiline = true;
            this.txtCnicSearch.Name = "txtCnicSearch";
            this.txtCnicSearch.Size = new System.Drawing.Size(223, 29);
            this.txtCnicSearch.TabIndex = 24;
            this.txtCnicSearch.Text = "Search By Cnic";
            this.txtCnicSearch.TextChanged += new System.EventHandler(this.txtCnicSearch_TextChanged);
            this.txtCnicSearch.Enter += new System.EventHandler(this.txtCnicSearch_Enter);
            this.txtCnicSearch.Leave += new System.EventHandler(this.txtCnicSearch_Leave);
            // 
            // View_Patient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS_App.Properties.Resources.background12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtCnicSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "View_Patient_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Patient_form";
            this.Load += new System.EventHandler(this.View_Patient_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HometoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.TextBox txtCnicSearch;
    }
}