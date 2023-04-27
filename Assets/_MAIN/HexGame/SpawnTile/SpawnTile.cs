using UnityEngine;

public class SpawnTile : AReaction
{
    public Vector2Variable initialSpawnPosition;
    public GameObjectVariable spawnPrefab;

    public override void React()
    {
        Instantiate(spawnPrefab.value, initialSpawnPosition.value, Quaternion.identity);
    }
}
