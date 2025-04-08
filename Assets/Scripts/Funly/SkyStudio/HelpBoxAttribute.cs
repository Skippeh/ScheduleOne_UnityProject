namespace Funly.SkyStudio
{
	public class HelpBoxAttribute : global::UnityEngine.PropertyAttribute
	{
		public string text;

		public global::Funly.SkyStudio.HelpBoxMessageType messageType;

		public HelpBoxAttribute(string text, global::Funly.SkyStudio.HelpBoxMessageType messageType = global::Funly.SkyStudio.HelpBoxMessageType.None)
		{
		}
	}
}
