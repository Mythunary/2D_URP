using UnityEngine;

public class SpawnTile : AReaction
{
    public Vector2Variable initialSpawnPosition;
    public GameObjectVariable spawnPrefab;
    public GameObjectVariable initialSpawn;

    public override void React()
    {
        initialSpawn.value = Instantiate(spawnPrefab.value, initialSpawnPosition.value, Quaternion.identity);
    }
}
