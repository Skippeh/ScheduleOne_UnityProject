namespace ScheduleOne.Combat
{
	public struct ExplosionData
	{
		public float DamageRadius;

		public float MaxDamage;

		public float PushForceRadius;

		public float MaxPushForce;

		public static readonly ExplosionData DefaultSmall = new ExplosionData(6f, 200f, 500f);

		public ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
		{
			this.DamageRadius = damageRadius;
			this.MaxDamage = maxDamage;
			this.PushForceRadius = maxPushForce;
			this.MaxPushForce = maxPushForce;
		}
	}
}
