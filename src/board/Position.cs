namespace board
{
    public class Position {

        int row { get; set; }
        int column { get; set; }

        public Position(int row, int column) {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return row
                + ", "
                + column;
        }
    }
}

