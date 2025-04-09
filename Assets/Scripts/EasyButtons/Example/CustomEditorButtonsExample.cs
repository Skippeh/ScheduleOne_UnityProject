using UnityEngine;

namespace EasyButtons.Example
{
	public class CustomEditorButtonsExample : MonoBehaviour
	{
		[Button("Custom Editor Example")]
		private void SayHello()
		{
		}

		[Button]
		private void SecondButton()
		{
		}
	}
}
