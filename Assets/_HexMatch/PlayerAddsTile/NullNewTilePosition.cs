using UnityEngine;

public class NullNewTilePosition : AReaction
{
    public Vector3IntKeyedTileDataDictionary cellsTileDatas;
    public BoolVariable newHexInserted;

    public override void React()
    {
        //if(newHexInserted.value == true)
        //{
        //    cellsTileDatas.dictionary[Vector3Int.right] = null;
        //}
        newHexInserted.value = false;
    }
}