using UnityEngine;

public class HexUpLeft : AHexHeading
{
    public override Vector3Int React(int y)
    {
        return y % 2 == 0 ? new Vector3Int(0, -1, 0) : new Vector3Int(1, -1, 0);
    }
}