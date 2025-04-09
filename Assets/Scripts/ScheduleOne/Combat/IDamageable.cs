namespace ScheduleOne.Combat
{
	public interface IDamageable
	{
		void SendImpact(Impact impact);

		void ReceiveImpact(Impact impact);
	}
}
