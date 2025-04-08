namespace EasyButtons.Example
{
	public class ButtonsExample : global::UnityEngine.MonoBehaviour
	{
		[global::EasyButtons.Button]
		public void SayMyName()
		{
		}

		[global::EasyButtons.Button(Mode = global::EasyButtons.ButtonMode.DisabledInPlayMode)]
		protected void SayHelloEditor()
		{
		}

		[global::EasyButtons.Button(Mode = global::EasyButtons.ButtonMode.EnabledInPlayMode)]
		private void SayHelloInRuntime()
		{
		}

		[global::EasyButtons.Button("Special Name", Spacing = global::EasyButtons.ButtonSpacing.Before)]
		private void TestButtonName()
		{
		}

		[global::EasyButtons.Button("Special Name Editor Only", Mode = global::EasyButtons.ButtonMode.DisabledInPlayMode)]
		private void TestButtonNameEditorOnly()
		{
		}

		[global::EasyButtons.Button]
		private static void TestStaticMethod()
		{
		}

		[global::EasyButtons.Button("Space Before and After", Spacing = (global::EasyButtons.ButtonSpacing.Before | global::EasyButtons.ButtonSpacing.After))]
		private void TestButtonSpaceBoth()
		{
		}

		[global::EasyButtons.Button("Button With Parameters")]
		private void TestButtonWithParams(string message, int number)
		{
		}

		[global::EasyButtons.Button("Expanded Button Example", Expanded = true)]
		private void TestExpandedButton(string message)
		{
		}
	}
}
