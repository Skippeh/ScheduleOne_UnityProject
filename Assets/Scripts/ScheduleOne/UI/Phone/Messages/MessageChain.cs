namespace ScheduleOne.UI.Phone.Messages
{
	[global::System.Serializable]
	public class MessageChain
	{
		[global::UnityEngine.TextArea(2, 10)]
		public global::System.Collections.Generic.List<string> Messages;

		[global::UnityEngine.HideInInspector]
		public int id;

		public static global::ScheduleOne.UI.Phone.Messages.MessageChain Combine(global::ScheduleOne.UI.Phone.Messages.MessageChain a, global::ScheduleOne.UI.Phone.Messages.MessageChain b)
		{
			return null;
		}
	}
}
