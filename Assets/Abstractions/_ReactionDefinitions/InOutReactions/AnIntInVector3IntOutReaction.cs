using UnityEngine;

public abstract class AnIntInVector3IntOutReaction : ScriptableObject
{
    public abstract Vector3Int React(int key);
}
