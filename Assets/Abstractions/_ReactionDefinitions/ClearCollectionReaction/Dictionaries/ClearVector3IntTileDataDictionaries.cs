public class ClearVector3IntTileDataDictionaries : AReaction
{
    public Vector3IntKeyedTileDataDictionary[] dictionaries;

    public override void React()
    {
        for (int i = 0; i < dictionaries.Length; i++)
        {
            dictionaries[i].dictionary.Clear();
        }
    }
}
