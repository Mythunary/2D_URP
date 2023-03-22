using TMPro;
using UnityEngine;

public class SubscribeTextForUpdate : MonoBehaviour
{
    public SetTextElement reaction;

    private void Start()
    {
        reaction.text = GetComponent<TMP_Text>();
    }
}
