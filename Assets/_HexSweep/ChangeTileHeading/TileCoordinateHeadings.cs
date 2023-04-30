using UnityEngine;

public class TileCoordinateHeadings : AnIntInVector3IntOutReaction
{    
    public Vector3IntArrayVariable coordinateValues;

    public override Vector3Int React(int key)
    {
        return coordinateValues.array[key];
    }
}