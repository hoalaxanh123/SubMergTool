using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubMasterTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        List<Sub> LoadFile(string Text)
        {
            List<Sub> ListSubResult = new List<Sub>();
            List<String> temp1 = Regex.Split(Text, "\n\n").ToList();

            foreach (var item in temp1)
            {
                var temp = Regex.Split(item, "\n").ToList();
                Sub subTemp = new Sub();
                subTemp.Number = int.Parse(temp[0]);
                subTemp.Time = temp[1].ToString();
                string line = "";
                for (int i = 2; i < temp.Count; i++)
                {
                    line += temp[i].ToString();
                }
                subTemp.Content = line;
                ListSubResult.Add(subTemp);
            }
            return ListSubResult;
        }

        private void btn_ChooseColor1_Click(object sender, EventArgs e)
        {
            //DialogResult ret = colorDialog1.ShowDialog();
            //if (ret == DialogResult.OK)
            //{
            //    this.txt_Color1.Text = ColorTranslator.ToHtml(colorDialog1.Color);
            //    this.label1.BackColor = Color.Black;
            //    this.label1.ForeColor = colorDialog1.Color;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChoseEnFile_Click(object sender, EventArgs e)
        {
            ChooseFile("Chọn file EN Sub", this.txt_EnFile);
        }
        void ChooseFile(string Title, TextBox textBox)
        {
            openFileDialog1.Title = Title;
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                textBox.Text = openFileDialog1.FileName;
            }
        }

        private void btn_ChoseVnFile_Click(object sender, EventArgs e)
        {
            ChooseFile("Chọn file VN Sub", this.txt_VnFile);
        }

        private void btn_Do_Click(object sender, EventArgs e)
        {
            List<Sub> ListSub1 = new List<Sub>();
            List<Sub> ListSub2 = new List<Sub>();
            string One = File.ReadAllText(this.txt_EnFile.Text);
            string Two = File.ReadAllText(this.txt_VnFile.Text);
            ListSub1 = LoadFile(One);
            ListSub2 = LoadFile(Two);

            for (int i = 0; i < ListSub1.Count; i++)
            {
                ListSub1[i].Content = ListSub1[i].Content + "\n" + ListSub2[i].Content;
            }

            using (StreamWriter sw = new StreamWriter(this.txt_OutPut.Text))
            {

                foreach (Sub s in ListSub1)
                {
                    sw.WriteLine(s.Number);
                    sw.WriteLine(s.Time);
                    sw.WriteLine(s.Content);
                    sw.WriteLine("\n");
                }
            }

            MessageBox.Show("Done");
        }
    }
}
