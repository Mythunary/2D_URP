using UnityEngine;

public abstract class AVector3IntInVector3IntOutReaction : ScriptableObject
{
    public abstract Vector3Int React(Vector3Int value);
}
