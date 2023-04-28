using UnityEngine;

public class TileHeadingConverter : AVector2OutReaction
{
    public TileHeadingVariable heading;
    public Vector2[] headings;

    public override Vector2 React()
    {
        return headings[(int)heading.value];
    }
}