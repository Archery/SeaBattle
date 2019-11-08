namespace SeaBattleBoard
{
    partial class SeaBattleBoard
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBoard = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoard
            // 
            this.dgvBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.c9,
            this.c10});
            this.dgvBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoard.Location = new System.Drawing.Point(0, 0);
            this.dgvBoard.Name = "dgvBoard";
            this.dgvBoard.Size = new System.Drawing.Size(800, 450);
            this.dgvBoard.TabIndex = 0;
            this.dgvBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoard_CellClick);
            this.dgvBoard.SizeChanged += new System.EventHandler(this.dgvBoard_SizeChanged);
            // 
            // c1
            // 
            this.c1.HeaderText = "А";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            // 
            // c2
            // 
            this.c2.HeaderText = "Б";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.HeaderText = "В";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.HeaderText = "Г";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.HeaderText = "Д";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // c6
            // 
            this.c6.HeaderText = "Е";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            // 
            // c7
            // 
            this.c7.HeaderText = "Ж";
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            // 
            // c8
            // 
            this.c8.HeaderText = "З";
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            // 
            // c9
            // 
            this.c9.HeaderText = "И";
            this.c9.Name = "c9";
            this.c9.ReadOnly = true;
            // 
            // c10
            // 
            this.c10.HeaderText = "К";
            this.c10.Name = "c10";
            this.c10.ReadOnly = true;
            // 
            // SeaBattleBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBoard);
            this.Name = "SeaBattleBoard";
            this.Size = new System.Drawing.Size(800, 450);
            this.SizeChanged += new System.EventHandler(this.dgvBoard_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewTextBoxColumn c9;
        private System.Windows.Forms.DataGridViewTextBoxColumn c10;
    }
}
