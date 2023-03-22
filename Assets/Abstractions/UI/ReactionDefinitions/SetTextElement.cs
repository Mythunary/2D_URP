using TMPro;

public class SetTextElement : AUIReaction
{
    public StringVariable data;
    public TMP_Text text;    

    public override void React()
    {
        text.text = data.value;
    }
}