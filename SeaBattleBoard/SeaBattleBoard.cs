using System.Drawing;
using System.Windows.Forms;

namespace SeaBattleBoard {
    public partial class SeaBattleBoard : UserControl {
        public SeaBattleBoard() {
            this.InitializeComponent();

            this.dgvBoard.SuspendLayout();
            this.SetDefaultValues();
            this.dgvBoard.ResumeLayout(false);
        }

        public virtual void SetDefaultValues() { }

        public void SetBoardCell(int row, int col, BoardCell bc) {
            this.dgvBoard.Rows[row].Cells[col].Value = bc.Value;

            var style = new DataGridViewCellStyle {BackColor = bc.Color};
            this.dgvBoard.Rows[row].Cells[col].Style = style;
        }

        public virtual BoardCell OnClick(int row, int col) => null;

        private void dgvBoard_SizeChanged(object sender, System.EventArgs e) {
            this.dgvBoard.SuspendLayout();

            var width = (this.dgvBoard.ClientRectangle.Width - this.dgvBoard.RowHeadersWidth) / this.dgvBoard.ColumnCount;
            for (var i = 0; i < this.dgvBoard.ColumnCount; i++) {
                this.dgvBoard.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                this.dgvBoard.Columns[i].Width = width;
            }

            var height = (this.dgvBoard.ClientRectangle.Height - this.dgvBoard.ColumnHeadersHeight) / this.dgvBoard.RowCount;
            for (var i = 0; i < this.dgvBoard.RowCount; i++) {
                this.dgvBoard.Rows[i].Height = height;
            }

            this.dgvBoard.ResumeLayout(false);
        }

        private void dgvBoard_CellClick(object sender, DataGridViewCellEventArgs e) {
            var bc = this.OnClick(e.RowIndex, e.ColumnIndex);
            if (bc != null)
                this.SetBoardCell(e.RowIndex, e.ColumnIndex, bc);
        }

        public class BoardCell {
            public Color Color => this.color_ == false ? Color.Aqua : Color.Goldenrod;
            public string Value => this.ToString();

            public BoardCell(bool? value, bool? color) {
                this.SetValue(value);
                this.SetColor(color);
            }

            private bool? value_;
            private bool color_;
            public void SetColor(bool? color) => this.color_ = color.HasValue && color.Value;
            public void SetValue(bool? value) => this.value_ = value;

            public override string ToString() {
                if (this.value_.HasValue == false) return "";
                return this.value_.Value ? "X" : "o";
            }
        }
    }
}