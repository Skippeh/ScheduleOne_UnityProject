namespace ScheduleOne.Combat
{
	public struct ExplosionData
	{
		public float DamageRadius;

		public float MaxDamage;

		public float PushForceRadius;

		public float MaxPushForce;

		public static readonly global::ScheduleOne.Combat.ExplosionData DefaultSmall;

		public ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
		{
			DamageRadius = 0f;
			MaxDamage = 0f;
			PushForceRadius = 0f;
			MaxPushForce = 0f;
		}
	}
}
