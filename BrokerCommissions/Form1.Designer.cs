namespace BrokerCommissions
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.brokerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBaseCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBonus2 = new System.Windows.Forms.Button();
            this.btnCsvBonus1 = new System.Windows.Forms.Button();
            this.btnCsvBonus2 = new System.Windows.Forms.Button();
            this.btnCsvBonus3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBonus3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBonus1New = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(221, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(84, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Load CSV File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(993, 497);
            this.dataGridView.TabIndex = 2;
            // 
            // btnBaseCSV
            // 
            this.btnBaseCSV.Enabled = false;
            this.btnBaseCSV.Location = new System.Drawing.Point(320, 12);
            this.btnBaseCSV.Name = "btnBaseCSV";
            this.btnBaseCSV.Size = new System.Drawing.Size(95, 23);
            this.btnBaseCSV.TabIndex = 3;
            this.btnBaseCSV.Text = "Base CSV File";
            this.btnBaseCSV.UseVisualStyleBackColor = true;
            this.btnBaseCSV.Click += new System.EventHandler(this.btnBaseCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Load CSV File adding Base Commission:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Process Bonus 1 (over £100,000)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(489, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Process Bonus 2 (over £250,000)";
            // 
            // btnBonus2
            // 
            this.btnBonus2.Enabled = false;
            this.btnBonus2.Location = new System.Drawing.Point(660, 12);
            this.btnBonus2.Name = "btnBonus2";
            this.btnBonus2.Size = new System.Drawing.Size(84, 23);
            this.btnBonus2.TabIndex = 8;
            this.btnBonus2.Text = " Bonus 2";
            this.btnBonus2.UseVisualStyleBackColor = true;
            this.btnBonus2.Click += new System.EventHandler(this.btnBonus2_Click);
            // 
            // btnCsvBonus1
            // 
            this.btnCsvBonus1.Enabled = false;
            this.btnCsvBonus1.Location = new System.Drawing.Point(320, 60);
            this.btnCsvBonus1.Name = "btnCsvBonus1";
            this.btnCsvBonus1.Size = new System.Drawing.Size(95, 23);
            this.btnCsvBonus1.TabIndex = 10;
            this.btnCsvBonus1.Text = "Bonus1 CSV File";
            this.btnCsvBonus1.UseVisualStyleBackColor = true;
            this.btnCsvBonus1.Click += new System.EventHandler(this.btnCsvBonus1_Click);
            // 
            // btnCsvBonus2
            // 
            this.btnCsvBonus2.Enabled = false;
            this.btnCsvBonus2.Location = new System.Drawing.Point(750, 12);
            this.btnCsvBonus2.Name = "btnCsvBonus2";
            this.btnCsvBonus2.Size = new System.Drawing.Size(95, 23);
            this.btnCsvBonus2.TabIndex = 11;
            this.btnCsvBonus2.Text = "Bonus2 CSV File";
            this.btnCsvBonus2.UseVisualStyleBackColor = true;
            this.btnCsvBonus2.Click += new System.EventHandler(this.btnCsvBonus2_Click);
            // 
            // btnCsvBonus3
            // 
            this.btnCsvBonus3.Enabled = false;
            this.btnCsvBonus3.Location = new System.Drawing.Point(750, 60);
            this.btnCsvBonus3.Name = "btnCsvBonus3";
            this.btnCsvBonus3.Size = new System.Drawing.Size(95, 23);
            this.btnCsvBonus3.TabIndex = 14;
            this.btnCsvBonus3.Text = "Bonus3 CSV File";
            this.btnCsvBonus3.UseVisualStyleBackColor = true;
            this.btnCsvBonus3.Click += new System.EventHandler(this.btnCsvBonus3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(489, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Process Bonus 3 (over £250,000)";
            // 
            // btnBonus3
            // 
            this.btnBonus3.Enabled = false;
            this.btnBonus3.Location = new System.Drawing.Point(660, 61);
            this.btnBonus3.Name = "btnBonus3";
            this.btnBonus3.Size = new System.Drawing.Size(84, 23);
            this.btnBonus3.TabIndex = 12;
            this.btnBonus3.Text = " Bonus 3";
            this.btnBonus3.UseVisualStyleBackColor = true;
            this.btnBonus3.Click += new System.EventHandler(this.btnBonus3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBonus1New);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.btnCsvBonus3);
            this.panel1.Controls.Add(this.btnBaseCSV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBonus3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCsvBonus2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCsvBonus1);
            this.panel1.Controls.Add(this.btnBonus2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 131);
            this.panel1.TabIndex = 15;
            // 
            // btnBonus1New
            // 
            this.btnBonus1New.Enabled = false;
            this.btnBonus1New.Location = new System.Drawing.Point(230, 61);
            this.btnBonus1New.Name = "btnBonus1New";
            this.btnBonus1New.Size = new System.Drawing.Size(75, 23);
            this.btnBonus1New.TabIndex = 15;
            this.btnBonus1New.Text = "Bonus 1";
            this.btnBonus1New.UseVisualStyleBackColor = true;
            this.btnBonus1New.Click += new System.EventHandler(this.btnBonus1New_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 497);
            this.panel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Broker Commission";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRead;
       // private System.Windows.Forms.DataGridViewTextBoxColumn caseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource brokerBindingSource;
        private System.Windows.Forms.Button btnBaseCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBonus2;
        private System.Windows.Forms.Button btnCsvBonus1;
        private System.Windows.Forms.Button btnCsvBonus2;
        private System.Windows.Forms.Button btnCsvBonus3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBonus3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBonus1New;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

