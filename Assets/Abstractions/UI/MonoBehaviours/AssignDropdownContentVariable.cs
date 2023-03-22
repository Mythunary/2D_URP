using UnityEngine;

public class AssignDropdownContentVariable : MonoBehaviour
{
    public GameObjectVariable content;

    private void Start()
    {
        content.value = gameObject;
    }
}
