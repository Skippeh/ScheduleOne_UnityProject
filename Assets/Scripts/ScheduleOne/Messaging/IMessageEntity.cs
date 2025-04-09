namespace ScheduleOne.Messaging
{
	public interface IMessageEntity
	{
		MSGConversation MsgConversation { get; set; }

		event ResponseCallback onResponseChosen;
	}
}
