using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public interface IToken
    {
        void Move(int block);
    }

    public class Token : Panel, IToken
    {
        private Board board;

        public Token(Board board, Control parent, Color color)
        {
            //Local alias
            this.board = board;

            //Token size in pixels
            if (color == Color.Red)
                Width = Height = 40;
            else
                Width = Height = 36;

            this.BackColor = color;

            //Rounded form
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);

            //Display token on its parent control (the form)
            parent.Controls.Add(this);
            BringToFront();

        } //Constructor

        public new void Move(int block)
        {
            if (block == 0) //Reset
                Location = new Point(0, board.image.Height);
            else
                Location = board.GetCoordinates(block);
        } //Move

    } //class Token
}
