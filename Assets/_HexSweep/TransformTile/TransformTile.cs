using UnityEngine;

public class TransformTile : AReaction
{
    public Vector2Variable tileHeading;
    public FloatVariable velocity;
    public GameObjectVariable targetTile;

    public override void React()
    {
        targetTile.value.transform.Translate(tileHeading.value * velocity.value * Time.deltaTime);
    }
}