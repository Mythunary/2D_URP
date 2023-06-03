using UnityEngine;

public abstract class AVector3IntInVector3IntArrayOutReaction : ScriptableObject
{
    public abstract Vector3Int[] React(Vector3Int target);
}
