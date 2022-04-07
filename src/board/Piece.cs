namespace board
{
    class Piece {
        public Position position { get; set; }  
        public Collor collor { get; set; }
        public int qtdMovements { get; protected set; }
        public Board board { get; protected set; }

        public Piece(Position position, Board board, Collor collor) {
            this.position = position;
            this.board = board;
            this.collor = collor;
            this.qtdMovements = 0;
        }
    }
}
