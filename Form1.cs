using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace norm
{
    public partial class Form1 : Form
    {
        //browsers
        string ChromeId     = "Google.Chrome";
        string FirefoxId    = "Mozilla.Firefox";
        string OperaId      = "Opera.Opera";
        string OperaGXId    = "Opera.OperaGX";

        //soft
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string ids = "";

            if (checkBoxChrome.Checked)
            {
                ids += ChromeId + " ";
            }

            if (checkBoxFirefox.Checked)
            {
                ids += FirefoxId + " ";
            }

            if (checkBoxOpera.Checked)
            {
                ids += OperaId + " ";
            }

            if (checkBoxOperaGX.Checked)
            {
                ids += OperaGXId + " ";
            }

            ids = ids.Trim();

            if (!string.IsNullOrEmpty(ids))
            {
                progressBar1.Visible    = true;
                button1.Enabled         = false;

                await installProgram(ids);                
            }
               
            else
            {
                label2.Text = "Egor";
            }
        }

        private async Task installProgram(string id)
        {
            try
            {
                using(Process process = new Process())
                {
                    label2.Text                                  = "Статус: Установка";

                    process.StartInfo.FileName                   = "cmd.exe";                
                    process.StartInfo.Arguments                  = $"/C winget install {id} --silent";                
                    process.StartInfo.RedirectStandardOutput     = true;
                    process.StartInfo.RedirectStandardError      = true;
                    process.StartInfo.UseShellExecute            = false;                
                    process.StartInfo.CreateNoWindow             = true;        
                    
                    process.Start();
                    
                    string result = await process.StandardOutput.ReadToEndAsync();               
                    string error = await process.StandardError.ReadToEndAsync();

                    await Task.Run(() => process.WaitForExit());

                    if (!string.IsNullOrEmpty(error))
                    {
                        progressBar1.Visible    = false;
                        button1.Enabled         = true;
                        label2.Text             = "Статус: Ошибка при установке";
                    }
                    else
                    {
                        progressBar1.Visible    = false;
                        button1.Enabled         = true;
                        label2.Text             = "Статус: Установка завершена";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
