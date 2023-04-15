public class ChangeSetTextVariable : AReaction
{
    public SetTextElement sObj;
    public StringVariable newData;

    public override void React()
    {
        sObj.data = newData;
    }
}
