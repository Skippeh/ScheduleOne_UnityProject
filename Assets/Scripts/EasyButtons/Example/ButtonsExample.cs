using UnityEngine;

namespace EasyButtons.Example
{
	public class ButtonsExample : MonoBehaviour
	{
		[Button]
		public void SayMyName()
		{
		}

		[Button(Mode = ButtonMode.DisabledInPlayMode)]
		protected void SayHelloEditor()
		{
		}

		[Button(Mode = ButtonMode.EnabledInPlayMode)]
		private void SayHelloInRuntime()
		{
		}

		[Button("Special Name", Spacing = ButtonSpacing.Before)]
		private void TestButtonName()
		{
		}

		[Button("Special Name Editor Only", Mode = ButtonMode.DisabledInPlayMode)]
		private void TestButtonNameEditorOnly()
		{
		}

		[Button]
		private static void TestStaticMethod()
		{
		}

		[Button("Space Before and After", Spacing = (ButtonSpacing.Before | ButtonSpacing.After))]
		private void TestButtonSpaceBoth()
		{
		}

		[Button("Button With Parameters")]
		private void TestButtonWithParams(string message, int number)
		{
		}

		[Button("Expanded Button Example", Expanded = true)]
		private void TestExpandedButton(string message)
		{
		}
	}
}
