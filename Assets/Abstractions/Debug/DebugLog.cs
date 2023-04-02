using UnityEngine;

public class DebugLog : AReaction
{
    public AStringOutReaction message;

    public override void React()
    {
        Debug.Log(message.React());
    }
}
