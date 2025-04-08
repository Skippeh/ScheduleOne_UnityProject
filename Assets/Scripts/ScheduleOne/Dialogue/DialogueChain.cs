namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class DialogueChain
	{
		[global::UnityEngine.TextArea(1, 10)]
		public string[] Lines;

		public global::ScheduleOne.UI.Phone.Messages.MessageChain GetMessageChain()
		{
			return null;
		}
	}
}
