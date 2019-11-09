using System;
using System.Linq;
using System.Text;

namespace SeaBattleBoard {
    public class Board {
        public const int Width = 10;
        public const int Height = 10;

        public static readonly int[][] Diagonals = new int[][] {new[] {-1, -1}, new[] {-1, 1}, new[] {1, -1}, new[] {1, 1}};
        public static readonly int[][] Self = new int[][] {new[] {0, 0}};
        public static readonly int[][] Sides = new int[][] {new[] {-1, 0}, new[] {1, 0}, new[] {0, -1}, new[] {0, 1}};
        public static readonly int[][] RightBottom = new int[][] {new[] {1, 0}, new[] {0, 1}};
        public static readonly int[][] NineZona = new int[][] {new[] {-1, -1}, new[] {0, -1}, new[] {1, -1}, new[] {-1, 0}, new[] {0, 0}, new[] {1, 0}, new[] {-1, 1}, new[] {0, 1}, new[] {1, 1},};

        public bool? this[int i, int j] {
            get => this.cells_[i, j];
            set => this.cells_[i, j] = value;
        }

        public Board() { }
        private readonly bool?[,] cells_ = new bool?[Width, Height];

        public int Count(Func<bool?, bool> filter) {
            if (filter == null) throw new ArgumentNullException();

            return this.cells_.Cast<bool?>().Count(filter);
        }

        public bool OnBoard(int row, int col) {
            return row >= 0 && col >= 0 && row < this.cells_.GetLength(0) && col < this.cells_.GetLength(1);
        }

        public bool TrySetShip(int row, int col, int length) {
            if (!this.OnBoard(row, col)) return false;
            foreach (var offset in RightBottom) {
                if (!this.OnBoard(row + offset[0] * (length - 1), col + offset[1] * (length - 1))) continue;
                var b = true;
                for (var i = 0; i < length; i++) {
                    if (this.IsEmptyZone(row + i * offset[0], col + i * offset[1], NineZona)) continue;
                    b = false;
                    break;
                }
                if (!b) continue;
                for (var i = 0; i < length; i++) {
                    this.cells_[row + i * offset[0], col + i * offset[1]] = true;
                }
                return true;
            }
            return false;
        }

        public bool IsEmptyZone(int row, int col, int[][] zone) {
            foreach (var offset in zone) {
                if (!this.OnBoard(row + offset[0], col + offset[1])) continue;
                var cell = this.cells_[row + offset[0], col + offset[1]];
                if (cell.HasValue && cell.Value) return false;
            }
            return true;
        }

        public bool SetZone(int row, int col, int[][] zone, bool? value) {
            foreach (var offset in zone) {
                if (!this.OnBoard(row + offset[0], col + offset[1])) continue;
                this.cells_[row + offset[0], col + offset[1]] = value;
            }
            return true;
        }

        public int CountByZone(int row, int col, int[][] zone, Func<bool?, bool> filter) {
            var count = 0;
            foreach (var offset in zone) {
                if (!this.OnBoard(row + offset[0], col + offset[1])) continue;
                if (filter(this.cells_[row + offset[0], col + offset[1]])) {
                    count++;
                }
            }
            return count;
        }

        public override string ToString() {
            var sb = new StringBuilder();
            for (var i = 0; i < this.cells_.GetLength(0); i++) {
                for (var j = 0; j < this.cells_.GetLength(1); j++) {
                    var cell = this.cells_[i, j];
                    sb.Append((cell.HasValue ? (cell.Value ? "+" : "-") : "?") + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}