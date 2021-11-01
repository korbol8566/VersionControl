using IRF_Patterns_1031.Abstractions;
using IRF_Patterns_1031.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Patterns_1031
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();

        private Toy _nextToy;

        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set 
            { 
                _factory = value;
                DisplayNext();
            }
        }

       

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var Toy = Factory.CreateNew();
            _toys.Add(Toy);
            Toy.Left = -Toy.Width;
            panel1.Controls.Add(Toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var Toy in _toys)
            {
                Toy.MoveToy();
                if (Toy.Left>maxPosition) maxPosition = Toy.Left;
            }
            if (maxPosition>1000)
            {
                var oldestBall = _toys[0];
                panel1.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }

        private void buttonCAR_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void buttonBALL_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory
            {
                BallColor = buttonCOLOR.BackColor
            };
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        private void buttonCOLOR_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }
    }
}
