namespace ScheduleOne.Combat
{
	[global::System.Serializable]
	public class Impact
	{
		public global::UnityEngine.Vector3 HitPoint;

		public global::UnityEngine.Vector3 ImpactForceDirection;

		public float ImpactForce;

		public float ImpactDamage;

		public global::ScheduleOne.Combat.EImpactType ImpactType;

		public global::FishNet.Object.NetworkObject ImpactSource;

		public int ImpactID;

		public Impact(global::UnityEngine.Vector3 hitPoint, global::UnityEngine.Vector3 impactForceDirection, float impactForce, float impactDamage, global::ScheduleOne.Combat.EImpactType impactType, global::FishNet.Object.NetworkObject impactSource, int impactID = 0)
		{
		}

		public Impact()
		{
		}

		public static bool IsLethal(global::ScheduleOne.Combat.EImpactType impactType)
		{
			return false;
		}

		public bool IsPlayerImpact(out global::ScheduleOne.PlayerScripts.Player player)
		{
			player = null;
			return false;
		}
	}
}
