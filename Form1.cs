using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;


namespace KizmaBirader
{
    public partial class Form1 : Form
    {


        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public static void SesAyarla(int volume)
        {
            int NewVolume = ((ushort.MaxValue / 100) * volume);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }




        public Form1()
        {
            InitializeComponent();
            //oyun taşlarını png yapmak için
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox1.Controls.Add(pictureBox5);
            pictureBox1.Controls.Add(pictureBox10);
            pictureBox1.Controls.Add(pictureBox11);
            pictureBox1.Controls.Add(pictureBox12);
            pictureBox1.Controls.Add(pictureBox13);
            pictureBox1.Controls.Add(pictureBox14);
            pictureBox1.Controls.Add(pictureBox15);
            pictureBox1.Controls.Add(pictureBox16);
            pictureBox1.Controls.Add(pictureBox17);
            pictureBox1.Controls.Add(pictureBox18);
            pictureBox1.Controls.Add(pictureBox19);
            pictureBox1.Controls.Add(pictureBox20);
            pictureBox1.Controls.Add(pictureBox21);

            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
            pictureBox19.BackColor = Color.Transparent;
            pictureBox20.BackColor = Color.Transparent;
            pictureBox21.BackColor = Color.Transparent;
        }

        Random zar = new Random();
        int[] konx = new int[] { 13, 62, 116, 169, 236, 236, 236, 236, 236, 295, 351, 351, 351, 351, 351, 402, 458, 515, 569, 569, 569, 516, 459, 402, 351, 351, 351, 351, 351, 295, 236, 236, 236, 236, 236, 170, 116, 62, 13, 13 };
        int[] kony = new int[] { 236, 236, 236, 236, 236, 176, 118, 62, 12, 12, 12, 61, 116, 168, 231, 231, 231, 231, 231, 293, 349, 349, 349, 349, 349, 405, 458, 512, 573, 573, 573, 517, 460, 404, 350, 350, 350, 350, 350, 294 };

        int[] mavikonx = new int[] { 351, 351, 351, 351, 351, 402, 458, 515, 569, 569, 569, 516, 459, 402, 351, 351, 351, 351, 351, 295, 236, 236, 236, 236, 236, 170, 116, 62, 13, 13, 13, 62, 116, 169, 236, 236, 236, 236, 236, 295 };
        int[] mavikony = new int[] { 12, 61, 116, 168, 231, 231, 231, 231, 231, 293, 349, 349, 349, 349, 349, 405, 458, 512, 573, 573, 573, 517, 460, 404, 350, 350, 350, 350, 350, 294, 236, 236, 236, 236, 236, 176, 118, 62, 12, 12 };

        int[] yeşilkonx = new int[] { 569, 516, 459, 402, 351, 351, 351, 351, 351, 295, 236, 236, 236, 236, 236, 170, 116, 62, 13, 13, 13, 62, 116, 169, 236, 236, 236, 236, 236, 295, 351, 351, 351, 351, 351, 402, 458, 515, 569, 569 };
        int[] yeşilkony = new int[] { 349, 349, 349, 349, 349, 405, 458, 512, 573, 573, 573, 517, 460, 404, 350, 350, 350, 350, 350, 294, 236, 236, 236, 236, 236, 176, 118, 62, 12, 12, 12, 61, 116, 168, 231, 231, 231, 231, 231, 293 };

        int[] sarıkonx = new int[] { 236, 236, 236, 236, 236, 170, 116, 62, 13, 13, 13, 62, 116, 169, 236, 236, 236, 236, 236, 295, 351, 351, 351, 351, 351, 402, 458, 515, 569, 569, 569, 516, 459, 402, 351, 351, 351, 351, 351, 295 };
        int[] sarıkony = new int[] { 573, 517, 460, 404, 350, 350, 350, 350, 350, 294, 236, 236, 236, 236, 236, 176, 118, 62, 12, 12, 12, 61, 116, 168, 231, 231, 231, 231, 231, 293, 349, 349, 349, 349, 349, 405, 458, 512, 573, 573 };



        int[] konredx = new int[] { 67, 123, 180, 234 };
        int[] konredy = new int[] { 292, 292, 292, 292 };

        int[] konbluex = new int[] { 292, 292, 292, 292 };
        int[] konbluey = new int[] { 65, 121, 178, 232 };

        int[] kongreenx = new int[] { 518, 464, 407, 350 };
        int[] kongreeny = new int[] { 292, 292, 292, 292 };

        int[] konyellowx = new int[] { 292, 292, 292, 292 };
        int[] konyellowy = new int[] { 518, 462, 404, 351 };

        string[] sıralama = new string[] { "0","0","0","0" };

        int zarred = 0, redtaskon = 0, redbitis = 0;
        int zarblue = 0, bluetaskon = 0, bluebitis = 0;
        int zargreen = 0, greentaskon = 0, greenbitis = 0;
        int zaryellow = 0, yellowtaskon = 0, yellowbitis = 0;
        int oto = 0;

