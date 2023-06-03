public class CalculateTilesNeighborCoordinates : AReaction
{
    public TileDataArrayVariable tileDatas;
    public AVector3IntInVector3IntArrayOutReaction returnNeighborCoordinates;

    public override void React()
    {
        for (int i = 0; i < tileDatas.array.Length; i++)
        {
            tileDatas.array[i].neighborCoordinates
                = returnNeighborCoordinates.React(tileDatas.array[i].current);
        }
    }
}