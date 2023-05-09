using UnityEngine;

public class PlayerClicksSpawnedTile : ARaycastHit2DInReaction
{
    public BoolVariable newHexInserted;

    public override void React(RaycastHit2D hit)
    {
        if (hit.collider.gameObject.tag == "SelectableSpawn")
        {
            newHexInserted.value = true;
            hit.collider.gameObject.tag = "HexOnGrid";
        }
    }
}