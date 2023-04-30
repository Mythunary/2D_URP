using UnityEngine;

public abstract class WindingOrderElement : ScriptableObject
{
    public abstract Vector3Int React(int y);
}