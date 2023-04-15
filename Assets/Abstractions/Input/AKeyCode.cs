using UnityEngine;

public abstract class AKeyCode : ScriptableObject
{
    public abstract KeyCode inputKey { get; }
    public BoolVariable status;
    public AReaction reaction;
}