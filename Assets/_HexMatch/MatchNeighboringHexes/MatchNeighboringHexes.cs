using UnityEngine;

public class MatchNeighboringHexes : AReaction
{    
    public TileDataArrayVariable TileDatas;
    public Vector3IntKeyedTileDataDictionary TileDataCoords;
    public ColorVariable matchColor;
    TileData targetData;
    TileData neighborData;

    public override void React()
    {
        for (int i = 0; i < TileDatas.array.Length; i++)
        {
            targetData = TileDatas.array[i];
            Vector3Int[] neighborCoordinates = targetData.neighborCoordinates;
            Color targetColor = targetData.tileColor;

            for (int j = 0; j < neighborCoordinates.Length; j++)
            {
                if (TileDataCoords.dictionary.ContainsKey(neighborCoordinates[j]))
                {
                    if (TileDataCoords.dictionary[neighborCoordinates[j]] != null)
                    {
                        neighborData = TileDataCoords.dictionary[neighborCoordinates[j]];
                        Color neighborColor = neighborData.tileColor;                       

                        if (targetColor == neighborColor && neighborData != targetData)
                        {
                            neighborData.tile.gameObject.GetComponent<SpriteRenderer>().color = matchColor.value;
                            targetData.tile.gameObject.GetComponent<SpriteRenderer>().color = matchColor.value;
                        }
                        else
                        {
                            neighborData.tile.gameObject.GetComponent<SpriteRenderer>().color = neighborData.tileColor;
                            targetData.tile.gameObject.GetComponent<SpriteRenderer>().color = targetData.tileColor;
                        }
                    }
                }
            }
        }
    }
}