public class DebugRunMessage : AStringOutReaction
{
    public StringVariable message;

    public override string React()
    {
        return message.value;
    }
}
