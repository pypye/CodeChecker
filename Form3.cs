using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Code_Checker
{
    public partial class Form3 : Form
    {
        string CodeCheck = "";
        string Accepted = "";
        string TestGen = "";
        int test = 0, time = 0;
        public Form3(string textarea1, string textarea2, string textarea3, int data1, int data2)
        {
            InitializeComponent();
            CodeCheck = textarea1;
            Accepted = textarea2;
            TestGen = textarea3;
            test = data1; time = data2;
            value = "";
            failedinp = "";
            failedout = "";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Task build = new Task(callingProcess); 
            build.Start();
        }
        private void callingProcess()
        {
            generate();
            if (Global.lastCC != File.ReadAllText(@"temp\codeCheck.cpp") || Global.lastCC == "" || !File.Exists(@"processing\codeCheck.exe")) build(@"compiler\bin\g++.exe -std=c++14 temp\codeCheck.cpp -o processing\codeCheck", "Code Check", 2000);
            if (Global.lastAC != File.ReadAllText(@"temp\acceptedCode.cpp") || Global.lastAC == "" || !File.Exists(@"processing\acceptedCode.exe")) build(@"compiler\bin\g++.exe -std=c++14 temp\acceptedCode.cpp -o processing\acceptedCode", "Accepted Code", 3000);
            if (Global.lastTG != File.ReadAllText(@"temp\testGenerator.cpp") || Global.lastTG == "" || !File.Exists(@"processing\testGenerator.exe")) build(@"compiler\bin\g++.exe -std=c++14 temp\testGenerator.cpp -o processing\testGenerator", "Test Generator", 4000);
            if (Global.usechecker == true) copychecker();
            status.Text = "Prepairing";
            progressBar.Value = 5000;
            int div = 5000 / test;
            for (int i = 1; i <= test; i++)
            {
                status.Text = "Running on test " + i.ToString();
                progressBar.Value += div;
                clearWork();
                bool verdict = run(@"processing\testGenerator.exe", "Test Generator", i);
                if (!verdict)
                {
                    value = "Test Generator:" + System.Environment.NewLine + "Time limit exceeded/Runtime error on test " + i.ToString();
                    this.Close();
                }
                string[] input = Directory.GetFiles(".", "*.inp");
                string iPath = "";
                if (input.Length == 0)
                {
                    value = "Test Generator:" + System.Environment.NewLine + "No input";
                    this.Close();
                }
                else foreach (string filePath in input) iPath = filePath;
                while (File.Exists(iPath)) break;
                resetOut();
                verdict = run(@"processing\codeCheck.exe", "Code Check", i);
                if (!verdict)
                {
                    //value = "Code Check:" + System.Environment.NewLine + "Time limit exceeded/Runtime error on test " + i.ToString();
                    failedinp = File.ReadAllText(iPath);
                    this.Close();
                }
                string[] output = Directory.GetFiles(".", "*.out");
                string cPath = "";
                if (output.Length == 0)
                {
                    value = "Code Check:" + System.Environment.NewLine + "No output";
                    clearWork();
                    this.Close();
                }
                else foreach (string filePath in output) cPath = filePath;
                File.Move(cPath, @"processing\cc_" + cPath.Remove(0, 2));
                while (File.Exists(@"processing\cc_" + cPath.Remove(0, 2))) break;
                resetOut();
                verdict = run(@"processing\acceptedCode.exe", "Accepted Code", i);
                if (!verdict)
                {
                    value = "Accepted Code:" + System.Environment.NewLine + "Time limit exceeded/Runtime error on test " + i.ToString();
                    failedinp = File.ReadAllText(iPath);
                    this.Close();
                }
                output = Directory.GetFiles(".", "*.out");
                string aPath = "";
                if (output.Length == 0)
                {
                    value = "Accepted Code:" + System.Environment.NewLine + "No output";
                    clearWork();
                    this.Close();
                }
                else foreach (string filePath in output) aPath = filePath;
                File.Move(aPath, @"processing\ac_" + aPath.Remove(0, 2));
                while (File.Exists(@"processing\ac_" + aPath.Remove(0, 2))) break;
                if(Global.usechecker == false)
                {
                    bool res = compare(@"processing\cc_" + cPath.Remove(0, 2), @"processing\ac_" + aPath.Remove(0, 2));
                    if (res == false)
                    {
                        value = "Wrong answer on test " + i.ToString();
                        failedinp = File.ReadAllText(iPath);
                        string ccfailed = File.ReadAllText(@"processing\cc_" + cPath.Remove(0, 2));
                        string acfailed = File.ReadAllText(@"processing\ac_" + aPath.Remove(0, 2));
                        failedout = "Code Check Output:" + System.Environment.NewLine + ccfailed + System.Environment.NewLine + "Accepted Code Output:" + System.Environment.NewLine + acfailed;
                        clearWork();
                        this.Close();
                    }
                }
                else
                {
                    using (StreamWriter tw = new StreamWriter(@"external\external.cfg"))
                    {
                        tw.Write(iPath + Environment.NewLine + @"processing\cc_" + cPath.Remove(0, 2) + Environment.NewLine + @"processing\ac_" + aPath.Remove(0, 2));
                    }
                    int res = checker();
                    if (res != 0)
                    {
                        value = "Wrong answer on test " + i.ToString();
                        failedinp = File.ReadAllText(iPath);
                        string ccfailed = File.ReadAllText(@"processing\cc_" + cPath.Remove(0, 2));
                        string acfailed = File.ReadAllText(@"processing\ac_" + aPath.Remove(0, 2));
                        failedout = "Code Check Output:" + System.Environment.NewLine + ccfailed + System.Environment.NewLine + "Accepted Code Output:" + System.Environment.NewLine + acfailed;
                        clearWork();
                        this.Close();
                    }

                }
            }
            value = "Accepted";
            progressBar.Value = 10000;
            clearWork();
            this.Close();
        }
        private void generate()
        {
            status.Text = "Generating workstation";
            if (!Directory.Exists("processing")) Directory.CreateDirectory("processing");
            if (Directory.Exists("temp")) Directory.Delete("temp", true);
            Directory.CreateDirectory("temp");
            progressBar.Value = 250;
            status.Text = "Importing Code Check";
            using (StreamWriter tw = new StreamWriter("temp/codeCheck.cpp"))
            {
                tw.Write(CodeCheck);
            }
            progressBar.Value = 500;
            status.Text = "Importing Accepted Code";
            using (StreamWriter tw = new StreamWriter("temp/acceptedCode.cpp"))
            {
                tw.Write(Accepted);
            }
            progressBar.Value = 750;
            status.Text = "Importing Test Generator";
            using (StreamWriter tw = new StreamWriter("temp/testGenerator.cpp"))
            {
                tw.Write(TestGen);
            }
            progressBar.Value = 1000;
        }    
        private void build(string call, string stt, int percent)
        {
            status.Text = "Build " + stt;
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = @"/c " + call;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.WaitForExit();
            string error = process.StandardError.ReadToEnd();
            int result = process.ExitCode;
            if (result != 0)
            {
                value = stt + ":" + System.Environment.NewLine + error + System.Environment.NewLine + "========== Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped ==========";
                this.Close();
            }
            else progressBar.Value = percent;

            if (stt == "Code Check") Global.lastCC = File.ReadAllText(@"temp\codeCheck.cpp");
            if (stt == "Accepted Code") Global.lastAC = File.ReadAllText(@"temp\acceptedCode.cpp");
            if (stt == "Test Generator") Global.lastTG = File.ReadAllText(@"temp\testGenerator.cpp");
        }
        private void copychecker()
        {
            status.Text = "Copying External Judger";
            progressBar.Value = 4500;
            if (Directory.Exists("external")) Directory.Delete("external", true);
            Directory.CreateDirectory("external");
            File.Copy(Global.checkerpath, @"external\external.exe");
            while (File.Exists(@"external\external.exe")) break;
        }
        private bool run(string app, string stt, int nthtest)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = app;
            process.Start();
            bool limit = process.WaitForExit(time + 1000);
            if (!limit) process.Kill();
            int result = process.ExitCode;
            value = result.ToString();
            if (result != 0) return false;
            return true;
        }
        private void resetOut()
        {
            string[] srcOut = Directory.GetFiles(".", "*.out");
            foreach (string filePath in srcOut)
            {

                File.Delete(filePath);
                while (!File.Exists(filePath)) break;
            }
        }
        private void clearWork()
        {
            string[] srcInp = Directory.GetFiles(".", "*.inp", SearchOption.AllDirectories);
            string[] srcOut = Directory.GetFiles(".", "*.out", SearchOption.AllDirectories);
            foreach (string filePath in srcInp)
            {
                
                File.Delete(filePath);
                while (!File.Exists(filePath)) break;
            }
            foreach (string filePath in srcOut)
            {

                File.Delete(filePath);
                while (!File.Exists(filePath)) break;
            }
        }
        private bool compare(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++) if (file1[i] != file2[i]) return false;
                return true;
            }
            return false;
        }
        private int checker()
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = @"cmd.exe";
            process.StartInfo.Arguments = @"/c external\external.exe < external\external.cfg";
            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }
    }
}
