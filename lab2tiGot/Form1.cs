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

namespace lab2tiGot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Sort_letters()

        {

            Dictionary<char, float> letters = new Dictionary<char, float>();

            string text1 = Cipher_txt.Text;

            string text = text1.ToLower();

            char[] cipher = text.ToCharArray();

            char[] plane = new char[text.Length];

            char[] lat = new char[26] { 'e', 't', 'a', 'o', 'n', 'i', 's', 'r', 'h', 'l', 'd', 'c', 'u', 'p', 'f', 'm', 'w', 'y', 'b', 'g', 'v', 'k', 'q', 'x', 'j', 'z' };

            int kol = 0, m = 0;

            for (int i = 0; i < text.Length; i++)

            {

                if (Char.IsLetter(cipher[i]))

                {

                    if (letters.ContainsKey(cipher[i])) letters[cipher[i]] += 1;

                    else
                    {

                        letters.Add(cipher[i], 1);

                        m++;

                    }

                    kol++;

                }

            }

            Dictionary<char, float> letters1 = new Dictionary<char, float>();

            IOrderedEnumerable<KeyValuePair<char, float>> sortDict = from entry in letters orderby entry.Value descending select entry;

            letters1 = sortDict.ToDictionary(pair => pair.Key, pair => pair.Value);

            //Plane_txt.Text=Convert.ToString(letters1.First());

            for (int j = 0; j < m; j++)
            {

                for (int i = 0; i < text.Length; i++)

                {

                    if (Char.IsLetter(cipher[i]))

                    {

                        if (cipher[i] == letters1.Keys.ElementAt(j))

                        {

                            plane[i] = lat[j];

                        }

                    }

                    else plane[i] = cipher[i];

                }

            }

            foreach (KeyValuePair<char, float> kvp in letters1)

            {

                Frequency_txt.AppendText(Convert.ToString(kvp.Key) + " " + Convert.ToString(Math.Round((kvp.Value) / kol, 4) * 100) + "%" + Environment.NewLine);

            }

            string result = new string(plane);

            Plane_txt.Text = result;

        }

        private void Replace()

        {

            string text = Plane_txt.Text;

            char[] plane = text.ToCharArray();

            char num1, num2;

            num1 = Convert.ToChar((start.Text).ToLower());

            num2 = Convert.ToChar((end.Text).ToUpper());

            for (int i = 0; i < plane.Length; i++)

            {

                if (plane[i] == num1)

                {

                    plane[i] = num2;

                }

            }

            string result = new string(plane);

            Plane_txt.Text = result;

        }

        private void Read_from_file()

        {

            string path = @"C:\ti\l1g\lab2tiGot\new.txt";

            try

            {

                using (StreamReader sr = new StreamReader(path))

                {

                    Cipher_txt.Text = sr.ReadToEnd();

                }

            }

            catch (Exception e)

            {

                MessageBox.Show(e.Message);

            }
        }

        private void Look_plane_text()

        {

            string path = @"C:\ti\l1g\lab2tiGot\qw.txt";

            try

            {

                using (StreamReader sr = new StreamReader(path))

                {

                    MessageBox.Show(sr.ReadToEnd());

                }

            }

            catch (Exception e)

            {

                MessageBox.Show(e.Message);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)

        {

            Replace();

        }

        private void Raed_file_button_Click(object sender, EventArgs e)

        {

            Read_from_file();

        }



        private void Clear_button_Click_1(object sender, EventArgs e)
        {
            Cipher_txt.Clear();

            Plane_txt.Clear();
        }

        private void Plane_txt_button_Click_1(object sender, EventArgs e)
        {
            Look_plane_text();
        }

        private void Decryption_button_Click(object sender, EventArgs e)
        {
            Sort_letters();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Replace();
        }

        private void Frequency_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_TextChanged(object sender, EventArgs e)
        {

        }

        private void end_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cipher_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plane_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}