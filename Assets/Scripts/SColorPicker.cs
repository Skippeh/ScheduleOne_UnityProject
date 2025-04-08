public class SColorPicker : global::HSVPicker.ColorPicker
{
	public int PropertyIndex;

	public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Color, int> onValueChangeWithIndex;

	private void Start()
	{
	}

	private void ValueChanged(global::UnityEngine.Color col)
	{
	}
}
