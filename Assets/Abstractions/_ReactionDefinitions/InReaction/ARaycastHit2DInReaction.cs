using UnityEngine;

public abstract class ARaycastHit2DInReaction : ScriptableObject
{
    public abstract void React(RaycastHit2D hit);
}
