using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnattach_Click(object sender, EventArgs e)
        {
            //Getting the Attachment File
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    textFile.Text += file.ToString() + @",";
                }
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587); //Connection Object
                client.UseDefaultCredentials = false; 
                client.EnableSsl = true; // Enabling secured Connection

                MailMessage message = new MailMessage(); // Email Object
                message.From = new MailAddress(txtreciever.Text); // Sender Email
                message.To.Add(txtreciever.Text); // Reciever emailid
                message.Body = txtbody.Text; // Body of the email
                message.Subject = txtsubject.Text; // Subject of the email
                
                #region 若有附加檔案
                if (!string.IsNullOrWhiteSpace(textFolder.Text))
                {
                    List<Attachment> attachments = new List<Attachment>();
                    string[] files = Directory.GetFiles(textFolder.Text, "*");

                    for (int i = 0; i < files.Length; i++)
                        attachments.Add(new Attachment(files[i]));

                    foreach (Attachment a in attachments) message.Attachments.Add(a);
                }

                if (!string.IsNullOrWhiteSpace(textFile.Text))
                {
                    List<Attachment> attachments = new List<Attachment>();
                    //string[] files = Directory.GetFiles(textFolder.Text, "*");
                    List<string> files = textFile.Text.Split(',').ToList<string>();

                    for (int i = 0; i < files.Count -1; i++)
                        attachments.Add(new Attachment(files[i]));

                    foreach (Attachment a in attachments) message.Attachments.Add(a);

                }
                #endregion

                // Setting Credential of gmail account
                client.Credentials = new System.Net.NetworkCredential(txtsender.Text, txtpass.Text); 
                Cursor.Current = Cursors.WaitCursor;

                //Sending Email
                client.Send(message);
                MessageBox.Show("Send!");
                Cursor.Current = Cursors.Default;
                message = null; // Free the memory
            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folder.SelectedPath;
                textFolder.Text = folderPath;
            }
        }

        private void radioBtnFolder_CheckedChanged(object sender, EventArgs e)
        {
            textFile.Text = "";
            btnSelectFolder.Enabled = true;
            btnSelectFile.Enabled = false;
        }

        private void radioBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            textFolder.Text = "";
            btnSelectFolder.Enabled = false;
            btnSelectFile.Enabled = true;
        }
    }
}
