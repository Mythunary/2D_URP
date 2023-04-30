using UnityEngine;

public class DisableMAIN : MonoBehaviour
{
    public AReactionArrayVariable disables;

    private void OnDisable()
    {
        for (int i = 0; i < disables.array.Length; i++)
        {
            disables.array[i].React();
        }
    }
}
