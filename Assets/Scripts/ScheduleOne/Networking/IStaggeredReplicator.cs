namespace ScheduleOne.Networking
{
	public interface IStaggeredReplicator
	{
		bool IsDoneReplicating { get; }

		void SetIsDoneReplicating();
	}
}
