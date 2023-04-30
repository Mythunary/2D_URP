public class ChangeTileHeading : AReaction
{
    public Vector3Variable heading;
    public AVector3OutReaction converter;

    public override void React()
    {
        heading.value = converter.React();
    }
}
