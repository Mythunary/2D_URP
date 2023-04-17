using UnityEngine;

public class InitMAIN : MonoBehaviour
{
    public AReaction[] inits;

    private void Start()
    {
        for (int i = 0; i < inits.Length; i++)
        {
            inits[i].React();
        }
    }
}
