using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipMapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var row = new DataGridViewRow();
            shipMap.ColumnCount = 50;
            shipMap.Rows.Add(100);
        }
    }
}
