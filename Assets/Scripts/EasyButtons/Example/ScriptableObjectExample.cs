namespace EasyButtons.Example
{
	[global::UnityEngine.CreateAssetMenu(fileName = "ScriptableObjectExample.asset", menuName = "EasyButtons/ScriptableObjectExample")]
	public class ScriptableObjectExample : global::UnityEngine.ScriptableObject
	{
		[global::EasyButtons.Button]
		public void SayHello()
		{
		}

		[global::EasyButtons.Button(Mode = global::EasyButtons.ButtonMode.DisabledInPlayMode)]
		public void SayHelloEditor()
		{
		}

		[global::EasyButtons.Button(Mode = global::EasyButtons.ButtonMode.EnabledInPlayMode)]
		public void SayHelloPlayMode()
		{
		}
	}
}
