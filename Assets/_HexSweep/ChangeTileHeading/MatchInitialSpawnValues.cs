using UnityEngine;

public class MatchInitialSpawnValues : AReaction
{
    public Vector2Variable initialHeading;
    public TileHeadingVariable initialTileHeading;

    public override void React()
    {
        initialHeading.value = Vector2.up;
        initialTileHeading.value = TileHeadings.Up;
    }
}
