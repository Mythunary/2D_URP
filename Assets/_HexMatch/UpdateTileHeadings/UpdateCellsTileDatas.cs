using UnityEngine;

public class UpdateCellsTileDatas : AReaction
{
    public Vector3IntKeyedTileDataDictionary cellsTileDatas;
    public TileDataArrayVariable tileDatas;

    TileData currentData;
    Vector3Int currentCoordinate;
    Vector3Int targetCoordinate;

    public override void React()
    {
        for (int i = 0; i < tileDatas.array.Length; i++)
        {
            currentData = tileDatas.array[i];
            currentCoordinate = currentData.current;
            targetCoordinate = currentData.target;
            if (cellsTileDatas.dictionary.ContainsKey(currentCoordinate) == false)
            {
                cellsTileDatas.dictionary.Add(currentCoordinate, currentData);
            }
            else if (cellsTileDatas.dictionary[currentCoordinate] == currentData)
            {
                cellsTileDatas.dictionary[currentCoordinate] = null;
            }
            //if(cellsTileDatas.dictionary.ContainsKey(targetCoordinate) == false)
            //{
            //    cellsTileDatas.dictionary.Add(targetCoordinate, currentData);
            //}
            //else
            //{
            //    cellsTileDatas.dictionary[targetCoordinate] = currentData;
            //}
        }
    }
}