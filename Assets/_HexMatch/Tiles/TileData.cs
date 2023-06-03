using System;
using UnityEngine;

[Serializable]
public class TileData
{
    public GameObject tile;
    public Vector3 heading;
    public Vector3Int current;
    public Vector3Int target;
    public float velocity;
    public int tileDataArrayIndex;
    public Vector3Int[] neighborCoordinates;
    public Color tileColor;
}