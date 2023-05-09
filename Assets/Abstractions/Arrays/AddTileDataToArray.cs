public class AddTileDataToArray : ATileDataInReaction
{
    public TileDataArrayVariable array;
    TileData[] newArray;

    public override void React(TileData data)
    {
        newArray = new TileData[array.array.Length + 1];
        for (int i = 0; i < array.array.Length; i++)
        {
            newArray[i] = array.array[i];
        }
        newArray[array.array.Length] = data;
        array.array = newArray;
    }
}
