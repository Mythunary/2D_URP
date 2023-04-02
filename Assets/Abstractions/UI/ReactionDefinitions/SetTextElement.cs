using TMPro;

public class SetTextElement : AReaction
{
    public StringVariable data;
    public TMP_Text text;    

    public override void React()
    {
        text.text = data.value;
    }
}