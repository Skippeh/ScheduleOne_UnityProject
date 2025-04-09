using UnityEngine;

namespace Funly.SkyStudio
{
	public class HelpBoxAttribute : PropertyAttribute
	{
		public string text;

		public HelpBoxMessageType messageType;

		public HelpBoxAttribute(string text, HelpBoxMessageType messageType = HelpBoxMessageType.None)
		{
		}
	}
}
