namespace SeaBattleBoard {
    public class Board {
        public static int Width = 10;
        public static int Height = 10;

        public bool? this[int i, int j] {
            get => this.cells_[i, j];
            set => this.cells_[i, j] = value;
        }

        public Board() { }
        private readonly bool?[,] cells_ = new bool?[Width, Height];
    }
}