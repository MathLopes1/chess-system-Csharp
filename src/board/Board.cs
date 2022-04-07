namespace board
{
    class Board {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] piece;

        public Board(int rows, int columns) {
            this.rows = rows;
            this.columns = columns;
            this.piece = new Piece[rows, columns];
        }
    }
}
