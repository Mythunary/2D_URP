public class ClearTileDataArrays : AReaction
{
    public TileDataArrayVariable[] arrays;

    public override void React()
    {
        for (int i = 0; i < arrays.Length; i++)
        {
            arrays[i].array = new TileData[0];
        }
    }
}
