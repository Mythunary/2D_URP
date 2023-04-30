using UnityEngine;

public class GridCoordinatesToCoordinateHeadings : AReaction
{
    public Grid grid;
    public IntVariable cellRings;
    public Vector3IntKeyedVector3IntDictionary cellHeadings;
    
    public override void React()
    {
        Vector3Int newCoordinate = new Vector3Int();
        //Vector3Int newHeading = new Vector3Int();

        for (int z = -cellRings.value; z < cellRings.value; z++)
        {
            for (int y = -cellRings.value; y < cellRings.value; y++)
            {
                for (int x = -cellRings.value; x < cellRings.value; x++)
                {
                    newCoordinate.x = x;
                    newCoordinate.y = y;
                    newCoordinate.z = z;



                    //cellHeadings.dictionary.Add(newCoordinate, );
                }
            }
        }
    }
}
