using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace quran
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
          //  string inputCKSFileName = @"C:\Users\M.Star\Desktop\121.docx";
          //  StreamReader CKSfileStream = new StreamReader(inputCKSFileName, Encoding.UTF8);
          //  string unicodeText = CKSfileStream.ReadLine();
          //  richTextBox1.Text = unicodeText;
          //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(unicodeText);
            int count = 0;
          // bytes=System.Text.Encoding.Convert(Encoding.ASCII, Encoding.UTF8,bytes);
          //unicodeText = Encoding.UTF8.GetString(bytes);
          //richTextBox2.Text = unicodeText;
            string fileName = textBox1.Text;//@"C:\Users\M.Star\Desktop\12.txt";
            using (StreamReader reader = Quran.OpenStreamReaderWithEncoding(fileName))
            { // true is auto-detection
                string line = reader.ReadToEnd();
                string[] ar = line.Split(',');
                
                foreach (var item in ar)
                {
                    //item.TrimStart();
                    string st = item.Trim();
                    richTextBox1.Text += "\t \"" + st + "\"," + Environment.NewLine;
                    count++;
                }
                
                // and so on...
            }
            label1.Text = count.ToString();
           // string[] tex = File.ReadAllLines(@"C:\Users\M.Star\Desktop\12.txt");
            //string tex = File.ReadAllText(@"C:\Users\M.Star\Desktop\121.docx", Encoding.UTF8);
            //richTextBox2.Text = tex;
            //
            ////OutputEncoding
            //foreach (var item in ar)
            //{
            //    richTextBox1.Text += "\"" + item + "\"," + Environment.NewLine;
            //}
           // richTextBox1.Text = tex;
          //  richTextBox1.Text += "ddddd" + Environment.NewLine;
          //  Quran qur = new Quran();
          //  //richTextBox1.Text += qur.ayat[i] + Environment.NewLine;
          //  //i++;
          //  List<string> lis = new System.Collections.Generic.List<string>();

          // lis= qur.find(textBox1.Text);

          //// Parallel.ForEach<string>(lis, (li) => { richTextBox1.Text += li.ToString(); });

          // foreach (var item in lis)
          // {
          //    richTextBox1.Text += item.ToString(); 
          // }
        }

      
    }
}
