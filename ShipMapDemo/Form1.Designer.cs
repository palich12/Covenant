namespace ShipMapDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shipMap = new System.Windows.Forms.DataGridView();
            this.shipMapMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTile = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeck = new System.Windows.Forms.ToolStripMenuItem();
            this.addCable = new System.Windows.Forms.ToolStripMenuItem();
            this.addAirPipe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cleanCell = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.shipMap)).BeginInit();
            this.shipMapMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 72);
            this.panel1.TabIndex = 0;
            // 
            // shipMap
            // 
            this.shipMap.AllowUserToAddRows = false;
            this.shipMap.AllowUserToDeleteRows = false;
            this.shipMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shipMap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.shipMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.shipMap.ColumnHeadersVisible = false;
            this.shipMap.ContextMenuStrip = this.shipMapMenuStrip;
            this.shipMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipMap.Location = new System.Drawing.Point(0, 72);
            this.shipMap.Name = "shipMap";
            this.shipMap.ReadOnly = true;
            this.shipMap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.shipMap.RowHeadersVisible = false;
            this.shipMap.RowHeadersWidth = 20;
            this.shipMap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.shipMap.RowTemplate.ReadOnly = true;
            this.shipMap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shipMap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shipMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shipMap.Size = new System.Drawing.Size(1069, 605);
            this.shipMap.TabIndex = 1;
            this.shipMap.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shipMap_CellMouseDown);
            // 
            // shipMapMenuStrip
            // 
            this.shipMapMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTile,
            this.addDeck,
            this.addCable,
            this.addAirPipe,
            this.toolStripSeparator1,
            this.cleanCell});
            this.shipMapMenuStrip.Name = "shipMapMenuStrip";
            this.shipMapMenuStrip.Size = new System.Drawing.Size(153, 142);
            // 
            // addTile
            // 
            this.addTile.Name = "addTile";
            this.addTile.Size = new System.Drawing.Size(152, 22);
            this.addTile.Text = "addTile";
            this.addTile.Click += new System.EventHandler(this.addTile_Click);
            // 
            // addDeck
            // 
            this.addDeck.Name = "addDeck";
            this.addDeck.Size = new System.Drawing.Size(152, 22);
            this.addDeck.Text = "addDeck";
            this.addDeck.Click += new System.EventHandler(this.addDeck_Click);
            // 
            // addCable
            // 
            this.addCable.Name = "addCable";
            this.addCable.Size = new System.Drawing.Size(152, 22);
            this.addCable.Text = "addCable";
            this.addCable.Click += new System.EventHandler(this.addCable_Click);
            // 
            // addAirPipe
            // 
            this.addAirPipe.Name = "addAirPipe";
            this.addAirPipe.Size = new System.Drawing.Size(152, 22);
            this.addAirPipe.Text = "addAirPipe";
            this.addAirPipe.Click += new System.EventHandler(this.addAirPipe_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // cleanCell
            // 
            this.cleanCell.Name = "cleanCell";
            this.cleanCell.Size = new System.Drawing.Size(152, 22);
            this.cleanCell.Text = "cleanCell";
            this.cleanCell.Click += new System.EventHandler(this.cleanCell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 677);
            this.Controls.Add(this.shipMap);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shipMap)).EndInit();
            this.shipMapMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView shipMap;
        private System.Windows.Forms.ContextMenuStrip shipMapMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addTile;
        private System.Windows.Forms.ToolStripMenuItem addDeck;
        private System.Windows.Forms.ToolStripMenuItem addCable;
        private System.Windows.Forms.ToolStripMenuItem addAirPipe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cleanCell;
    }
}

