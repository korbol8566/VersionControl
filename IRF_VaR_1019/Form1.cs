﻿using IRF_VaR_1019.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_VaR_1019
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>(); //using...
        List<decimal> Nyereségek = new List<decimal>();
        
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();

            //8
            
            int intervalum = 30;
            DateTime kezdőDátum = (from x in Ticks select x.TradingDay).Min();
            DateTime záróDátum = new DateTime(2016, 12, 30);
            TimeSpan z = záróDátum - kezdőDátum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = GetPortfolioValue(kezdőDátum.AddDays(i + intervalum))
                           - GetPortfolioValue(kezdőDátum.AddDays(i));
                Nyereségek.Add(ny);
                
                Console.WriteLine(i + " " + ny);               
            }

            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                        .ToList();
            MessageBox.Show(nyereségekRendezve[nyereségekRendezve.Count() / 5].ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;

            StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
            int counter = 0;
            sw.WriteLine("Elemszám | Időszak | Nyereség");
            foreach (var w in Nyereségek)
            {
                sw.WriteLine(counter.ToString()+" : "+w);
                
                counter++;
            }
                
            //counter++;
                sw.Close();
                
                            

            

            //int counter = 0;
            //using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            //foreach (var w in Nyereségek)
            //{
            //    sw.Write(counter.ToString(), ":", Nyereségek.ToString());

            //    sw.WriteLine();
            //    counter++;
            //}

            

            //using (var writer = new StreamWriter(sfd.FileName, false, Encoding.Default))              


            ////FileStream filestream = new FileStream("out.txt", FileMode.Create);
            //var streamwriter = new StreamWriter(sfd.FileName, false, Encoding.UTF8);

            //streamwriter.AutoFlush = true;
            //Console.SetOut(streamwriter);
            //Console.SetError(streamwriter);



        }
        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });
            // így is lehetne 
            //PortfolioItem p = new PortfolioItem();
            //p.Index = "OTP";
            //p.Volume = 10;
            //Portfolio.Add(p);
            dataGridView2.DataSource = Portfolio;
        }
        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim()
                               && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }

       
    }
}
