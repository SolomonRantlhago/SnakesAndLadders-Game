using System.Drawing;

namespace SnakesAndLadders
{
    public interface IBoard
    {
        Point GetCoordinates(int block);
    } //interface IBoard

    public class Board : IBoard
    {
        private int cellWidth, cellHeight;
        public Image image { get; private set; }
        private Point[,] coords;
        
        public Board()
        {
            //Load image
            image = Image.FromFile("Board36.png");

            //Cell dimensions
            int border = 9;
            cellHeight = (image.Height - border * 2) / 6;
            cellWidth = (image.Width - border * 2) / 6;

            //Get coordinates of every cell in the grid relative to topleft pixel of the image
            coords = new Point[6, 6];
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                    coords[x, y] = new Point(border + x * cellWidth, border + (5-y) * cellHeight);
            } //for

            ////Set up ladders and snakes
            //Ladders = new int[37];
            //Ladders[3] = 22;
            //Ladders[18] = 29;
            //Snakes = new int[37];
            //Snakes[35] = 11;
            //Snakes[21] = 6;

        } //Constructor

        public Point GetCoordinates(int block)
        {
            //Return the coordinates of a specific numbered block
            Point pt = new Point(0, 0);
            int margin = (cellWidth - 36)/ 2; //To display the token in the centre of a block
            if (block <= 6)
                pt = new Point(coords[block - 1, 0].X + margin, coords[block - 1, 0].Y + margin);
            else if (block <= 12)
                pt = new Point(coords[12 - block, 1].X + margin, coords[12 - block, 1].Y + margin);
            else if (block <= 18)
                pt = new Point(coords[block - 13, 2].X + margin, coords[block - 13, 2].Y + margin);
            else if (block <= 24)
                pt = new Point(coords[24 - block, 3].X + margin, coords[24 - block, 3].Y + margin);
            else if (block <= 30)
                pt = new Point(coords[block - 25, 4].X + margin, coords[block - 25, 4].Y + margin);
            else if (block <= 36)
                pt = new Point(coords[36 - block, 5].X + margin, coords[36 - block, 5].Y + margin);

            return pt;
        } //GetCoordinates

    }  //class
} //namespace
