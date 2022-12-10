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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task build = new Task(calling);
            build.Start();
            if (!Directory.Exists("template")) Directory.CreateDirectory("template");
            if (!File.Exists("template/codeCheck.cpp")) using (StreamWriter tw = new StreamWriter("template/codeCheck.cpp")) { tw.Write(""); }
            if (!File.Exists("template/codeAccepted.cpp")) using (StreamWriter tw = new StreamWriter("template/codeAccepted.cpp")){ tw.Write("");}
            if (!File.Exists("template/codeGen.cpp")) using (StreamWriter tw = new StreamWriter("template/codeGen.cpp")){ tw.Write("");}
            editorCodeCheck.Text = System.IO.File.ReadAllText(@"template\codeCheck.cpp");
            editorAccepted.Text = System.IO.File.ReadAllText(@"template\codeAccepted.cpp");
            editorTest.Text = System.IO.File.ReadAllText(@"template\codeGen.cpp");
        }
        private void calling()
        {
            if (Directory.Exists("processing")) Directory.Delete("processing", true);
            if (Directory.Exists("temp")) Directory.Delete("temp", true);
            if (Directory.Exists("external")) Directory.Delete("external", true);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Timer time = new Timer();
            time.Interval = 1;
            time.Tick += new EventHandler(countwordRefesh);
            time.Enabled = true;
        }

        private void countwordRefesh(object sender, EventArgs e)
        {
            int cur = 0;
            if (TabEditor.SelectedIndex == 0) cur = editorCodeCheck.SelectionStart;
            if (TabEditor.SelectedIndex == 1) cur = editorAccepted.SelectionStart;
            if (TabEditor.SelectedIndex == 2) cur = editorTest.SelectionStart;
            position.Text = "Pos: " + cur.ToString();
        }
        private void importCodeCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            importCodeCheck.Title = "Import Code Check";
            importCodeCheck.Filter = "C++ files|*.cpp";
            if(importCodeCheck.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                if((stream = importCodeCheck.OpenFile()) != null)
                { 
                    editorCodeCheck.Text = File.ReadAllText(importCodeCheck.FileName);
                    TabEditor.SelectedIndex = 0;
                    editorCodeCheck.Zoom = 100;
                    stream.Close();
                }
        }
        private void importAcceptedCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            importAccepted.Title = "Import Accepted Code";
            importAccepted.Filter = "C++ files|*.cpp";
            if (importAccepted.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                if ((stream = importAccepted.OpenFile()) != null)
                {
                    editorAccepted.Text = File.ReadAllText(importAccepted.FileName);
                    TabEditor.SelectedIndex = 1;
                    editorAccepted.Zoom = 100;
                    stream.Close();
                }
        }
        private void importTestGeratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            importTest.Title = "Import Test Generator";
            importTest.Filter = "C++ files|*.cpp";
            if (importTest.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                if ((stream = importTest.OpenFile()) != null)
                {
                    editorTest.Text = File.ReadAllText(importTest.FileName);
                    TabEditor.SelectedIndex = 2;
                    editorTest.Zoom = 100;
                    stream.Close();
                }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.Title = "Export file";
            saveFile.Filter = "C++ files|*.cpp";
            saveFile.FileName = "main.cpp";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream stream = saveFile.OpenFile();
                StreamWriter strw = new StreamWriter(stream);
                if(TabEditor.SelectedIndex == 0) strw.Write(editorCodeCheck.Text);
                if(TabEditor.SelectedIndex == 1) strw.Write(editorAccepted.Text);
                if(TabEditor.SelectedIndex == 2) strw.Write(editorTest.Text);
                strw.Close();
                stream.Close();
            }
        }
        string test = "";
        string time = "1000";
        private void buildAndRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2(editorCodeCheck.Text, editorAccepted.Text, editorTest.Text, test, time);
            child.StartPosition = FormStartPosition.CenterParent;
            child.ShowDialog();
            test = child.opentest;
            time = child.opentime;
        }
        private void showCodeCheckTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabEditor.SelectedIndex = 0;
        }
        private void showAcceptedCodeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabEditor.SelectedIndex = 1;
        }
        private void showTestGeneratorTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabEditor.SelectedIndex = 2;
        }

        private void aboutCodeCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.StartPosition = FormStartPosition.CenterParent;
            child.ShowDialog();
        }
    }
    public class Global
    {
        public static string lastCC = "";
        public static string lastAC = "";
        public static string lastTG = "";
        public static string checkerpath = "";
        public static bool usechecker = false;
    }
}
