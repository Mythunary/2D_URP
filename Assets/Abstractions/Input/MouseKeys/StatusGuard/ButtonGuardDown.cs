public class ButtonGuardDown : AReaction
{
    public BoolVariable buttonPressed;
    public AReaction reaction;

    public override void React()
    {
        if(buttonPressed.value == true)
        {
            reaction.React();
        }
    }
}
