using UnityEngine;

public class UpdateTileHeadings : AReaction
{
    public TileDataArrayVariable tileDatas;
    public Vector3IntKeyedVector3IntDictionary cellsHeadings;
    public Vector3IntKeyedVector3Dictionary cellsWorldPositions;
    public Vector3IntKeyedTileDataDictionary cellsTileData;
    public BoolVariable newHexInserted;
    Vector3Int previousCoordinate;

    public override void React()
    {
        for (int i = 0; i < tileDatas.array.Length; i++)
        {
            tileDatas.array[i].heading
                = cellsWorldPositions.dictionary[tileDatas.array[i].target]
                - cellsWorldPositions.dictionary[tileDatas.array[i].current];

            previousCoordinate = tileDatas.array[i].current;
            tileDatas.array[i].current = tileDatas.array[i].target;
            tileDatas.array[i].target = cellsHeadings.dictionary[tileDatas.array[i].target];

            if (cellsTileData.dictionary.ContainsKey(previousCoordinate) == true)
            {
                if (cellsTileData.dictionary[previousCoordinate] == tileDatas.array[i])
                {
                    cellsTileData.dictionary[previousCoordinate] = null;
                }
            }
            if (cellsTileData.dictionary.ContainsKey(tileDatas.array[i].current) == false)
            {
                cellsTileData.dictionary.Add(tileDatas.array[i].current, tileDatas.array[i]);
            }
            else
            {
                cellsTileData.dictionary[tileDatas.array[i].current] = tileDatas.array[i];
            }
        }
    }
}