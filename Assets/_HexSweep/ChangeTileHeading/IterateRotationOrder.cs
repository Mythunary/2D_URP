public class IterateRotationOrder : AReaction
{
    public CoordinateHeadingVariable heading;

    public override void React()
    {
        if(heading.value != CoordinateHeading.UpLeft)
        {
            heading.value++;
        }
        else
        {
            heading.value = CoordinateHeading.Up;
        }
    }
}
