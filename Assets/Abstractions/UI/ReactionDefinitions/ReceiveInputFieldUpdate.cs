public class ReceiveInputFieldUpdate : AStringInReaction
{
    public StringVariable valueHolder;
    public AReactionComposite reactionOnNewValue;

    public override void React(string value)
    {
        valueHolder.value = value;
        reactionOnNewValue.React();
    }
}
