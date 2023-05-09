using UnityEngine;

public class DeliverRandomTile : AGameObjectOutReaction
{
    public GameObjectVariable potentialInsertTile;
    public GameObjectArrayVariable hexPrefabs;

    public override GameObject React()
    {
        potentialInsertTile.value = Instantiate(hexPrefabs.array[Random.Range(0, hexPrefabs.array.Length)], Vector3.zero, Quaternion.identity);
        potentialInsertTile.value.gameObject.tag = "SelectableSpawn";
        return potentialInsertTile.value;
    }
}