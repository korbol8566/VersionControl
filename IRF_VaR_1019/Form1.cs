﻿using IRF_VaR_1019.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();
            
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
    }
}
