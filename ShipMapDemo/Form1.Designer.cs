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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shipMap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.shipMap)).BeginInit();
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
            this.shipMap.Size = new System.Drawing.Size(1069, 428);
            this.shipMap.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 500);
            this.Controls.Add(this.shipMap);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shipMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView shipMap;
    }
}

