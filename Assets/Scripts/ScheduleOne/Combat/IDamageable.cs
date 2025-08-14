namespace ScheduleOne.Combat
{
	public interface IDamageable
	{
		global::UnityEngine.GameObject gameObject { get; }

		void SendImpact(global::ScheduleOne.Combat.Impact impact);

		void ReceiveImpact(global::ScheduleOne.Combat.Impact impact);
	}
}
