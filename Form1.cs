using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace kMeans
{
    public partial class Form1 : Form
    {

        class Centroid
        {
            public int x { get; set; }
            public int y { get; set; }
            public Color color { get; set; }


            public Centroid(int x , int y , Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }

        }
        class Punct
        {
            public int x { get; set; }
            public int y { get; set; }
           public Color color { get; set; }
        
            public Punct(int x, int y,  Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;

            }
        }


        #region generareRandom
        public static readonly Random getRandom = new Random();
        public static int getRandomNumber(int min, int max)
        {
            lock (getRandom)
            {
                return getRandom.Next(min, max);
            }
        }

        public static double getRandomDouble()
        {
            lock (getRandom)
            {
                return getRandom.NextDouble();
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        int n = 10000;   //numar de puncte

        #region variabileGlobale
        Graphics g;
        Pen p;
        //int cost;
        Centroid[] centroizi;
        Centroid[] centroizi_new;
        int cost2 = 10000000;
        bool oprit = false;
        Punct[] punct;
        int[,] inputData;
        int nr_centroizi;
        int[,] centruGreutate;  //centruGreutate [culoare,Gx,Gy];
        Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Brown, Color.Turquoise, Color.Orange, Color.Pink, Color.Coral, Color.LightGreen, Color.Lime };
        #endregion

        private void btn_drawLines_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black);
            p.Width = 3;
            g.TranslateTransform((float)(panel1.Width / 2), (float)(panel1.Height / 2));
            drawLines();
        }
        private void drawLines()
        {



            g.DrawLine(p, 0, 300, 0, -300);
            g.DrawLine(p, -300, 0, 300, 0);
        }
        private void GenereazaCentroizi()
        {
            int x, y;
            nr_centroizi = getRandomNumber(2, 11);


            label_nrCentr.Text = $"Numar Centroizi: {nr_centroizi}";
            btn_Centroizi.Enabled = false;
            centroizi = new Centroid[nr_centroizi];



            for (int i = 0; i < nr_centroizi; i++)
            {



                x = getRandomNumber(-299, 300);
                y = getRandomNumber(-299, 300);
                centroizi[i] = new Centroid(x, y, colors[i]);

                g.DrawEllipse((new Pen(centroizi[i].color, 3)), centroizi[i].x, centroizi[i].y, 10, 10);
            }
        }



        private void btn_Centroizi_Click(object sender, EventArgs e)
        {
            GenereazaCentroizi();
        }

        private void btn_GenPct_Click(object sender, EventArgs e)
        {
            punct = new Punct[n];
            string path = "Input.txt";
            inputData = new int[n, 2];
            FileStream fisier;

      
            if ((!File.Exists(path)) || (File.ReadLines(path).Count() != n))
            {
                fisier = File.Open(path, FileMode.Create);

                StreamWriter sw = new StreamWriter(fisier);
                for (int i = 0; i < n; i++)
                {
                    int x = getRandomNumber(-299, 300);
                    int y = getRandomNumber(-299, 300);
                    sw.WriteLine(x + " " + y);

                }
                sw.Close();
            } // creeaza fisier daca e nevoie.


            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ');


                punct[i] = new Punct(Convert.ToInt32(words[0]), Convert.ToInt32(words[1]), colors[i % 10]); //creez punct cu toate culorile

            
                
           


            }   

            for (int i = 0; i < n; i++)
            {

              
                DeseneazaPunct(i);
                    
            }

        }

        private void DeseneazaPunct(int i)
        {
            g.FillRectangle((new SolidBrush(punct[i].color)), punct[i].x, punct[i].y, 2, 2);
        }

        private void GruparePct()
        {
          
            int cost =0;
            centruGreutate = new int[nr_centroizi, 3];

            drawLines();
            int distanta;
           

            for (int i = 0; i < n; i++)
            {
                int distantaFinala = 10000;

                for (int j = 0; j < nr_centroizi; j++)
                {
                    distanta = Convert.ToInt32(Math.Sqrt(Math.Pow((punct[i].x - centroizi[j].x), 2) + Math.Pow((punct[i].y - centroizi[j].y), 2)));
                    if (distanta < distantaFinala)
                    {
                        distantaFinala = distanta;
                        punct[i].color = centroizi[j].color;


                    }

                   
                }
                cost += distantaFinala;
               
                

            
                DeseneazaPunct(i);
            }
            
            if (cost2 > cost)
            {
                cost2 = cost;
             
            CostMicLabel.Text = $"Cel mai mic cost: {cost2}";
            CostMicLabel.Update();

                
            }
            else if(!oprit)
            {
                OprireLabel.Text = $"Oprire la: {cost2}";
                OprireLabel.Update();
                oprit = true;
            }
            drawLines();
            CostLabel.Text = $"Cost: {Convert.ToInt32(cost)}";
            CostLabel.Update();




        }
            private void btn_Grupare_Click(object sender, EventArgs e)
        {

            GruparePct();
       
        }


        private void RecentrareCentroizi()
        {
            Centroid[] c = new Centroid[nr_centroizi];
            Centroid[] c2 = new Centroid[nr_centroizi];
            c = centroizi;
            
            int[,] centruG = new int[centroizi.Length, 3]; //centruG [culoare, sumX, sumY,nrPct]
            centroizi_new = new Centroid[nr_centroizi];

            for (int i = 0; i < punct.Length; i++)
            {
                {
                    for (int j = 0; j < centroizi.Length; j++)
                    {

                        if (punct[i].color==centroizi[j].color)
                        {
                            centruG[j, 0] += punct[i].x;
                            centruG[j, 1] += punct[i].y;
                            centruG[j, 2]++;
                        }
                    }
                }

            }

            for (int j = 0; j < centroizi.Length; j++)
            {
                g.DrawEllipse((new Pen(Color.White, 3)), centroizi[j].x, centroizi[j].y, 10, 10);

                if (centruG[j, 2] != 0)
                {
                    

                    centruG[j, 0] /= centruG[j, 2];
                    centruG[j, 1] /= centruG[j, 2];

                    centroizi_new[j] = new Centroid(centruG[j, 0], centruG[j, 1], centroizi[j].color);
                   // centroizi[j].x = centruG[j, 0];
                    //centroizi[j].y = centruG[j, 1];

                   

                }
                else
                {
                    centroizi_new[j] = new Centroid(centroizi[j].x, centroizi[j].y, centroizi[j].color);
                }
                g.DrawEllipse((new Pen(centroizi_new[j].color, 3)), centroizi_new[j].x, centroizi_new[j].y, 10, 10);
            }


        }

        private void btn_Centrare_Click(object sender, EventArgs e)
        {



            bool changed;
            do
            {
               
                Centroid[] centr_old = new Centroid[nr_centroizi];
                Centroid[] centr_new = new Centroid[nr_centroizi];
                
               // Thread.Sleep(1000);
                 changed = false;
                RecentrareCentroizi();
                centr_old = centroizi;

                if (centroizi_new != null)
                {
                    centroizi = centroizi_new;
                centr_new = centroizi_new;
                }
                GruparePct();

                for (int i = 0; i < nr_centroizi; i++)
                {
                    if ((centr_new[i].x != centr_old[i].x)|| (centr_new[i].y != centr_old[i].y))
                    {
                        changed = true;
                        break;
                    }
                }


            } while (changed);

           
    }

        private void btn_blank_Click(object sender, EventArgs e)
        {
            g.FillRectangle((new SolidBrush(Color.White)), -300, -300, 600, 600);
            drawLines();
            GenereazaCentroizi();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            label_coord.Text = $" X: {e.X}  Y: {e.Y} ";
            
        }
    }



}
            
        

 