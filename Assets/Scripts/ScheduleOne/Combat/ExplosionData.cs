namespace ScheduleOne.Combat
{
	public struct ExplosionData
	{
		public float DamageRadius;

		public float MaxDamage;

		public float PushForceRadius;

		public float MaxPushForce;

		public bool CheckLoS;

		public global::ScheduleOne.Combat.EExplosionType ExplosionType;

		public static readonly global::ScheduleOne.Combat.ExplosionData DefaultSmall;

		public static readonly global::ScheduleOne.Combat.ExplosionData LightningStrike;

		public ExplosionData(float damageRadius, float maxDamage, float maxPushForce, bool checkLoS, global::ScheduleOne.Combat.EExplosionType explosionType = global::ScheduleOne.Combat.EExplosionType.Default)
		{
			DamageRadius = 0f;
			MaxDamage = 0f;
			PushForceRadius = 0f;
			MaxPushForce = 0f;
			CheckLoS = false;
			ExplosionType = default(global::ScheduleOne.Combat.EExplosionType);
		}
	}
}
