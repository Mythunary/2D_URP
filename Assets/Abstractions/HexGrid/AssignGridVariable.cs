using UnityEngine;

public class AssignGridVariable : MonoBehaviour
{
    public GridVariable grid;

    private void Awake()
    {
        grid.value = GetComponent<Grid>();
    }
}