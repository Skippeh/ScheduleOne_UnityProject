namespace ScheduleOne.Combat
{
	public interface IDamageable
	{
		void SendImpact(global::ScheduleOne.Combat.Impact impact);

		void ReceiveImpact(global::ScheduleOne.Combat.Impact impact);
	}
}
