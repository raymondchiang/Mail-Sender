namespace EmailSender
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsender = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtreciever = new System.Windows.Forms.TextBox();
            this.textFile = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.radioBtnFolder = new System.Windows.Forms.RadioButton();
            this.radioBtnFile = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gmail Acc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receiver mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(64, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(61, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Content:";
            // 
            // txtsender
            // 
            this.txtsender.Location = new System.Drawing.Point(195, 9);
            this.txtsender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(428, 25);
            this.txtsender.TabIndex = 6;
            this.txtsender.Text = "@gmail.com";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(195, 44);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(428, 25);
            this.txtpass.TabIndex = 7;
            // 
            // txtreciever
            // 
            this.txtreciever.Location = new System.Drawing.Point(195, 83);
            this.txtreciever.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.Size = new System.Drawing.Size(428, 25);
            this.txtreciever.TabIndex = 8;
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(195, 171);
            this.textFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textFile.Name = "textFile";
            this.textFile.ReadOnly = true;
            this.textFile.Size = new System.Drawing.Size(341, 25);
            this.textFile.TabIndex = 9;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(195, 217);
            this.txtsubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(428, 25);
            this.txtsubject.TabIndex = 10;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(195, 267);
            this.txtbody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(428, 75);
            this.txtbody.TabIndex = 11;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Enabled = false;
            this.btnSelectFile.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectFile.Location = new System.Drawing.Point(549, 171);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(74, 25);
            this.btnSelectFile.TabIndex = 12;
            this.btnSelectFile.Text = "choose";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnattach_Click);
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsend.Location = new System.Drawing.Point(549, 360);
            this.btnsend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(73, 32);
            this.btnsend.TabIndex = 13;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectFolder.Location = new System.Drawing.Point(549, 127);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(74, 25);
            this.btnSelectFolder.TabIndex = 14;
            this.btnSelectFolder.Text = "choose";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // textFolder
            // 
            this.textFolder.Location = new System.Drawing.Point(195, 127);
            this.textFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFolder.Multiline = true;
            this.textFolder.Name = "textFolder";
            this.textFolder.ReadOnly = true;
            this.textFolder.Size = new System.Drawing.Size(341, 25);
            this.textFolder.TabIndex = 15;
            // 
            // radioBtnFolder
            // 
            this.radioBtnFolder.AutoSize = true;
            this.radioBtnFolder.Checked = true;
            this.radioBtnFolder.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnFolder.Location = new System.Drawing.Point(123, 129);
            this.radioBtnFolder.Name = "radioBtnFolder";
            this.radioBtnFolder.Size = new System.Drawing.Size(17, 16);
            this.radioBtnFolder.TabIndex = 16;
            this.radioBtnFolder.TabStop = true;
            this.radioBtnFolder.UseVisualStyleBackColor = true;
            this.radioBtnFolder.CheckedChanged += new System.EventHandler(this.radioBtnFolder_CheckedChanged);
            // 
            // radioBtnFile
            // 
            this.radioBtnFile.AutoSize = true;
            this.radioBtnFile.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnFile.Location = new System.Drawing.Point(123, 172);
            this.radioBtnFile.Name = "radioBtnFile";
            this.radioBtnFile.Size = new System.Drawing.Size(17, 16);
            this.radioBtnFile.TabIndex = 17;
            this.radioBtnFile.UseVisualStyleBackColor = true;
            this.radioBtnFile.CheckedChanged += new System.EventHandler(this.radioBtnFile_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(54, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(73, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioBtnFile);
            this.Controls.Add(this.radioBtnFolder);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Send Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsender;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtreciever;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.RadioButton radioBtnFolder;
        private System.Windows.Forms.RadioButton radioBtnFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

