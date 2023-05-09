public class ButtonGuardUp : AReaction
{
    public BoolVariable buttonPressed;
    public AReaction reaction;

    public override void React()
    {
        if (buttonPressed.value == false)
        {
            reaction.React();
        }
    }
}
