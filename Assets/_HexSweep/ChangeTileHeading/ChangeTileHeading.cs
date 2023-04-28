public class ChangeTileHeading : AReaction
{
    public Vector2Variable heading;
    public AVector2OutReaction converter;

    public override void React()
    {
        heading.value = converter.React();
    }
}
