using UnityEngine;

public class StartMAIN : MonoBehaviour
{
    public AReactionArrayVariable starts;

    private void Start()
    {
        for (int i = 0; i < starts.array.Length; i++)
        {
            starts.array[i].React();
        }
    }
}
