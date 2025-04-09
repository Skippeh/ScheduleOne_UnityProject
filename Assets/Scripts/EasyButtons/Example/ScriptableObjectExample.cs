using UnityEngine;

namespace EasyButtons.Example
{
	[CreateAssetMenu(fileName = "ScriptableObjectExample.asset", menuName = "EasyButtons/ScriptableObjectExample")]
	public class ScriptableObjectExample : ScriptableObject
	{
		[Button]
		public void SayHello()
		{
		}

		[Button(Mode = ButtonMode.DisabledInPlayMode)]
		public void SayHelloEditor()
		{
		}

		[Button(Mode = ButtonMode.EnabledInPlayMode)]
		public void SayHelloPlayMode()
		{
		}
	}
}
