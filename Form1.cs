using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimplePasswordGenerator
{
    public partial class Form1 : Form
    {
        private string PasswordsList_OutputPath = "";
        private readonly List<char> ImportedAlphabet = new List<char>();

        private readonly List<char> DefaultAlphabet = new List<char>() { '0','1','2','3','4','5','6','7','8','9',
                                                                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                                                'J','K','L','M','O','P','Q','R','S', 'T', 'U',
                                                                'V', 'W', 'X', 'Y', 'Z',
                                                                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                                                'j','k','l','m','o','p','q','r','s', 't', 'u',
                                                                'v', 'w', 'x', 'y', 'x'};

        public Form1()
        {
            InitializeComponent();
        }

        private void isDefaultAlphabetUse_CheckedChanged(object sender, EventArgs e)
        {
            AlphabetPath_Button.Enabled = !isDefaultAlphabetUse.Checked;
            AlphabetPath_textBox.Enabled = !isDefaultAlphabetUse.Checked;
        }

        private void AlphabetPath_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog AlphabetPath_Input = new OpenFileDialog();
            if (AlphabetPath_Input.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(Path.GetFullPath(AlphabetPath_Input.FileName));
                foreach (char letter in reader.ReadToEnd())
                {
                    if (letter.Equals('\n'))
                    {
                        continue;
                    }

                    ImportedAlphabet.Add(letter);
                }
                AlphabetPath_textBox.Text = Path.GetFullPath(AlphabetPath_Input.FileName);
            }

        }

        private void OutputPath_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog PasswordsList_Output = new SaveFileDialog
            {
                DefaultExt = "txt"
            };
            if (PasswordsList_Output.ShowDialog() == DialogResult.OK)
            {
                PasswordsList_OutputPath = Path.GetFullPath(PasswordsList_Output.FileName);
                OutputPath_textBox.Text = Path.GetFullPath(PasswordsList_Output.FileName);
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!isDefaultAlphabetUse.Checked && ImportedAlphabet.Count == 0)
            {
                MessageBox.Show("Import alphabet or use default", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordsList_OutputPath == "")
            {
                MessageBox.Show("Select output path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Start.Enabled = false;
            Start.Visible = false;
            progressBar.Visible = true;
            uint combinationsCount = GetCombinationsCount();
            if (combinationsCount < int.MaxValue)
            {
                progressBar.Maximum = (int)combinationsCount;
            }
            else
            {
                progressBar.Maximum = int.MaxValue;
            }
            progressBar.Value = 0;
            int[] output = new int[(int)PassLen_Input.Value];
            StreamWriter streamWriter = new StreamWriter(PasswordsList_OutputPath, false);

            if (isDefaultAlphabetUse.Checked)
            {
                do // С использованием стандартного алфавита
                {
                    if (progressBar.Value != int.MaxValue)
                    {
                        progressBar.Value++;
                        progressBar.Update();
                    }

                    streamWriter.WriteLine(string.Join("", output.Select(d => DefaultAlphabet[d])));

                } while (Increment(DefaultAlphabet.Count, output));
            }
            else
            {
                do // С использованием заданного алфавита
                {
                    if (progressBar.Value != int.MaxValue)
                    {
                        progressBar.Value++;
                        progressBar.Update();
                    }

                    streamWriter.WriteLine(string.Join("", output.Select(d => ImportedAlphabet[d])));

                } while (Increment(ImportedAlphabet.Count, output));
            }

            streamWriter.Close();
            Start.Enabled = true;
            Start.Visible = true;
            progressBar.Visible = false;
        }

        private bool Increment(int baseNumber, int[] str)
        {
            int i = str.Length - 1;
            while (i >= 0 && str[i] == baseNumber - 1)
            {
                str[i] = 0;
                i -= 1;
            }

            if (i < 0)
            {
                return false;
            }
            str[i] += 1;
            return true;
        }

        private uint GetCombinationsCount()
        {
            if (isDefaultAlphabetUse.Checked)
            {
                return (uint)Math.Pow(DefaultAlphabet.Count, (double)PassLen_Input.Value);
            }
            else
            {
                return (uint)Math.Pow(ImportedAlphabet.Count, (double)PassLen_Input.Value);
            }
        }

        private void PassLen_Input_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = GetCombinationsCount().ToString() + " combinations";
        }
    }
}
