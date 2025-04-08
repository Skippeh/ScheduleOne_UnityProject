namespace ScheduleOne.Combat
{
	[global::System.Serializable]
	public class Impact
	{
		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::UnityEngine.RaycastHit Hit;

		public global::UnityEngine.Vector3 HitPoint;

		public global::UnityEngine.Vector3 ImpactForceDirection;

		public float ImpactForce;

		public float ImpactDamage;

		public global::ScheduleOne.Combat.EImpactType ImpactType;

		public global::FishNet.Object.NetworkObject ImpactSource;

		public int ImpactID;

		public Impact(global::UnityEngine.RaycastHit hit, global::UnityEngine.Vector3 hitPoint, global::UnityEngine.Vector3 impactForceDirection, float impactForce, float impactDamage, global::ScheduleOne.Combat.EImpactType impactType, global::ScheduleOne.PlayerScripts.Player impactSource, int impactID)
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