        bool startred = false;
        bool startblue = false;
        bool startgreen = false;
        bool startyellow = false;

        //Mavi taş ilerleme
        private void button3_Click(object sender, EventArgs e)
        {
            bluetaskon += zarblue;

            //4. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 6)
            {
                pictureBox13.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 6)
            {
                bluetaskon -= 40;
                bluebitis = 7;
            }
            if (bluebitis == 7)
            {
                if (bluetaskon >= 0)
                {
                    pictureBox13.Location = new Point(konbluex[0], konbluey[0]);
                    bluetaskon = 0;
                    bluebitis = 8;
                    startblue = false;
                    listekle("Mavi Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Mavi Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Mavi Oyuncu";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox13.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //3. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 4)
            {
                pictureBox11.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 4)
            {
                bluetaskon -= 40;
                bluebitis = 5;
            }
            if (bluebitis == 5)
            {
                if (bluetaskon >= 2)
                {
                    pictureBox11.Location = new Point(konbluex[1], konbluey[1]);
                    bluetaskon = 0;
                    bluebitis = 6;
                    startblue = false;
                    listekle("Mavi Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox11.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //2. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 2)
            {
                pictureBox12.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 2)
            {
                bluetaskon -= 40;
                bluebitis = 3;
            }
            if (bluebitis == 3)
            {
                if (bluetaskon >= 2)
                {
                    pictureBox12.Location = new Point(konbluex[2], konbluey[2]);
                    bluetaskon = 0;
                    bluebitis = 4;
                    startblue = false;
                    listekle("Mavi Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox12.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //1. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 0)
            {
                pictureBox10.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 0)
            {
                bluetaskon -= 40;
                bluebitis = 1;
            }
            if (bluebitis == 1)
            {
                if (bluetaskon >= 3)
                {
                    pictureBox10.Location = new Point(konbluex[3], konbluey[3]);
                    bluetaskon = 0;
                    bluebitis = 2;
                    startblue = false;
                    listekle("Mavi Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox10.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            button3.Enabled = false;
            button6.Enabled = true;
        }

        //yeşil taş ilerleme
        private void button5_Click(object sender, EventArgs e)
        {
            greentaskon += zargreen;

            //4. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 6)
            {
                pictureBox16.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 6)
            {
                greentaskon -= 40;
                greenbitis = 7;
            }
            if (greenbitis == 7)
            {
                if (greentaskon >= 0)
                {
                    pictureBox16.Location = new Point(kongreenx[0], kongreeny[0]);
                    greentaskon = 0;
                    greenbitis = 8;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Yeşil Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Yeşil Oyuncu";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox16.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //3. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 4)
            {
                pictureBox17.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 4)
            {
                greentaskon -= 40;
                greenbitis = 5;
            }
            if (greenbitis == 5)
            {
                if (greentaskon >= 1)
                {
                    pictureBox17.Location = new Point(kongreenx[1], kongreeny[1]);
                    greentaskon = 0;
                    greenbitis = 6;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox17.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //2. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 2)
            {
                pictureBox14.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 2)
            {
                greentaskon -= 40;
                greenbitis = 3;
            }
            if (greenbitis == 3)
            {
                if (greentaskon >= 2)
                {
                    pictureBox14.Location = new Point(kongreenx[2], kongreeny[2]);
                    greentaskon = 0;
                    greenbitis = 4;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox14.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //1. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 0)
            {
                pictureBox15.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 0)
            {
                greentaskon -= 40;
                greenbitis = 1;
            }
            if (greenbitis == 1)
            {
                if (greentaskon >= 3)
                {
                    pictureBox15.Location = new Point(kongreenx[3], kongreeny[3]);
                    greentaskon = 0;
                    greenbitis = 2;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox15.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            button5.Enabled = false;
            button8.Enabled = true;
        }

        //bot hızı
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Anında")
                timer1.Interval = 1;
            else if (comboBox1.SelectedItem == "0,5 Saniye")
                timer1.Interval = 500;
            else if (comboBox1.SelectedItem == "1 Saniye")
                timer1.Interval = 1000;
            else if (comboBox1.SelectedItem == "1,5 Saniye")
                timer1.Interval = 1500;
            else if (comboBox1.SelectedItem == "2 Saniye")
                timer1.Interval = 2000;

        }

        //sarı taş zar atma
        private void button8_Click(object sender, EventArgs e)
        {
            zaryellow = zar.Next(1, 7);
            SoundPlayer zarses = new SoundPlayer(KizmaBirader.Properties.Resources.Rolling_Dices_Sound_Effect);
            zarses.Play();
            //axWindowsMediaPlayer1.URL = "Properties.Resources.Rolling_Dices_Sound_Effect";
            if (zaryellow == 1)
            {
                pictureBox9.Image = Properties.Resources._1;
            }
            else if (zaryellow == 2)
            {
                pictureBox9.Image = Properties.Resources._2;

            }
            else if (zaryellow == 3)
            {
                pictureBox9.Image = Properties.Resources._3;

            }
            else if (zaryellow == 4)
            {
                pictureBox9.Image = Properties.Resources._4;

            }
            else if (zaryellow == 5)
            {
                pictureBox9.Image = Properties.Resources._5;

            }
            else if (zaryellow == 6)
            {
                pictureBox9.Image = Properties.Resources._6;
            }

            if (startyellow == true)
            {
                button7.Enabled = true;
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = false;
                button1.Enabled = true;
            }

            if (zaryellow == 6)
            {
                startyellow = true;
                if (pictureBox21.Location.X == 68 && pictureBox21.Location.Y == 575)
                {
                    pictureBox21.Location = new Point(sarıkonx[0], sarıkony[0]);
                    listekle("Sarı Oyuncu 1. Taşını Çıkardı");
                    sarıye();
                }
                if (pictureBox19.Location.X == 68 && pictureBox19.Location.Y == 515 && pictureBox21.Location.X == konyellowx[3] && pictureBox21.Location.Y == konyellowy[3])
                {
                    pictureBox19.Location = new Point(sarıkonx[0], sarıkony[0]);
                    listekle("Sarı Oyuncu 2. Taşını Çıkardı");
                    sarıye();
                }
                if (pictureBox20.Location.X == 13 && pictureBox20.Location.Y == 576 && pictureBox19.Location.X == konyellowx[2] && pictureBox19.Location.Y == konyellowy[2])
                {
                    pictureBox20.Location = new Point(sarıkonx[0], sarıkony[0]);
                    listekle("Sarı Oyuncu 3. Taşını Çıkardı");
                    sarıye();
                }
                if (pictureBox18.Location.X == 12 && pictureBox18.Location.Y == 514 && pictureBox20.Location.X == konyellowx[1] && pictureBox20.Location.Y == konyellowy[1])
                {
                    pictureBox18.Location = new Point(sarıkonx[0], sarıkony[0]);
                    listekle("Sarı Oyuncu 4. Taşını Çıkardı");
                    sarıye();
                }
            }
        }
        //sarı taş ilerleme
        private void button7_Click(object sender, EventArgs e)
        {
            yellowtaskon += zaryellow;

            //4. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 6)
            {
                pictureBox18.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 6)
            {
                yellowtaskon -= 40;
                yellowbitis = 7;
            }
            if (yellowbitis == 7)
            {
                if (yellowtaskon >= 0)
                {
                    pictureBox18.Location = new Point(konyellowx[0], konyellowy[0]);
                    yellowtaskon = 0;
                    yellowbitis = 8;
                    startyellow = false;
                    listekle("Sarı Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Sarı Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Sarı Oyuncu";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox18.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //3. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 4)
            {
                pictureBox20.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 4)
            {
                yellowtaskon -= 40;
                yellowbitis = 5;
            }
            if (yellowbitis == 5)
            {
                if (yellowtaskon >= 1)
                {
                    pictureBox20.Location = new Point(konyellowx[1], konyellowy[1]);
                    yellowtaskon = 0;
                    yellowbitis = 6;
                    startyellow = false;
                    listekle("Sarı Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox20.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //2. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 2)
            {
                pictureBox19.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 2)
            {
                yellowtaskon -= 40;
                yellowbitis = 3;
            }
            if (yellowbitis == 3)
            {
                if (yellowtaskon >= 2)
                {
                    pictureBox19.Location = new Point(konyellowx[2], konyellowy[2]);
                    yellowtaskon = 0;
                    yellowbitis = 4;
                    startyellow = false;
                    listekle("Sarı Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox19.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //1. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 0)
            {
                pictureBox21.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 0)
            {
                yellowtaskon -= 40;
                yellowbitis = 1;
            }
            if (yellowbitis == 1)
            {
                if (yellowtaskon >= 3)
                {
                    pictureBox21.Location = new Point(konyellowx[3], konyellowy[3]);
                    yellowtaskon = 0;
                    yellowbitis = 2;
                    startyellow = false;
                    listekle("Sarı Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox21.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            button7.Enabled = false;
            button1.Enabled = true;
        }

        //by emre can çimke yazısı
        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Emre-Can");
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Underline);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Underline);

        }

        //ses kontrol check box'ı
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                SesAyarla(0);
            else if (checkBox1.Checked == true)
                SesAyarla(100);
        }

        //listbox temizle butonunun görünürlüğü için
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            button10.Visible = true;
            timer2.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button10.Visible == false)
                button10.Visible = true;
            else
            {
                button10.Visible = false;
                timer2.Enabled = false;
            }

        }

        //listbox'ı temizle buttonu için
        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //yeniden başla buttonu için
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //oto ilerleme için
        private void timer1_Tick(object sender, EventArgs e)
        {
            oto++;
            if (oto == 1)
                button4.PerformClick();
            if (oto == 2)
            {
                if (button3.Enabled == false)
                    oto++;
                else
                    button3.PerformClick();
            }
            if (oto == 3)
                button6.PerformClick();
            if (oto == 4)
            {
                if (button5.Enabled == false)
                    oto++;
                else
                    button5.PerformClick();
            }

            if (oto == 5)
                button8.PerformClick();
            if (oto == 6)
            {
                if (button7.Enabled == true)
                    button7.PerformClick();

                timer1.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zargreen = zar.Next(1, 7);
            SoundPlayer zarses = new SoundPlayer(KizmaBirader.Properties.Resources.Rolling_Dices_Sound_Effect);
            zarses.Play();
            //axWindowsMediaPlayer1.URL = "Properties.Resources.Rolling_Dices_Sound_Effect";
            if (zargreen == 1)
            {
                pictureBox8.Image = Properties.Resources._1;
            }
            else if (zargreen == 2)
            {
                pictureBox8.Image = Properties.Resources._2;

            }
            else if (zargreen == 3)
            {
                pictureBox8.Image = Properties.Resources._3;

            }
            else if (zargreen == 4)
            {
                pictureBox8.Image = Properties.Resources._4;

            }
            else if (zargreen == 5)
            {
                pictureBox8.Image = Properties.Resources._5;

            }
            else if (zargreen == 6)
            {
                pictureBox8.Image = Properties.Resources._6;
            }

            if (startgreen == true)
            {
                button5.Enabled = true;
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = false;
                button8.Enabled = true;
            }

            if (zargreen == 6)
            {
                startgreen = true;
                if (pictureBox15.Location.X == 570 && pictureBox15.Location.Y == 515)
                {
                    pictureBox15.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                    listekle("Yeşil Oyuncu 1. Taşını Çıkardı");
                    yeşilye();
                }
                if (pictureBox14.Location.X == 513 && pictureBox14.Location.Y == 517 && pictureBox15.Location.X == kongreenx[3] && pictureBox15.Location.Y == kongreeny[3])
                {
                    pictureBox14.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                    listekle("Yeşil Oyuncu 2. Taşını Çıkardı");
                    yeşilye();
                }
                if (pictureBox17.Location.X == 570 && pictureBox17.Location.Y == 577 && pictureBox14.Location.X == kongreenx[2] && pictureBox14.Location.Y == kongreeny[2])
                {
                    pictureBox17.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                    listekle("Yeşil Oyuncu 3. Taşını Çıkardı");
                    yeşilye();
                }
                if (pictureBox16.Location.X == 513 && pictureBox16.Location.Y == 574 && pictureBox17.Location.X == kongreenx[1] && pictureBox17.Location.Y == kongreeny[1])
                {
                    pictureBox16.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                    listekle("Yeşil Oyuncu 4. Taşını Çıkardı");
                    yeşilye();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            zarred = zar.Next(1, 7);
            SoundPlayer zarses = new SoundPlayer(KizmaBirader.Properties.Resources.Rolling_Dices_Sound_Effect);
            zarses.Play();
            //axWindowsMediaPlayer1.URL = "Properties.Resources.Rolling_Dices_Sound_Effect";
            if (zarred == 1)
            {
                pictureBox6.Image = Properties.Resources._1;
            }
            else if (zarred == 2)
            {
                pictureBox6.Image = Properties.Resources._2;

            }
            else if (zarred == 3)
            {
                pictureBox6.Image = Properties.Resources._3;

            }
            else if (zarred == 4)
            {
                pictureBox6.Image = Properties.Resources._4;

            }
            else if (zarred == 5)
            {
                pictureBox6.Image = Properties.Resources._5;

            }
            else if (zarred == 6)
            {
                pictureBox6.Image = Properties.Resources._6;

            }


            if (startred == true)
            {
                button2.Enabled = true;
                button1.Enabled = false;
            }
            else
            {

                button1.Enabled = false;
                button4.Enabled = true;
                oto = 0;
                timer1.Enabled = true;
            }


            if (zarred == 6)
            {
                startred = true;
                if (pictureBox4.Location.X == 12 && pictureBox4.Location.Y == 65)
                {
                    pictureBox4.Location = new Point(konx[0], kony[0]);
                    listekle("Kırmızı Oyuncu 1. Taşını Çıkardı");
                    kırmızıye();
                }
                if (pictureBox5.Location.X == 69 && pictureBox5.Location.Y == 63 && pictureBox4.Location.X == konredx[3] && pictureBox4.Location.Y == konredy[3])
                {
                    pictureBox5.Location = new Point(konx[0], kony[0]);
                    listekle("Kırmızı Oyuncu 2. Taşını Çıkardı");
                    kırmızıye();
                }
                if (pictureBox2.Location.X == 12 && pictureBox2.Location.Y == 12 && pictureBox5.Location.X == konredx[2] && pictureBox5.Location.Y == konredy[2])
                {
                    pictureBox2.Location = new Point(konx[0], kony[0]);
                    listekle("Kırmızı Oyuncu 3. Taşını Çıkardı");
                    kırmızıye();
                }
                if (pictureBox3.Location.X == 69 && pictureBox3.Location.Y == 10 && pictureBox2.Location.X == konredx[1] && pictureBox2.Location.Y == konredy[1])
                {
                    pictureBox3.Location = new Point(konx[0], kony[0]);
                    listekle("Kırmızı Oyuncu 4. Taşını Çıkardı");
                    kırmızıye();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            zarblue = zar.Next(1, 7);
            SoundPlayer zarses = new SoundPlayer(KizmaBirader.Properties.Resources.Rolling_Dices_Sound_Effect);
            zarses.Play();
            //axWindowsMediaPlayer1.URL = "Properties.Resources.Rolling_Dices_Sound_Effect";
            if (zarblue == 1)
            {
                pictureBox7.Image = Properties.Resources._1;
            }
            else if (zarblue == 2)
            {
                pictureBox7.Image = Properties.Resources._2;

            }
            else if (zarblue == 3)
            {
                pictureBox7.Image = Properties.Resources._3;

            }
            else if (zarblue == 4)
            {
                pictureBox7.Image = Properties.Resources._4;

            }
            else if (zarblue == 5)
            {
                pictureBox7.Image = Properties.Resources._5;

            }
            else if (zarblue == 6)
            {
                pictureBox7.Image = Properties.Resources._6;
            }

            if (startblue == true)
            {
                button3.Enabled = true;
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = false;
                button6.Enabled = true;
            }

            if (zarblue == 6)
            {
                startblue = true;
                if (pictureBox10.Location.X == 511 && pictureBox10.Location.Y == 8)
                {
                    pictureBox10.Location = new Point(mavikonx[0], mavikony[0]);
                    listekle("Mavi Oyuncu 1. Taşını Çıkardı");
                    maviye();
                }
                if (pictureBox12.Location.X == 511 && pictureBox12.Location.Y == 61 && pictureBox10.Location.X == konbluex[3] && pictureBox10.Location.Y == konbluey[3])
                {
                    pictureBox12.Location = new Point(mavikonx[0], mavikony[0]);
                    listekle("Mavi Oyuncu 2. Taşını Çıkardı");
                    maviye();
                }
                if (pictureBox11.Location.X == 570 && pictureBox11.Location.Y == 8 && pictureBox12.Location.X == konbluex[2] && pictureBox12.Location.Y == konbluey[2])
                {
                    pictureBox11.Location = new Point(mavikonx[0], mavikony[0]);
                    listekle("Mavi Oyuncu 3. Taşını Çıkardı");
                    maviye();
                }
                if (pictureBox13.Location.X == 570 && pictureBox13.Location.Y == 61 && pictureBox11.Location.X == konbluex[1] && pictureBox11.Location.Y == konbluey[1])
                {
                    pictureBox13.Location = new Point(mavikonx[0], mavikony[0]);
                    listekle("Mavi Oyuncu 4. Taşını Çıkardı");
                    maviye();
                }

            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            SesAyarla(100);
            comboBox1.SelectedIndex = 2;
            pictureBox2.Location = new Point(12, 12);
            pictureBox3.Location = new Point(69, 10);
            pictureBox4.Location = new Point(12, 65);
            pictureBox5.Location = new Point(69, 63);

            pictureBox10.Location = new Point(511, 8);
            pictureBox12.Location = new Point(511, 61);
            pictureBox11.Location = new Point(570, 8);
            pictureBox13.Location = new Point(570, 61);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redtaskon += zarred;
            //4. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 6)
            {
                pictureBox3.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 6)
            {
                redtaskon -= 40;
                redbitis = 7;
            }
            if (redbitis == 7)
            {
                if (redtaskon >= 0)
                {
                    pictureBox3.Location = new Point(konredx[0], konredy[0]);
                    redtaskon = 0;
                    redbitis = 8;
                    startred = false;
                    listekle("Kırmızı Oyuncu 4. Taşını Yuvaya Götürdü");
                    for(int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i+1).ToString() + "- Kırmızı Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i+1).ToString() + "- Kırmızı Oyuncu";
                                break;
                            }
                        }
                      
                        /*if (sıralama[i] == "0")
                        {
                            sıralama[i] = i.ToString()+"- Kırmızı Oyuncu";
                            break;
                        }
                        if (i == 3 && sıralama[i] != "0")
                        {
                            sonuc();
                        }*/
                    }
                }
                else
                    pictureBox3.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //3. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 4)
            {
                pictureBox2.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 4)
            {
                redtaskon -= 40;
                redbitis = 5;
            }
            if (redbitis == 5)
            {
                if (redtaskon >= 1)
                {
                    pictureBox2.Location = new Point(konredx[1], konredy[1]);
                    redtaskon = 0;
                    redbitis = 6;
                    startred = false;
                    listekle("Kırmızı Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox2.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //2. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 2)
            {
                pictureBox5.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }

            if (redtaskon > 39 && redbitis == 2)
            {
                redtaskon -= 40;
                redbitis = 3;
            }
            if (redbitis == 3)
            {
                if (redtaskon >= 2)
                {
                    pictureBox5.Location = new Point(konredx[2], konredy[2]);
                    redtaskon = 0;
                    redbitis = 4;
                    startred = false;
                    listekle("Kırmızı Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox5.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //1. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 0)
            {
                pictureBox4.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }

            if (redtaskon > 39 && redbitis == 0)
            {
                redtaskon -= 40;
                redbitis = 1;
            }
            if (redbitis == 1)
            {
                if (redtaskon >= 3)
                {
                    pictureBox4.Location = new Point(konredx[3], konredy[3]);
                    redtaskon = 0;
                    redbitis = 2;
                    startred = false;
                    listekle("Kırmızı Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox4.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            button2.Enabled = false;
            button4.Enabled = true;
            oto = 0;
            timer1.Enabled = true;
        }




        private void listekle(string y)
        {
            listBox1.Items.Add(y);
            if (listBox1.Items.Count > 6)
                listBox1.Items.RemoveAt(0);
        }

        private void kırmızıye()
        {
            if ((pictureBox3.Location== pictureBox10.Location) || (pictureBox2.Location== pictureBox10.Location) || (pictureBox5.Location== pictureBox10.Location) || (pictureBox4.Location == pictureBox10.Location))
            {
                pictureBox10.Location = new Point(511, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 0;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox11.Location) || (pictureBox2.Location == pictureBox11.Location) || (pictureBox5.Location == pictureBox11.Location) || (pictureBox4.Location == pictureBox11.Location))
            {
                pictureBox11.Location = new Point(570, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 4;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox12.Location) || (pictureBox2.Location == pictureBox12.Location) || (pictureBox5.Location == pictureBox12.Location) || (pictureBox4.Location == pictureBox12.Location))
            {
                pictureBox12.Location = new Point(511, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 2;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox13.Location) || (pictureBox2.Location == pictureBox13.Location) || (pictureBox5.Location == pictureBox13.Location) || (pictureBox4.Location == pictureBox13.Location))
            {
                pictureBox13.Location = new Point(570, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 6;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox14  .Location) || (pictureBox2.Location == pictureBox14.Location) || (pictureBox5.Location == pictureBox14.Location) || (pictureBox4.Location == pictureBox14.Location))
            {
                pictureBox14.Location = new Point(513, 517);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 2;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox15.Location) || (pictureBox2.Location == pictureBox15.Location) || (pictureBox5.Location == pictureBox15.Location) || (pictureBox4.Location == pictureBox15.Location))
            {
                pictureBox15.Location = new Point(570, 515);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 0;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox16.Location) || (pictureBox2.Location == pictureBox16.Location) || (pictureBox5.Location == pictureBox16.Location) || (pictureBox4.Location == pictureBox16.Location))
            {
                pictureBox16.Location = new Point(513, 574);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 6;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox17.Location) || (pictureBox2.Location == pictureBox17.Location) || (pictureBox5.Location == pictureBox17.Location) || (pictureBox4.Location == pictureBox17.Location))
            {
                pictureBox17.Location = new Point(570, 577);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 4;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox18.Location) || (pictureBox2.Location == pictureBox18.Location) || (pictureBox5.Location == pictureBox18.Location) || (pictureBox4.Location == pictureBox18.Location))
            {
                pictureBox18.Location = new Point(12, 514);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 6;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox19.Location) || (pictureBox2.Location == pictureBox19.Location) || (pictureBox5.Location == pictureBox19.Location) || (pictureBox4.Location == pictureBox19.Location))
            {
                pictureBox19.Location = new Point(68, 515);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 2;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox20.Location) || (pictureBox2.Location == pictureBox20.Location) || (pictureBox5.Location == pictureBox20.Location) || (pictureBox4.Location == pictureBox20.Location))
            {
                pictureBox20.Location = new Point(13, 576);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 4;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox21.Location) || (pictureBox2.Location == pictureBox21.Location) || (pictureBox5.Location == pictureBox21.Location) || (pictureBox4.Location == pictureBox21.Location))
            {
                pictureBox21.Location = new Point(68, 575);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 0;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
        }

        private void maviye()
        {
            if ((pictureBox10.Location == pictureBox4.Location) || (pictureBox11.Location == pictureBox4.Location) || (pictureBox12.Location == pictureBox4.Location) || (pictureBox13.Location == pictureBox4.Location))
            {
                pictureBox4.Location = new Point(12, 65);
                redtaskon = 0;
                startred = false;
                redbitis = 0;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox5.Location) || (pictureBox11.Location == pictureBox5.Location) || (pictureBox12.Location == pictureBox5.Location) || (pictureBox13.Location == pictureBox5.Location))
            {
                pictureBox5.Location = new Point(69, 63);
                redtaskon = 0;
                startred = false;
                redbitis = 2;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox2.Location) || (pictureBox11.Location == pictureBox2.Location) || (pictureBox12.Location == pictureBox2.Location) || (pictureBox13.Location == pictureBox2.Location))
            {
                pictureBox2.Location = new Point(12, 12);
                redtaskon = 0;
                startred = false;
                redbitis = 4;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox3.Location) || (pictureBox11.Location == pictureBox3.Location) || (pictureBox12.Location == pictureBox3.Location) || (pictureBox13.Location == pictureBox3.Location))
            {
                pictureBox3.Location = new Point(69, 10);
                redtaskon = 0;
                startred = false;
                redbitis = 6;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox14.Location) || (pictureBox11.Location == pictureBox14.Location) || (pictureBox12.Location == pictureBox14.Location) || (pictureBox13.Location == pictureBox14.Location))
            {
                pictureBox14.Location = new Point(513, 517);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 2;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox15.Location) || (pictureBox11.Location == pictureBox15.Location) || (pictureBox12.Location == pictureBox15.Location) || (pictureBox13.Location == pictureBox15.Location))
            {
                pictureBox15.Location = new Point(570, 515);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 0;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox16.Location) || (pictureBox11.Location == pictureBox16.Location) || (pictureBox12.Location == pictureBox16.Location) || (pictureBox13.Location == pictureBox16.Location))
            {
                pictureBox16.Location = new Point(513, 574);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 6;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox17.Location) || (pictureBox11.Location == pictureBox17.Location) || (pictureBox12.Location == pictureBox17.Location) || (pictureBox13.Location == pictureBox17.Location))
            {
                pictureBox17.Location = new Point(570, 577);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 4;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox18.Location) || (pictureBox11.Location == pictureBox18.Location) || (pictureBox12.Location == pictureBox18.Location) || (pictureBox13.Location == pictureBox18.Location))
            {
                pictureBox18.Location = new Point(12, 514);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 6;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox19.Location) || (pictureBox11.Location == pictureBox19.Location) || (pictureBox12.Location == pictureBox19.Location) || (pictureBox13.Location == pictureBox19.Location))
            {
                pictureBox19.Location = new Point(68, 515);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 2;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox20.Location) || (pictureBox11.Location == pictureBox20.Location) || (pictureBox12.Location == pictureBox20.Location) || (pictureBox13.Location == pictureBox20.Location))
            {
                pictureBox20.Location = new Point(13, 576);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 4;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox21.Location) || (pictureBox11.Location == pictureBox21.Location) || (pictureBox12.Location == pictureBox21.Location) || (pictureBox13.Location == pictureBox21.Location))
            {
                pictureBox21.Location = new Point(68, 575);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 0;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
        }

        private void yeşilye()
        {   
            if ((pictureBox15.Location == pictureBox5.Location) || (pictureBox14.Location == pictureBox5.Location) || (pictureBox17.Location == pictureBox5.Location) || (pictureBox16.Location == pictureBox5.Location))
            {
                pictureBox5.Location = new Point(69, 63);
                redtaskon = 0;
                startred = false;
                redbitis = 2;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox4.Location) || (pictureBox14.Location == pictureBox4.Location) || (pictureBox17.Location == pictureBox4.Location) || (pictureBox16.Location == pictureBox4.Location))
            {
                pictureBox4.Location = new Point(12, 65);
                redtaskon = 0;
                startred = false;
                redbitis = 0;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox3.Location) || (pictureBox14.Location == pictureBox3.Location) || (pictureBox17.Location == pictureBox3.Location) || (pictureBox16.Location == pictureBox3.Location))
            {
                pictureBox3.Location = new Point(69, 10);
                redtaskon = 0;
                startred = false;
                redbitis = 6;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox2.Location) || (pictureBox14.Location == pictureBox2.Location) || (pictureBox17.Location == pictureBox2.Location) || (pictureBox16.Location == pictureBox2.Location))
            {
                pictureBox2.Location = new Point(12, 12);
                redtaskon = 0;
                startred = false;
                redbitis = 4;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox10.Location) || (pictureBox14.Location == pictureBox10.Location) || (pictureBox17.Location == pictureBox10.Location) || (pictureBox16.Location == pictureBox10.Location))
            {
                pictureBox10.Location = new Point(511, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 0;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox11.Location) || (pictureBox14.Location == pictureBox11.Location) || (pictureBox17.Location == pictureBox11.Location) || (pictureBox16.Location == pictureBox11.Location))
            {
                pictureBox11.Location = new Point(570, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 4;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox12.Location) || (pictureBox14.Location == pictureBox12.Location) || (pictureBox17.Location == pictureBox12.Location) || (pictureBox16.Location == pictureBox12.Location))
            {
                pictureBox12.Location = new Point(511, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 2;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox13.Location) || (pictureBox14.Location == pictureBox13.Location) || (pictureBox17.Location == pictureBox13.Location) || (pictureBox16.Location == pictureBox13.Location))
            {
                pictureBox13.Location = new Point(570, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 6;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }

            else if ((pictureBox15.Location == pictureBox18.Location) || (pictureBox14.Location == pictureBox18.Location) || (pictureBox17.Location == pictureBox18.Location) || (pictureBox16.Location == pictureBox18.Location))
            {
                pictureBox18.Location = new Point(12, 514);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 6;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox19.Location) || (pictureBox14.Location == pictureBox19.Location) || (pictureBox17.Location == pictureBox19.Location) || (pictureBox16.Location == pictureBox19.Location))
            {
                pictureBox19.Location = new Point(68, 515);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 2;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox20.Location) || (pictureBox14.Location == pictureBox20.Location) || (pictureBox17.Location == pictureBox20.Location) || (pictureBox16.Location == pictureBox20.Location))
            {
                pictureBox20.Location = new Point(13, 576);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 4;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox21.Location) || (pictureBox14.Location == pictureBox21.Location) || (pictureBox17.Location == pictureBox21.Location) || (pictureBox16.Location == pictureBox21.Location))
            {
                pictureBox21.Location = new Point(68, 575);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 0;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }

        }

        private void sarıye()
        {
            if ((pictureBox18.Location == pictureBox3.Location) || (pictureBox19.Location == pictureBox3.Location) || (pictureBox20.Location == pictureBox3.Location) || (pictureBox21.Location == pictureBox3.Location))
            {
                pictureBox3.Location = new Point(69, 10);
                redtaskon = 0;
                startred = false;
                redbitis = 6;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox5.Location) || (pictureBox19.Location == pictureBox5.Location) || (pictureBox20.Location == pictureBox5.Location) || (pictureBox21.Location == pictureBox5.Location))
            {
                pictureBox5.Location = new Point(69, 63);
                redtaskon = 0;
                startred = false;
                redbitis = 2;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox2.Location) || (pictureBox19.Location == pictureBox2.Location) || (pictureBox20.Location == pictureBox2.Location) || (pictureBox21.Location == pictureBox2.Location))
            {
                pictureBox2.Location = new Point(12, 12);
                redtaskon = 0;
                startred = false;
                redbitis = 4;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox4.Location) || (pictureBox19.Location == pictureBox4.Location) || (pictureBox20.Location == pictureBox4.Location) || (pictureBox21.Location == pictureBox4.Location))
            {
                pictureBox4.Location = new Point(12, 65);
                redtaskon = 0;
                startred = false;
                redbitis = 0;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox10.Location) || (pictureBox19.Location == pictureBox10.Location) || (pictureBox20.Location == pictureBox10.Location) || (pictureBox21.Location == pictureBox10.Location))
            {
                pictureBox10.Location = new Point(511, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 0;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox11.Location) || (pictureBox19.Location == pictureBox11.Location) || (pictureBox20.Location == pictureBox11.Location) || (pictureBox21.Location == pictureBox11.Location))
            {
                pictureBox11.Location = new Point(570, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 4;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox12.Location) || (pictureBox19.Location == pictureBox12.Location) || (pictureBox20.Location == pictureBox12.Location) || (pictureBox21.Location == pictureBox12.Location))
            {
                pictureBox12.Location = new Point(511, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 2;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox13.Location) || (pictureBox19.Location == pictureBox13.Location) || (pictureBox20.Location == pictureBox13.Location) || (pictureBox21.Location == pictureBox13.Location))
            {
                pictureBox13.Location = new Point(570, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 6;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox14.Location) || (pictureBox19.Location == pictureBox14.Location) || (pictureBox20.Location == pictureBox14.Location) || (pictureBox21.Location == pictureBox14.Location))
            {
                pictureBox14.Location = new Point(513, 517);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 2;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox15.Location) || (pictureBox19.Location == pictureBox15.Location) || (pictureBox20.Location == pictureBox15.Location) || (pictureBox21.Location == pictureBox15.Location))
            {
                pictureBox15.Location = new Point(570, 515);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 0;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox16.Location) || (pictureBox19.Location == pictureBox16.Location) || (pictureBox20.Location == pictureBox16.Location) || (pictureBox21.Location == pictureBox16.Location))
            {
                pictureBox16.Location = new Point(513, 574);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 6;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox17.Location) || (pictureBox19.Location == pictureBox17.Location) || (pictureBox20.Location == pictureBox17.Location) || (pictureBox21.Location == pictureBox17.Location))
            {
                pictureBox17.Location = new Point(570, 577);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 4;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }

        }

        private void sonuc()
        {
            MessageBox.Show(sıralama[0] + "\n" + sıralama[1] + "\n" + sıralama[2] + "\n" + sıralama[3], "OYUN BİTTİ");
            timer3.Enabled = true;
        }

        bool ileri = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            if (button9.Location.X == 653)
                ileri = true;
            else if (button9.Location.X == 656)
                ileri = false;


            if (ileri == true)
                button9.Location = new Point(button9.Location.X + 1, button9.Location.Y);
            else
                button9.Location = new Point(button9.Location.X - 1, button9.Location.Y);

        }
    }
}
