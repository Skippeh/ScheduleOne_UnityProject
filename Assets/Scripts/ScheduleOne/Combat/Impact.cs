using System;
using FishNet.Object;
using FishNet.Serializing.Helping;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	[Serializable]
	public class Impact
	{
		[CodegenExclude]
		public RaycastHit Hit;

		public Vector3 HitPoint;

		public Vector3 ImpactForceDirection;

		public float ImpactForce;

		public float ImpactDamage;

		public EImpactType ImpactType;

		public NetworkObject ImpactSource;

		public int ImpactID;

		public Impact(RaycastHit hit, Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, Player impactSource, int impactID)
		{
		}

		public Impact()
		{
		}

		public static bool IsLethal(EImpactType impactType)
		{
			return false;
		}

		public bool IsPlayerImpact(out Player player)
		{
			player = null;
			return false;
		}
	}
}
