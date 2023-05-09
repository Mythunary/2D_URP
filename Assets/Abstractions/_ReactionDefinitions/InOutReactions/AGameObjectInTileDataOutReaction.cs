using UnityEngine;

public abstract class AGameObjectInTileDataOutReaction : ScriptableObject
{
    public abstract TileData React(GameObject gameObject);
}