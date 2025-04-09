using UnityEngine;
using UnityEngine.Events;

public class SColorPicker : HSVPicker.ColorPicker
{
	public int PropertyIndex;

	public UnityEvent<Color, int> onValueChangeWithIndex;

	private void Start()
	{
	}

	private void ValueChanged(Color col)
	{
	}
}
