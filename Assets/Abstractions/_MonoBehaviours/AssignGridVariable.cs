using UnityEngine;

public class AssignGridVariable : MonoBehaviour
{
    public GridVariable grid;

    private void Start()
    {
        grid.value = GetComponent<Grid>();
    }
}
