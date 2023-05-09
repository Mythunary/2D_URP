using UnityEngine;

public class RotateTiles : AReaction
{    
    public TileDataArrayVariable targetTiles;
    public FloatVariable rotationVelocity;

    public override void React()
    {
        for (int i = 0; i < targetTiles.array.Length; i++)
        {
            targetTiles.array[i].tile.transform.Translate(targetTiles.array[i].heading * rotationVelocity.value * Time.deltaTime);
        }
    }
}