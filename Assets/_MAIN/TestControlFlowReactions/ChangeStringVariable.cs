public class ChangeStringVariable : AReaction
{
    public SetTextElement element;
    public StringVariable newString;

    public override void React()
    {
        element.data = newString;
    }
}
