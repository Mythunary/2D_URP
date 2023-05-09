public class ClearVector3IntVector3IntDictionaries : AReaction
{
    public Vector3IntKeyedVector3IntDictionary[] dictionaries;

    public override void React()
    {
        for (int i = 0; i < dictionaries.Length; i++)
        {
            dictionaries[i].dictionary.Clear();
        }
    }
}
