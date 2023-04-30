using UnityEngine;

public class SpawnTestTiles : AReaction
{
    public GameObjectVariable hexPrefab;
    public Vector3IntKeyedVector3Dictionary coordinateWorldPositions;

    public override void React()
    {
        foreach (var position in coordinateWorldPositions.dictionary)
        {
            Instantiate(hexPrefab.value, position.Value, Quaternion.identity);
        }
    }
}