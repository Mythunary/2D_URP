using System.Linq;
using TMPro;
using UnityEngine;

public class ConfigureDropdownOptions : MonoBehaviour
{
    public StringArrayVariable textOptions;

    private void Start()
    {
        textOptions.array = GetComponent<TMP_Dropdown>().options.Select(r => r.text).ToArray();
    }
}
