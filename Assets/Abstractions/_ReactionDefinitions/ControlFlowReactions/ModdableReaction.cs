using System;

public class ModdableReaction : AReaction
{
    public AReactionArrayVariable reactions;
    public IntVariable index;

    public override void React()
    {
        reactions.array[index.value].React();
    }
}