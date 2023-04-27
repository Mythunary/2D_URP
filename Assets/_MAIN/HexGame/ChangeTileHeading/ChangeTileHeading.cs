public class ChangeTileHeading : AReaction
{
    public Vector2Variable heading;
    public Vector2Variable newHeading;

    public override void React()
    {
        heading.value = newHeading.value;        
    }
}
