using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tak
{
    public partial class Form1 : Form
    {
        string liczbajeden, liczbadwa;
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int value1=0;

            if (radioButton1.Checked == true)
            {
                if (g.BackColor == Color.Black && gr.BackColor == Color.Black && gl.BackColor == Color.Black && s.BackColor == Color.Black && dl.BackColor == Color.Black && dr.BackColor == Color.Black && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 8;
                    value1 = 8;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.Black && gl.BackColor == Color.Black && s.BackColor == Color.White && dl.BackColor == Color.Black && dr.BackColor == Color.Black && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 0;
                    value1 = 0;
                }
                if (g.BackColor == Color.White && gr.BackColor == Color.Black && gl.BackColor == Color.White && s.BackColor == Color.White && dl.BackColor == Color.White && dr.BackColor == Color.Black && d.BackColor == Color.White)
                {
                    numericUpDown1.Value = 1;
                    value1 = 1;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.Black && gl.BackColor == Color.White && s.BackColor == Color.Black && dl.BackColor == Color.Black && dr.BackColor == Color.White && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 2;
                    value1 = 2;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.Black && gl.BackColor == Color.White && s.BackColor == Color.Black && dl.BackColor == Color.White && dr.BackColor == Color.Black && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 3;
                    value1 = 3;
                }
                if (g.BackColor == Color.White && gr.BackColor == Color.Black && gl.BackColor == Color.Black && s.BackColor == Color.Black && dl.BackColor == Color.White && dr.BackColor == Color.Black && d.BackColor == Color.White)
                {
                    numericUpDown1.Value = 4;
                    value1 = 4;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.White && gl.BackColor == Color.Black && s.BackColor == Color.Black && dl.BackColor == Color.White && dr.BackColor == Color.Black && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 5;
                    value1 = 5;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.White && gl.BackColor == Color.Black && s.BackColor == Color.Black && dl.BackColor == Color.Black && dr.BackColor == Color.Black && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 6;
                    value1 = 6;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.Black && gl.BackColor == Color.White && s.BackColor == Color.White && dl.BackColor == Color.White && dr.BackColor == Color.Black && d.BackColor == Color.White)
                {
                    numericUpDown1.Value = 7;
                    value1 = 7;
                }
                if (g.BackColor == Color.Black && gr.BackColor == Color.Black && gl.BackColor == Color.Black && s.BackColor == Color.Black && dl.BackColor == Color.White && dr.BackColor == Color.Black && d.BackColor == Color.Black)
                {
                    numericUpDown1.Value = 9;
                    value1 = 9;
                }
            }

            if (radioButton1.Checked == false)
            {
                if (numericUpDown1.Value == 0)
                {
                    numericUpDown1.Value = 0;
                    value1 = 0;
                    g.BackColor = Color.Black; gr.BackColor = Color.Black; gl.BackColor = Color.Black; s.BackColor = Color.White; dl.BackColor = Color.Black; dr.BackColor = Color.Black; d.BackColor = Color.Black;
                }
                if (numericUpDown1.Value == 8)
                {
                    numericUpDown1.Value = 8;
                    value1 = 8;
                    g.BackColor = Color.Black; gr.BackColor = Color.Black; gl.BackColor = Color.Black; s.BackColor = Color.Black; dl.BackColor = Color.Black; dr.BackColor = Color.Black; d.BackColor = Color.Black;
                }

                if (numericUpDown1.Value == 1)
                {
                    numericUpDown1.Value = 1;
                    value1 = 1;
                    g.BackColor = Color.White; gr.BackColor = Color.Black; gl.BackColor = Color.White; s.BackColor = Color.White; dl.BackColor = Color.White; dr.BackColor = Color.Black; d.BackColor = Color.White;
                }


                if (numericUpDown1.Value == 2)
                {
                    numericUpDown1.Value = 2;
                    value1 = 2;
                    g.BackColor = Color.Black; gr.BackColor = Color.Black; gl.BackColor = Color.White; s.BackColor = Color.Black; dl.BackColor = Color.Black; dr.BackColor = Color.White; d.BackColor = Color.Black;
                }


                if (numericUpDown1.Value == 3)
                {
                    numericUpDown1.Value = 3;
                    value1 = 3;
                    g.BackColor = Color.Black; gr.BackColor = Color.Black; gl.BackColor = Color.White; s.BackColor = Color.Black; dl.BackColor = Color.White; dr.BackColor = Color.Black; d.BackColor = Color.Black;
                }
                if (numericUpDown1.Value == 4)
                {
                    numericUpDown1.Value = 4;
                    value1 = 4;
                    g.BackColor = Color.White; gr.BackColor = Color.Black; gl.BackColor = Color.Black; s.BackColor = Color.Black; dl.BackColor = Color.White; dr.BackColor = Color.Black; d.BackColor = Color.White;
                }

                if (numericUpDown1.Value == 5)
                {
                    numericUpDown1.Value = 5;
                    value1 = 5;
                    g.BackColor = Color.Black; gr.BackColor = Color.White; gl.BackColor = Color.Black; s.BackColor = Color.Black; dl.BackColor = Color.White; dr.BackColor = Color.Black; d.BackColor = Color.Black;
                }

                if (numericUpDown1.Value == 6)
                {
                    numericUpDown1.Value = 6;
                    value1 = 6;
                    g.BackColor = Color.Black; gr.BackColor = Color.White; gl.BackColor = Color.Black; s.BackColor = Color.Black; dl.BackColor = Color.Black; dr.BackColor = Color.Black; d.BackColor = Color.Black;
                }

                if (numericUpDown1.Value == 7)
                {
                    numericUpDown1.Value = 7;
                    value1 = 7;
                    g.BackColor = Color.Black; gr.BackColor = Color.Black; gl.BackColor = Color.White; s.BackColor = Color.White; dl.BackColor = Color.White; dr.BackColor = Color.Black; d.BackColor = Color.White;
                }

                if (numericUpDown1.Value == 9)
                {
                    numericUpDown1.Value = 9;
                    value1 = 9;
                    g.BackColor = Color.Black; gr.BackColor = Color.Black; gl.BackColor = Color.Black; s.BackColor = Color.Black; dl.BackColor = Color.White; dr.BackColor = Color.Black; d.BackColor = Color.Black;
                }
            }
            int value2=0;
            if (radioButton1.Checked == true)
            {
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.Black && gl1.BackColor == Color.Black && s1.BackColor == Color.Black && dl1.BackColor == Color.Black && dr1.BackColor == Color.Black && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 8;
                    value2 = 8;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.Black && gl1.BackColor == Color.Black && s1.BackColor == Color.White && dl1.BackColor == Color.Black && dr1.BackColor == Color.Black && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 0;
                    value2 = 0;
                }
                if (g1.BackColor == Color.White && gr1.BackColor == Color.Black && gl1.BackColor == Color.White && s1.BackColor == Color.White && dl1.BackColor == Color.White && dr1.BackColor == Color.Black && d1.BackColor == Color.White)
                {
                    numericUpDown2.Value = 1;
                    value2 = 1;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.Black && gl1.BackColor == Color.White && s1.BackColor == Color.Black && dl1.BackColor == Color.Black && dr1.BackColor == Color.White && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 2;
                    value2 = 2;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.Black && gl1.BackColor == Color.White && s1.BackColor == Color.Black && dl1.BackColor == Color.White && dr1.BackColor == Color.Black && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 3;
                    value2 = 3;
                }
                if (g1.BackColor == Color.White && gr1.BackColor == Color.Black && gl1.BackColor == Color.Black && s1.BackColor == Color.Black && dl1.BackColor == Color.White && dr1.BackColor == Color.Black && d1.BackColor == Color.White)
                {
                    numericUpDown2.Value = 4;
                    value2 = 4;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.White && gl1.BackColor == Color.Black && s1.BackColor == Color.Black && dl1.BackColor == Color.White && dr1.BackColor == Color.Black && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 5;
                    value2 = 5;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.White && gl1.BackColor == Color.Black && s1.BackColor == Color.Black && dl1.BackColor == Color.Black && dr1.BackColor == Color.Black && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 6;
                    value2 = 6;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.Black && gl1.BackColor == Color.White && s1.BackColor == Color.White && dl1.BackColor == Color.White && dr1.BackColor == Color.Black && d1.BackColor == Color.White)
                {
                    numericUpDown2.Value = 7;
                    value2 = 7;
                }
                if (g1.BackColor == Color.Black && gr1.BackColor == Color.Black && gl1.BackColor == Color.Black && s1.BackColor == Color.Black && dl1.BackColor == Color.White && dr1.BackColor == Color.Black && d1.BackColor == Color.Black)
                {
                    numericUpDown2.Value = 9;
                    value2 = 9;
                }
            }
            if (radioButton1.Checked == false)
            {
                if (numericUpDown2.Value == 0)
                {
                    numericUpDown2.Value = 0;
                    value2 = 0;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.Black; gl1.BackColor = Color.Black; s1.BackColor = Color.White; dl1.BackColor = Color.Black; dr1.BackColor = Color.Black; d1.BackColor = Color.Black;
                }
                if (numericUpDown2.Value == 8)
                {
                    numericUpDown2.Value = 8;
                    value2 = 8;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.Black; gl1.BackColor = Color.Black; s1.BackColor = Color.Black; dl1.BackColor = Color.Black; dr1.BackColor = Color.Black; d1.BackColor = Color.Black;
                }

                if (numericUpDown2.Value == 1)
                {
                    numericUpDown2.Value = 1;
                    value2 = 1;
                    g1.BackColor = Color.White; gr1.BackColor = Color.Black; gl1.BackColor = Color.White; s1.BackColor = Color.White; dl1.BackColor = Color.White; dr1.BackColor = Color.Black; d1.BackColor = Color.White;
                }


                if (numericUpDown2.Value == 2)
                {
                    numericUpDown2.Value = 2;
                    value2 = 2;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.Black; gl1.BackColor = Color.White; s1.BackColor = Color.Black; dl1.BackColor = Color.Black; dr1.BackColor = Color.White; d1.BackColor = Color.Black;
                }


                if (numericUpDown2.Value == 3)
                {
                    numericUpDown2.Value = 3;
                    value2 = 3;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.Black; gl1.BackColor = Color.White; s1.BackColor = Color.Black; dl1.BackColor = Color.White; dr1.BackColor = Color.Black; d1.BackColor = Color.Black;
                }
                if (numericUpDown2.Value == 4)
                {
                    numericUpDown2.Value = 4;
                    value2 = 4;
                    g1.BackColor = Color.White; gr1.BackColor = Color.Black; gl1.BackColor = Color.Black; s1.BackColor = Color.Black; dl1.BackColor = Color.White; dr1.BackColor = Color.Black; d1.BackColor = Color.White;
                }

                if (numericUpDown2.Value == 5)
                {
                    numericUpDown2.Value = 5;
                    value2 = 5;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.White; gl1.BackColor = Color.Black; s1.BackColor = Color.Black; dl1.BackColor = Color.White; dr1.BackColor = Color.Black; d1.BackColor = Color.Black;
                }

                if (numericUpDown2.Value == 6)
                {
                    numericUpDown2.Value = 6;
                    value2 = 6;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.White; gl1.BackColor = Color.Black; s1.BackColor = Color.Black; dl1.BackColor = Color.Black; dr1.BackColor = Color.Black; d1.BackColor = Color.Black;
                }

                if (numericUpDown2.Value == 7)
                {
                    numericUpDown2.Value = 7;
                    value2 = 7;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.Black; gl1.BackColor = Color.White; s1.BackColor = Color.White; dl1.BackColor = Color.White; dr1.BackColor = Color.Black; d1.BackColor = Color.White;
                }

                if (numericUpDown2.Value == 9)
                {
                    numericUpDown2.Value = 9;
                    value2 = 9;
                    g1.BackColor = Color.Black; gr1.BackColor = Color.Black; gl1.BackColor = Color.Black; s1.BackColor = Color.Black; dl1.BackColor = Color.White; dr1.BackColor = Color.Black; d1.BackColor = Color.Black;
                }
            }
            /*if (czerwonyOFFCzarnyONToolStripMenuItem.Checked == true)
            {
                if (g.BackColor == Color.White) { g.BackColor = Color.Red; }
                if (gr.BackColor == Color.White) { gr.BackColor = Color.Red; }
                if (gl.BackColor == Color.White) { gl.BackColor = Color.Red; }
                if (s.BackColor == Color.White) { s.BackColor = Color.Red; }
                if (dl.BackColor == Color.White) { dl.BackColor = Color.Red; }
                if (dr.BackColor == Color.White) { dr.BackColor = Color.Red; }
                if (d.BackColor == Color.White) { d.BackColor = Color.Red; }


            }
            if (zielonyToolStripMenuItem.Checked == true)
            {
                if (g.BackColor == Color.White) { g.BackColor = Color.Green; }
                if (gr.BackColor == Color.White) { gr.BackColor = Color.Green; }
                if (gl.BackColor == Color.White) { gl.BackColor = Color.Green; }
                if (s.BackColor == Color.White) { s.BackColor = Color.Green; }
                if (dl.BackColor == Color.White) { dl.BackColor = Color.Green; }
                if (dr.BackColor == Color.White) { dr.BackColor = Color.Green; }
                if (d.BackColor == Color.White) { d.BackColor = Color.Green; }

            }
            if (czerwonyOFFCzarnyONToolStripMenuItem.Checked == true)
            {
                if (g1.BackColor == Color.White) { g1.BackColor = Color.Red; }
                if (gr1.BackColor == Color.White) { gr1.BackColor = Color.Red; }
                if (gl1.BackColor == Color.White) { gl1.BackColor = Color.Red; }
                if (s1.BackColor == Color.White) { s1.BackColor = Color.Red; }
                if (dl1.BackColor == Color.White) { dl1.BackColor = Color.Red; }
                if (dr1.BackColor == Color.White) { dr1.BackColor = Color.Red; }
                if (d1.BackColor == Color.White) { d1.BackColor = Color.Red; }


            }
            if (zielonyToolStripMenuItem.Checked == true)
            {
                if (g1.BackColor == Color.White) { g1.BackColor = Color.Green; }
                if (gr1.BackColor == Color.White) { gr1.BackColor = Color.Green; }
                if (gl1.BackColor == Color.White) { gl1.BackColor = Color.Green; }
                if (s1.BackColor == Color.White) { s1.BackColor = Color.Green; }
                if (dl1.BackColor == Color.White) { dl1.BackColor = Color.Green; }
                if (dr1.BackColor == Color.White) { dr1.BackColor = Color.Green; }
                if (d1.BackColor == Color.White) { d1.BackColor = Color.Green; }

            }*/
            liczbajeden = value1.ToString();
                liczbadwa = value2.ToString();
                int suma = value1 + value2;
                int roznica1 = value1 - value2;
                int roznica2 = value2 - value1;
                string sumas = suma.ToString();
                string roznica1s = roznica1.ToString();
                string roznica2s = roznica2.ToString();
                if (jednaLiczbaToolStripMenuItem.Checked == true) { Wynikbox.Text = liczbajeden+liczbadwa; }
                if (dwieLiczbyToolStripMenuItem.Checked == true) { Wynikbox.Text = liczbajeden +"," + liczbadwa; }
                if (sumaToolStripMenuItem.Checked == true) { Wynikbox.Text = sumas; }
                if (różnicaToolStripMenuItem.Checked == true) { Wynikbox.Text = roznica1s; }
                if (różnicaBAToolStripMenuItem.Checked == true) { Wynikbox.Text = roznica2s; }
           
      
        }
        private void g_Click(object sender, EventArgs e)
        {
            if (g.BackColor == Color.Black)
            {
                g.BackColor = Color.White;
            }
            else g.BackColor = Color.Black;
        }
        private void gr_Click(object sender, EventArgs e)
        {
            if (gr.BackColor == Color.Black)
            {
                gr.BackColor = Color.White;
            }
            else gr.BackColor = Color.Black;
        }

        private void gl_Click(object sender, EventArgs e)
        {
            if (gl.BackColor == Color.Black)
            {
                gl.BackColor = Color.White;
            }
            else gl.BackColor = Color.Black;
        }

        private void s_Click(object sender, EventArgs e)
        {
            if (s.BackColor == Color.Black)
            {
                s.BackColor = Color.White;
            }
            else s.BackColor = Color.Black;
        }

        private void d_Click(object sender, EventArgs e)
        {
            if (d.BackColor == Color.Black)
            {
                d.BackColor = Color.White;
            }
            else d.BackColor = Color.Black;
        }

        private void dr_Click(object sender, EventArgs e)
        {
            if (dr.BackColor == Color.Black)
            {
                dr.BackColor = Color.White;
            }
            else dr.BackColor = Color.Black;
        }

        private void dl_Click(object sender, EventArgs e)
        {
            if (dl.BackColor == Color.Black)
            {
                dl.BackColor = Color.White;
            }
            else dl.BackColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { radioButton1.Checked = false;radioButton2.Checked = true; }
        }

        private void dr1_Click(object sender, EventArgs e)
        {
            if (dr1.BackColor == Color.Black)
            {
                dr1.BackColor = Color.White;
            }
            else dr1.BackColor = Color.Black;
        }

        private void gr1_Click(object sender, EventArgs e)
        {
            if (gr1.BackColor == Color.Black)
            {
                gr1.BackColor = Color.White;
            }
            else gr1.BackColor = Color.Black;
        }

        private void g1_Click(object sender, EventArgs e)
        {
            if (g1.BackColor == Color.Black)
            {
                g1.BackColor = Color.White;
            }
            else g1.BackColor = Color.Black;
        }

        private void gl1_Click(object sender, EventArgs e)
        {
            if (gl1.BackColor == Color.Black)
            {
                gl1.BackColor = Color.White;
            }
            else gl1.BackColor = Color.Black;
        }

        private void s1_Click(object sender, EventArgs e)
        {
            if (s1.BackColor == Color.Black)
            {
                s1.BackColor = Color.White;
            }
            else s1.BackColor = Color.Black;
        }

        private void dl1_Click(object sender, EventArgs e)
        {
            if (dl1.BackColor == Color.Black)
            {
                dl1.BackColor = Color.White;
            }
            else dl1.BackColor = Color.Black;
        }

        private void d1_Click(object sender, EventArgs e)
        {
            if (d1.BackColor == Color.Black)
            {
                d1.BackColor = Color.White;
            }
            else d1.BackColor = Color.Black;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dwieLiczbyToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dwieLiczbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jednaLiczbaToolStripMenuItem.Checked = false;
            dwieLiczbyToolStripMenuItem.Checked = true;
            sumaToolStripMenuItem.Checked = false;
            różnicaToolStripMenuItem.Checked = false;
            różnicaBAToolStripMenuItem.Checked = false;

        }

        private void jednaLiczbaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            jednaLiczbaToolStripMenuItem.Checked = true;
            dwieLiczbyToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = false;
            różnicaToolStripMenuItem.Checked = false;
            różnicaBAToolStripMenuItem.Checked = false;
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jednaLiczbaToolStripMenuItem.Checked = false;
            dwieLiczbyToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = true;
            różnicaToolStripMenuItem.Checked = false;
            różnicaBAToolStripMenuItem.Checked = false;
        }

        private void różnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jednaLiczbaToolStripMenuItem.Checked = false;
            dwieLiczbyToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = false;
            różnicaToolStripMenuItem.Checked = true;
            różnicaBAToolStripMenuItem.Checked = false;
        }

        private void różnicaBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jednaLiczbaToolStripMenuItem.Checked = false;
            dwieLiczbyToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = false;
            różnicaToolStripMenuItem.Checked = false;
            różnicaBAToolStripMenuItem.Checked = true;
        }

        
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo wysInfo = new ProcessStartInfo("https://pl.wikipedia.org/wiki/Wy%C5%9Bwietlacz_siedmiosegmentowy");
            Process.Start(wysInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void czarnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.Green;
            radioButton2.BackColor = Color.Green;
            label1.BackColor = Color.Green;
            czarnyToolStripMenuItem.Checked = true;
            szaryToolStripMenuItem.Checked = false;
            białyToolStripMenuItem.Checked = false;
            czerwonyToolStripMenuItem.Checked = false;
            niebieskiToolStripMenuItem.Checked = false;
            czarnyToolStripMenuItem2.Checked = false;
                
        }

        private void szaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.Gray;
            radioButton2.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            czarnyToolStripMenuItem.Checked = false;
            szaryToolStripMenuItem.Checked = true;
            białyToolStripMenuItem.Checked = false;
            czerwonyToolStripMenuItem.Checked = false;
            niebieskiToolStripMenuItem.Checked = false;
            czarnyToolStripMenuItem2.Checked = false;
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void białyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            label1.BackColor = Color.White;
            czarnyToolStripMenuItem.Checked = false;
            szaryToolStripMenuItem.Checked = false;
            białyToolStripMenuItem.Checked = true;
            czerwonyToolStripMenuItem.Checked = false;
            niebieskiToolStripMenuItem.Checked = false;
            czarnyToolStripMenuItem2.Checked = false;
        }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.Red;
            radioButton2.BackColor = Color.Red;
            label1.BackColor = Color.Red;
            czarnyToolStripMenuItem.Checked = false;
            szaryToolStripMenuItem.Checked = false;
            białyToolStripMenuItem.Checked = false;
            czerwonyToolStripMenuItem.Checked = true;
            niebieskiToolStripMenuItem.Checked = false;
            czarnyToolStripMenuItem2.Checked = false;
        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.Blue;
            radioButton2.BackColor = Color.Blue;
            label1.BackColor = Color.Blue;
            czarnyToolStripMenuItem.Checked = false;
            szaryToolStripMenuItem.Checked = false;
            białyToolStripMenuItem.Checked = false;
            czerwonyToolStripMenuItem.Checked = false;
            niebieskiToolStripMenuItem.Checked = true;
            czarnyToolStripMenuItem2.Checked = false;
        }

        private void czarnyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.Black;
            radioButton2.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            czarnyToolStripMenuItem.Checked = false;
            szaryToolStripMenuItem.Checked = false;
            białyToolStripMenuItem.Checked = false;
            czerwonyToolStripMenuItem.Checked = false;
            niebieskiToolStripMenuItem.Checked = false;
            czarnyToolStripMenuItem2.Checked = true;
        }

        private void czarnyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            czarnyToolStripMenuItem1.Checked = true;
            niebieskiToolStripMenuItem1.Checked = false;
            czerwonyToolStripMenuItem1.Checked = false;
            białyToolStripMenuItem1.Checked = false;
            zielonyToolStripMenuItem.Checked = false;

        }

        private void niebieskiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Blue;
            radioButton2.ForeColor = Color.Blue;
            label1.ForeColor = Color.Blue;
            czarnyToolStripMenuItem1.Checked = false;
            niebieskiToolStripMenuItem1.Checked = true;
            czerwonyToolStripMenuItem1.Checked = false;
            białyToolStripMenuItem1.Checked = false;
            zielonyToolStripMenuItem.Checked = false;

        }

        private void czerwonyToolStripMenuItem1_Click(object sender, EventArgs e)

        {
            radioButton1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Red;
            label1.ForeColor = Color.Red;
            czarnyToolStripMenuItem1.Checked = false;
            niebieskiToolStripMenuItem1.Checked = false;
            czerwonyToolStripMenuItem1.Checked = true;
            białyToolStripMenuItem1.Checked = false;
            zielonyToolStripMenuItem.Checked = false;

        }

        private void białyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            czarnyToolStripMenuItem1.Checked = false;
            niebieskiToolStripMenuItem1.Checked = false;
            czerwonyToolStripMenuItem1.Checked = false;
            białyToolStripMenuItem1.Checked = true;
            zielonyToolStripMenuItem.Checked = false;
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Green;
            radioButton2.ForeColor = Color.Green;
            label1.ForeColor = Color.Green;
            czarnyToolStripMenuItem1.Checked = false;
            niebieskiToolStripMenuItem1.Checked = false;
            czerwonyToolStripMenuItem1.Checked = false;
            białyToolStripMenuItem1.Checked = false;
            zielonyToolStripMenuItem.Checked = true;
        }

        private void obejrzyjFilmOSSDYoutubeJęzykAngielskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo wysYT = new ProcessStartInfo("https://www.youtube.com/watch?v=smeUN1Bxj3M");
            Process.Start(wysYT); 
        }

        private void schematLiczbNaWyświetlaczuSSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sch = new ProcessStartInfo("http://www.physics.udel.edu/~watson/scen103/colloq2000/images/7seg1.gif");
            Process.Start(sch);
        
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
