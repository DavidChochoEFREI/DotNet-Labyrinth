using Labyrinth.Items;
using Labyrinth.Tiles;

namespace Labyrinth.Crawl;

public class StandardCrawler : ICrawler
{
    public int X { get; }
    public int Y { get; }
    public Direction Direction { get; }
    public Tile FacingTile { get; }
    public Inventory Walk()
    {
        throw new NotImplementedException();
    }

    public StandardCrawler(int x, int y, Direction direction, Tile facingTile)
    {
        X = x;
        Y = y;
        Direction = direction;
        FacingTile = facingTile;
    }
}