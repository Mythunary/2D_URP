using UnityEngine;
using UnityEngine.Rendering;

public class Vector3IntKeyedTileDataDictionary : ScriptableObject
{
    public SerializedDictionary<Vector3Int, TileData> dictionary;
}
