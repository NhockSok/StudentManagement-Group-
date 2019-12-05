namespace thongke
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmamh = new System.Windows.Forms.ComboBox();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.grdthongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // cbmamh
            // 
            this.cbmamh.FormattingEnabled = true;
            this.cbmamh.Location = new System.Drawing.Point(101, 10);
            this.cbmamh.Name = "cbmamh";
            this.cbmamh.Size = new System.Drawing.Size(121, 21);
            this.cbmamh.TabIndex = 2;
            // 
            // txttenmh
            // 
            this.txttenmh.Location = new System.Drawing.Point(101, 39);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(121, 20);
            this.txttenmh.TabIndex = 3;
            // 
            // grdthongke
            // 
            this.grdthongke.AllowUserToAddRows = false;
            this.grdthongke.AllowUserToDeleteRows = false;
            this.grdthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdthongke.Location = new System.Drawing.Point(-17, 82);
            this.grdthongke.Name = "grdthongke";
            this.grdthongke.ReadOnly = true;
            this.grdthongke.Size = new System.Drawing.Size(533, 198);
            this.grdthongke.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 269);
            this.Controls.Add(this.grdthongke);
            this.Controls.Add(this.txttenmh);
            this.Controls.Add(this.cbmamh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Thống kê sinh viên theo môn học";
            ((System.ComponentModel.ISupportInitialize)(this.grdthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmamh;
        private System.Windows.Forms.TextBox txttenmh;
        private System.Windows.Forms.DataGridView grdthongke;
    }
}

