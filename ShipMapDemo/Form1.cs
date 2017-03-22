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
        public ShipMap.ShipMap Map;

        public Form1()
        {

            InitializeComponent();

            int width = 50;
            int heigth = 100;

            Map = new ShipMap.ShipMap(width, heigth);
            shipMap.ColumnCount = width;
            shipMap.Rows.Add(heigth);
        }

        public void DrawCell( int x, int y )
        {
            var cell   = Map.GetCell(x,y);
            var canvas = shipMap.Rows[y].Cells[x];
            if ( cell.StandObject != null)
            {
                canvas.Style.BackColor = Color.Gray;
            }
            else if ( cell.Deck != null )
            {
                canvas.Style.BackColor = Color.LightGray;
            }
            else
            {
                canvas.Style.BackColor = Color.White;
            }

            var innerText = "";
            if (cell.StandAirPipe != null)
            {
                innerText += "o";
            }
            else
            {
                innerText += " ";
            }
            if (cell.StandCable != null)
            {
                innerText += "+";
            }
            else
            {
                innerText += " ";
            }
            canvas.Value = innerText;
        }

        public ShipMapCell GetSelectedCell()
        {
            if (shipMap.SelectedCells.Count == 0)
                return null;
            return Map.GetCell( shipMap.SelectedCells[0].ColumnIndex, shipMap.SelectedCells[0].RowIndex);
        }

        public ShipMapCell DrawSelectedCell()
        {
            var cell = GetSelectedCell();
            DrawCell( cell.X, cell.Y );
            return cell;
        }

        private void shipMap_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                shipMap.ClearSelection();
                shipMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            }
        }

        private void addTile_Click(object sender, EventArgs e)
        {
            var cell = GetSelectedCell();
            cell.StandObject = new Tile(Map);
            DrawSelectedCell();
        }

        private void addDeck_Click(object sender, EventArgs e)
        {
            var cell = GetSelectedCell();
            cell.Deck = new FloorTile(Map);
            DrawSelectedCell();
        }

        private void addCable_Click(object sender, EventArgs e)
        {
            var cell = GetSelectedCell();
            cell.StandCable = new Cable(Map);
            DrawSelectedCell();
        }

        private void addAirPipe_Click(object sender, EventArgs e)
        {
            var cell = GetSelectedCell();
            cell.StandAirPipe = new AirPipe(Map);
            DrawSelectedCell();
        }

        private void cleanCell_Click(object sender, EventArgs e)
        {
            var cell = GetSelectedCell();
            cell.StandAirPipe = new AirPipe(Map);
            DrawSelectedCell();
        }
    }
}
