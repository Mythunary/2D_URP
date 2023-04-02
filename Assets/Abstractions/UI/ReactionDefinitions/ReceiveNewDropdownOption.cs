public class ReceiveNewDropdownOption : AnIntInReaction
{
    public IntVariable dataHolder;
    public AReaction reactToNewOption;

    public override void React(int value)
    {
        dataHolder.value = value;
        reactToNewOption.React();
    }
}