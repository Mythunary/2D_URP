using UnityEngine;

public class BuildCellCollections : AReaction
{
    public GridVariable grid;
    public IntVariable cellRings;
    public Vector3IntKeyedVector3Dictionary cellsWorldPositions;
    public Vector3IntKeyedVector3IntDictionary cellsTargetCoordinates;
    public WindingOrderElement[] windingOrderElements;

    public override void React()
    {
        Vector3Int upHeading = new Vector3Int(1, 0, 0);
        Vector3Int initialCoordinate = upHeading;
        Vector3Int updatedCoordinate = Vector3Int.zero;
        int switchHeadingIndex;

        for (int i = 1; i <= cellRings.value; i++)
        {
            for (int j = 0; j < 6*i; j++)
            {
                switchHeadingIndex = j / i;
                
                updatedCoordinate = initialCoordinate + windingOrderElements[switchHeadingIndex].React(initialCoordinate.y);

                if(cellsTargetCoordinates.dictionary.ContainsKey(initialCoordinate) == false)
                {
                    cellsTargetCoordinates.dictionary.Add(initialCoordinate, updatedCoordinate);
                }
                cellsWorldPositions.dictionary.Add(updatedCoordinate, grid.value.CellToWorld(updatedCoordinate));
                initialCoordinate = updatedCoordinate;
            }
            initialCoordinate = updatedCoordinate + upHeading;
        }
    }
}