namespace ScheduleOne.Messaging
{
	public interface IMessageEntity
	{
		global::ScheduleOne.Messaging.MSGConversation MsgConversation { get; set; }

		event global::ScheduleOne.Messaging.ResponseCallback onResponseChosen;
	}
}
