namespace SnakesAndLadders
{
    public delegate void delLadderSnake(Player player, int block);
    public delegate void delDone(Player player);
    public delegate void delSix(Player player);

    public interface IPlayer
    {
        event delLadderSnake OnLadder, OnSnake;
        event delDone OnDone;
        event delSix OnSix;

        string Name { get; }
        int currentBlock { get; }

        void Reset();
        void Advance(int dice);
        string ToString();
    } //Interface IPlayer

    public class Player : IPlayer
    {
        public string Name { get; private set; }
        public int currentBlock { get; private set; }
        private Token token;
        public event delLadderSnake OnLadder, OnSnake;
        public event delDone OnDone;
        public event delSix OnSix;

        public Player(string sName, Token token)
        {
            currentBlock = 0;
            Name = sName;
            this.token = token;
            Reset();
        } //Constructor

        public void Reset()
        {
            currentBlock = 0;
            token.Move(0);
        }

        public override string ToString()
        {
            return Name;
        } //ToString()

        public void Advance(int dice)
        {
            //New block - will be assigned to special block if no special event is invoked
            int advanceBlock = currentBlock + dice;

            if (advanceBlock == 3)
            {
                token.Move(advanceBlock);
                OnLadder?.Invoke(this, 22);
                currentBlock = 22;
            }
            else if (advanceBlock == 18)
            {
                token.Move(advanceBlock);
                OnLadder?.Invoke(this, 29);
                currentBlock = 29;
            }
            else if (advanceBlock == 21)
            {
                token.Move(advanceBlock);
                OnSnake?.Invoke(this, 6);
                currentBlock = 6;
            }
            else if (advanceBlock == 35)
            {
                token.Move(advanceBlock);
                OnSnake?.Invoke(this, 11);
                currentBlock = 11;
            }
            else if (advanceBlock == 36)
            {
                token.Move(advanceBlock);
                OnDone?.Invoke(this);
                currentBlock = 36;
            }
            else if (advanceBlock < 36)
            {
                currentBlock = advanceBlock;
            }

            //Move token to new block
            token.Move(currentBlock);
            
            //Check for six
            if (dice == 6)
                OnSix?.Invoke(this);

        } //Advance



    } //Player
} //namespace
