using UnityEngine;

public class WindingOrderUp : WindingOrderElement
{
    public override Vector3Int React(int y)
    {
        return new Vector3Int(1, 0, 0);
    }
}