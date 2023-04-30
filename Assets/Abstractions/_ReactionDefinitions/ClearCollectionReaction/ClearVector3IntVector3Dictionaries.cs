public class ClearVector3IntVector3Dictionaries : AReaction
{
    public Vector3IntKeyedVector3Dictionary[] dictionaries;

    public override void React()
    {
        for (int i = 0; i < dictionaries.Length; i++)
        {
            dictionaries[i].dictionary.Clear();
        }
    }
}
