using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Code_Checker
{
    public partial class Form2 : Form
    {
        string CodeCheck = "";
        string Accepted = "";
        string TestGen = "";
        public Form2(string textarea1, string textarea2, string textarea3, string textarea4, string textarea5)
        {
            InitializeComponent();
            CodeCheck = textarea1;
            Accepted = textarea2;
            TestGen = textarea3;
            testInput.Text = textarea4;
            timeInput.Text = textarea5;
            opentest = testInput.Text;
            opentime = timeInput.Text;
            checkBox1.Checked = Global.usechecker;
            if (Global.checkerpath == "") checkName.Text = "No Program Imported";
            else{
                if (Path.GetFileName(Global.checkerpath).Length <= 25) checkName.Text = Path.GetFileName(Global.checkerpath);
                else
                {
                    checkName.Text = "";
                    for (int i = 0; i < 25; i++) checkName.Text += Path.GetFileName(Global.checkerpath)[i];
                    checkName.Text += "...";

                }
            }
        }
        private void Run_Click(object sender, EventArgs e)
        {
            Verdict.Text = "";
            failedInput.Text = "";
            failedOutput.Text = "";
            int test, time;
            if (int.TryParse(testInput.Text, out test) && test >= 1)
            {
                if (int.TryParse(timeInput.Text, out time) && time >= 1)
                {
                    if ((Global.usechecker == true && Global.checkerpath != "") || Global.usechecker == false)
                    {
                        Form3 run = new Form3(CodeCheck, Accepted, TestGen, test, time);
                        run.StartPosition = FormStartPosition.CenterParent;
                        run.ShowDialog();
                        Verdict.Text = run.value;
                        failedInput.Text = run.failedinp;
                        failedOutput.Text = run.failedout;
                    }
                    else Verdict.Text = "Invalid external judger";
                }
                else Verdict.Text = "Invalid time limit";
            }
            else Verdict.Text = "Invalid amount of test";
            
        }
        private void testInput_TextChanged(object sender, EventArgs e)
        {
            opentest = testInput.Text;
        }
        private void timeInput_TextChanged(object sender, EventArgs e)
        {
            opentime = timeInput.Text;
        }
        private void exportInput_Click(object sender, EventArgs e)
        {
            saveInput.Title = "Export Input";
            saveInput.Filter = "All files|*.*";
            saveInput.FileName = "failed.inp";
            if (saveInput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream stream = saveInput.OpenFile();
                StreamWriter strw = new StreamWriter(stream);
                strw.Write(failedInput.Text);
                strw.Close();
                stream.Close();
            }
        }
        private void exportOutput_Click(object sender, EventArgs e)
        {
            saveOutput.Title = "Export Output";
            saveOutput.Filter = "All files|*.*";
            saveOutput.FileName = "failed.out";
            if (saveOutput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream stream = saveOutput.OpenFile();
                StreamWriter strw = new StreamWriter(stream);
                strw.Write(failedOutput.Text);
                strw.Close();
                stream.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChecker.Title = "Import External Judger";
            openChecker.Filter = "Executable files|*.exe";
            openChecker.FileName = "";
            if (openChecker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Global.checkerpath = openChecker.FileName;
                if (Path.GetFileName(Global.checkerpath).Length <= 25) checkName.Text = Path.GetFileName(Global.checkerpath);
                else
                {
                    checkName.Text = "";
                    for (int i = 0; i < 25; i++) checkName.Text += Path.GetFileName(Global.checkerpath)[i];
                    checkName.Text += "...";

                }
                
            }
            else
            {
                checkName.Text = "No Program Imported";
                Global.checkerpath = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Global.usechecker = checkBox1.Checked;
        }
    }
}
