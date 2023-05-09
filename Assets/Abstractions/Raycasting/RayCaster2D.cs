using UnityEngine;

public class RayCaster2D : AReaction
{
    public ARaycastHit2DInReaction reaction;
    Vector2 mousePosition;
    RaycastHit2D hit;

    public override void React()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        
        if (hit != default)
        {
            reaction.React(hit);
            hit = default;
        }
    }
}