using UnityEngine;

public class AxisInputReceptor : MonoBehaviour
{
    public AnAxisHandlerArrayVariable axisHandlersPositive;
    public AnAxisHandlerArrayVariable axisHandlersNegative;
    public AnAxisHandlerArrayVariable axisHandlersZero;

    private void Update()
    {
        for (int i = 0; i < axisHandlersPositive.array.Length; i++)
        {
            if (Input.GetAxis(axisHandlersPositive.array[i].name) > 0)
            {
                axisHandlersPositive.array[i].React(Input.GetAxis(axisHandlersPositive.array[i].name));
            }
        }
        for (int i = 0; i < axisHandlersNegative.array.Length; i++)
        {
            if (Input.GetAxis(axisHandlersNegative.array[i].name) < 0)
            {
                axisHandlersNegative.array[i].React(Input.GetAxis(axisHandlersNegative.array[i].name));
            }
        }
        for (int i = 0; i < axisHandlersZero.array.Length; i++)
        {
            if (Input.GetAxis(axisHandlersZero.array[i].name) == 0)
            {
                axisHandlersZero.array[i].React(0f);
            }
        }
    }
}