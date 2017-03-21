using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipMap;

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

        public void DrawCell( int x, int y, ShipMap.ShipMap map )
        {
            var cell   = map.Map[x, y];
            var canvas = shipMap.Rows[y].Cells[x];
            if ( cell.StandObject != null)
            {
                canvas.Style.BackColor = Color.Gray;
            }
            else if ( cell.Deck != null )
            {
                canvas.Style.BackColor = Color.LightGray;
            }
        }
    }
}
