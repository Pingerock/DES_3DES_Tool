using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES_3DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_FileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text|*.txt|All|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                textBox1.Text = fileName;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && (radioButton_Encode.Checked || radioButton_Decode.Checked))
            {
                if (radioButton_3DES.Checked)
                {
                    if (radioButton_Encode.Checked)
                    {
                        TripleDES tripleDes = new TripleDES((ulong)numericUpDown1.Value, (ulong)numericUpDown2.Value,
                            (ulong)numericUpDown3.Value, textBox1.Text);
                        tripleDes.Encrypt();
                    }
                    else if (radioButton_Decode.Checked)
                    {
                        TripleDES tripleDes = new TripleDES((ulong)numericUpDown1.Value, (ulong)numericUpDown2.Value,
                            (ulong)numericUpDown3.Value, textBox1.Text);
                        tripleDes.Decrypt();
                    }
                    MessageBox.Show("Finished succesfully!");
                }
                else if (radioButton_DES.Checked)
                {
                    if (radioButton_Encode.Checked)
                    {
                        DES des = new DES((ulong)numericUpDown1.Value, textBox1.Text);
                        des.Encrypt();
                        des.Save_File(0);
                    }
                    else if (radioButton_Decode.Checked)
                    {
                        DES des = new DES((ulong)numericUpDown1.Value, textBox1.Text);
                        des.Decrypt();
                        des.Save_File(1);
                    }
                    MessageBox.Show("Finished succesfully!");
                }
            }
            else
            {
                MessageBox.Show("Input error.");
            }
        }
    }
}
