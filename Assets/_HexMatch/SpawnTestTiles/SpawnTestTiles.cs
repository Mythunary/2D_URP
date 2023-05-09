using System.Collections.Generic;
using UnityEngine;

public class SpawnTestTiles : AReaction
{
    public GameObjectArrayVariable hexPrefabs;
    public Vector3IntKeyedVector3Dictionary coordinateWorldPositions;
    public Vector3IntKeyedVector3IntDictionary cellsHeadings;
    public TileDataArrayVariable targetTiles;

    public override void React()
    {
        List<TileData> localTileDatas = new List<TileData>();

        foreach (var position in coordinateWorldPositions.dictionary)
        {
            TileData localTileData = new TileData();
            localTileData.tile = Instantiate(hexPrefabs.array[Random.Range(0,6)], position.Value, Quaternion.identity);
            localTileData.target = cellsHeadings.dictionary[position.Key];
            localTileData.heading = coordinateWorldPositions.dictionary[localTileData.target] - position.Value;
            localTileDatas.Add(localTileData);
        }

        targetTiles.array = localTileDatas.ToArray();
    }
}