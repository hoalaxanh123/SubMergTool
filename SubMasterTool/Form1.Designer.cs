namespace SubMasterTool
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
            this.txt_EnFile = new System.Windows.Forms.TextBox();
            this.txt_VnFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ChoseEnFile = new System.Windows.Forms.Button();
            this.btn_ChoseVnFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Do = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OutPut = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_EnFile
            // 
            this.txt_EnFile.Location = new System.Drawing.Point(101, 38);
            this.txt_EnFile.Name = "txt_EnFile";
            this.txt_EnFile.Size = new System.Drawing.Size(339, 20);
            this.txt_EnFile.TabIndex = 0;
            // 
            // txt_VnFile
            // 
            this.txt_VnFile.Location = new System.Drawing.Point(101, 73);
            this.txt_VnFile.Name = "txt_VnFile";
            this.txt_VnFile.Size = new System.Drawing.Size(339, 20);
            this.txt_VnFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "English sub file: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Viet sub file: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ChoseEnFile
            // 
            this.btn_ChoseEnFile.Location = new System.Drawing.Point(459, 38);
            this.btn_ChoseEnFile.Name = "btn_ChoseEnFile";
            this.btn_ChoseEnFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ChoseEnFile.TabIndex = 2;
            this.btn_ChoseEnFile.Text = "...";
            this.btn_ChoseEnFile.UseVisualStyleBackColor = true;
            this.btn_ChoseEnFile.Click += new System.EventHandler(this.btn_ChoseEnFile_Click);
            // 
            // btn_ChoseVnFile
            // 
            this.btn_ChoseVnFile.Location = new System.Drawing.Point(459, 71);
            this.btn_ChoseVnFile.Name = "btn_ChoseVnFile";
            this.btn_ChoseVnFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ChoseVnFile.TabIndex = 2;
            this.btn_ChoseVnFile.Text = "...";
            this.btn_ChoseVnFile.UseVisualStyleBackColor = true;
            this.btn_ChoseVnFile.Click += new System.EventHandler(this.btn_ChoseVnFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_EnFile);
            this.groupBox1.Controls.Add(this.btn_ChoseVnFile);
            this.groupBox1.Controls.Add(this.txt_OutPut);
            this.groupBox1.Controls.Add(this.txt_VnFile);
            this.groupBox1.Controls.Add(this.btn_ChoseEnFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // btn_Do
            // 
            this.btn_Do.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Do.Location = new System.Drawing.Point(157, 169);
            this.btn_Do.Name = "btn_Do";
            this.btn_Do.Size = new System.Drawing.Size(256, 60);
            this.btn_Do.TabIndex = 2;
            this.btn_Do.Text = "DO IT !!!";
            this.btn_Do.UseVisualStyleBackColor = true;
            this.btn_Do.Click += new System.EventHandler(this.btn_Do_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output:";
            // 
            // txt_OutPut
            // 
            this.txt_OutPut.Location = new System.Drawing.Point(101, 108);
            this.txt_OutPut.Name = "txt_OutPut";
            this.txt_OutPut.Size = new System.Drawing.Size(339, 20);
            this.txt_OutPut.TabIndex = 0;
            this.txt_OutPut.Text = "D:\\textfile.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Do);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Master Tool 1.0 - 1510289";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_EnFile;
        private System.Windows.Forms.TextBox txt_VnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ChoseEnFile;
        private System.Windows.Forms.Button btn_ChoseVnFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_OutPut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Do;
    }
}

