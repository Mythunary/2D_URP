public class ReceiveToggleUpdate : ABoolInReaction
{
    public BoolVariable valueHolder;
    public AReaction reactionForToggleChange;

    public override void React(bool value)
    {
        valueHolder.value = value;
        reactionForToggleChange.React();
    }
}