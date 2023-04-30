using UnityEngine;

public class GridCoordinatesToPositions : AReaction
{
    public GridVariable grid;
    public IntVariable cellRings;
    public Vector3IntKeyedVector3Dictionary cellsWorldPosition;
    public WindingOrderElement[] windingOrderElements;

    public override void React()
    {
        Vector3Int upHeading = new Vector3Int(1, 0, 0);
        Vector3Int newCoordinate = upHeading;
        int switchHeadingIndex;

        for (int i = 1; i <= cellRings.value; i++)
        {
            for (int j = 0; j < 6*i; j++)
            {
                switchHeadingIndex = j / i;
                
                newCoordinate += windingOrderElements[switchHeadingIndex].React(newCoordinate.y);

                cellsWorldPosition.dictionary.Add(newCoordinate, grid.value.CellToWorld(newCoordinate));
            }
            newCoordinate += upHeading;
        }
    }
}