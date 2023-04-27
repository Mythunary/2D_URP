public class TransformTile : AReaction
{
    public Vector2Variable tileHeading;
    public GameObjectVariable targetTile;

    public override void React()
    {
        targetTile.value.transform.Translate(tileHeading.value);
    }
}
