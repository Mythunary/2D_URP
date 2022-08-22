using Unity.VisualScripting;
using UnityEngine.UIElements;

public class SubscribeButtonToExitGame : Unit
{
    [DoNotSerialize]
    [PortLabelHidden]
    public ControlInput controlInput;

    [DoNotSerialize]
    [PortLabelHidden]
    public ValueInput button;

    protected override void Definition()
    {
        button = ValueInput<Button>("button");

        controlInput = ControlInput("controlInput", (flow) =>
        {
            flow.GetValue<Button>(button).clicked += () =>
            {
                //UnityEngine.Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            };
            return null;
        });
    }
}
