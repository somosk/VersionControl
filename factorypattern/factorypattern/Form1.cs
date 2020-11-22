using factorypattern.Abstractions;
using factorypattern.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorypattern
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _itoyfactory;
        public IToyFactory IToyFactory
        {
            get { return _itoyfactory; }
            set { _itoyfactory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            mainPanel.Width = this.Width;
            IToyFactory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = IToyFactory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);

        }

        private void conveyorTime_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }

        }
    }
}
