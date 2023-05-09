using UnityEngine;

public class WindingOrderDown : WindingOrderElement
{
    public override Vector3Int React(int y)
    {
        return new Vector3Int(-1, 0, 0);
    }
}