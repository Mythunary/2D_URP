public class IterateRotationOrder : AReaction
{
    public TileHeadingVariable heading;

    public override void React()
    {
        if(heading.value != TileHeadings.UpLeft)
        {
            heading.value++;
        }
        else
        {
            heading.value = TileHeadings.Up;
        }
    }
}
