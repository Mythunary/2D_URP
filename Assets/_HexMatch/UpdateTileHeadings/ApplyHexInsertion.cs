using UnityEditor;
using UnityEngine;

public class ApplyHexInsertion : AReaction
{
    public BoolVariable newHexInserted;
    public IntVariable cellRings;
    public Vector3IntKeyedVector3Dictionary coordsToPositions;
    public Vector3IntKeyedVector3IntDictionary coordsTargetCoords;
    public Vector3IntKeyedTileDataDictionary coordsTileData;
    public TileDataArrayVariable tileDatas;
    public ATileDataInReaction addTileToArray;
    public GameObjectVariable potentialInsertTile;
    public ReturnNeighborCoordinates returnNeighbors;
    
    public override void React()
    {
        if(newHexInserted.value == true)
        {
            TileData newTileData = new TileData();
            newTileData.tile = potentialInsertTile.value;
            newTileData.current = Vector3Int.right;
            newTileData.target = coordsTargetCoords.dictionary[newTileData.current];
            newTileData.tile.transform.position = coordsToPositions.dictionary[newTileData.current];
            newTileData.neighborCoordinates = returnNeighbors.React(Vector3Int.right);
            addTileToArray.React(newTileData);
            newTileData.tileDataArrayIndex = tileDatas.array.Length - 1;
            newTileData.tileColor = potentialInsertTile.value.GetComponent<SpriteRenderer>().color;

            if (coordsTileData.dictionary.ContainsKey(newTileData.current) == false)
            {
                coordsTileData.dictionary.Add(newTileData.current, newTileData);
            }
            else if (coordsTileData.dictionary[newTileData.current] == null)
            {
                coordsTileData.dictionary[newTileData.current] = newTileData;
            }
            else if (coordsTileData.dictionary[newTileData.current] != null)
            {
                RecursiveInsertion(newTileData);
            }
        }
    }
    
    void RecursiveInsertion(TileData replacingTile)
    {
        Vector3Int movedFrom = replacingTile.current;
        Vector3Int movedTo = replacingTile.current + Vector3Int.right;
        TileData movedTileData;

        if (coordsToPositions.dictionary.ContainsKey(movedTo) == false)
        {
            EditorApplication.ExitPlaymode();
        }
        else
        {
            movedTileData = coordsTileData.dictionary[replacingTile.current];
            movedTileData.tile.transform.position = coordsToPositions.dictionary[movedTo];
            movedTileData.current = movedTo;
            movedTileData.target = coordsTargetCoords.dictionary[movedTo];
            movedTileData.tileDataArrayIndex = replacingTile.tileDataArrayIndex;
            movedTileData.tileColor = coordsTileData.dictionary[replacingTile.current].tileColor;

            if (coordsTileData.dictionary.ContainsKey(movedTo) == true)
            {
                if (coordsTileData.dictionary[movedTo] == null)
                {
                    coordsTileData.dictionary[movedTo] = movedTileData;
                    coordsTileData.dictionary[movedFrom] = replacingTile;
                }
                else
                {
                    RecursiveInsertion(movedTileData);
                }
            }
            else if (coordsTileData.dictionary.ContainsKey(movedTo) == false)
            {
                coordsTileData.dictionary.Add(movedTo, movedTileData);
                coordsTileData.dictionary[movedFrom] = replacingTile;
            }
        }
    }
}