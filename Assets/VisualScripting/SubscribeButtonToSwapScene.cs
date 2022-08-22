using Unity.VisualScripting;
using UnityEngine.UIElements;

public class SubscribeButtonToSwapScene : Unit
{
    [DoNotSerialize]
    [PortLabelHidden]
    public ControlInput controlInput;

    [DoNotSerialize]
    [PortLabelHidden]
    public ControlOutput controlOutput;

    [DoNotSerialize]
    [PortLabelHidden]
    public ValueInput button;

    [DoNotSerialize]
    public ValueInput sceneName;

    protected override void Definition()
    {
        button = ValueInput<Button>("button");
        sceneName = ValueInput<string>("sceneName", string.Empty);
        controlOutput = ControlOutput("controlOutput");

        controlInput = ControlInput("controlInput", (flow) => 
        {
            flow.GetValue<Button>(button).clicked += () =>
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(flow.GetValue<string>(sceneName));
            };
            return controlOutput;
        });
    }
}