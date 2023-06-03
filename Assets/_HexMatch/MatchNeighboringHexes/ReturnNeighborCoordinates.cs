using UnityEngine;

public class ReturnNeighborCoordinates : AVector3IntInVector3IntArrayOutReaction
{
    public AHexHeadingArrayVariable hexHeadings;
    Vector3Int[] coordinates = new Vector3Int[6];

    public override Vector3Int[] React(Vector3Int target)
    {
        for (int i = 0; i < coordinates.Length; i++)
        {
            coordinates[i] = target + hexHeadings.array[i].React(target.y);
        }
        return coordinates;
    }
}