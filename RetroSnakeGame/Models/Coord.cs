using RetroSnakeGame.Enum;

namespace RetroSnakeGame.Models
{
    public class Coord
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ApplyDirection(DirectionEnum direction)
        {
            switch (direction)
            {
                case DirectionEnum.Up:
                    Y--;
                    break;
                case DirectionEnum.Down:
                    Y++;
                    break;
                case DirectionEnum.Left:
                    X--;
                    break;
                case DirectionEnum.Right:
                    X++;
                    break;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is Coord other)
            {
                return X == other.X && Y == other.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }
}
