using Labyrinth.Items;
using Labyrinth.Tiles;

namespace Labyrinth.Crawl;

public class StandardCrawler : ICrawler
{
    public int X { get; }
    public int Y { get; }
    public Direction Direction { get; }

    public Tile FacingTile
    {
        get
        {
            var newX = X + Direction.DeltaX;
            var newY = Y + Direction.DeltaY;
            try
            {
                return _tiles[newX, newY];
            }
            catch (IndexOutOfRangeException)
            {
                return Outside.Singleton;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public Inventory Walk()
    {
        throw new NotImplementedException();
    }

    public StandardCrawler(int x, int y, Direction direction, Tile[,] tiles)
    {
        X = x;
        Y = y;
        Direction = direction;
        _tiles = tiles;
    }
    
    private readonly Tile[,] _tiles;
 
}