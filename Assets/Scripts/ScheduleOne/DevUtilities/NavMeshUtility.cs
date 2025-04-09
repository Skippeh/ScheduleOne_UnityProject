using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.DevUtilities
{
	public static class NavMeshUtility
	{
		public const float SAMPLE_MAX_DISTANCE = 2f;

		public static Dictionary<Vector3, Vector3> SampleCache;

		public static List<Vector3> sampleCacheKeys;

		public const float SAMPLE_CACHE_MAX_SQR_DIST = 1f;

		public const float MAX_CACHE_SIZE = 10000f;

		public static float GetPathLength(NavMeshPath path)
		{
			return 0f;
		}

		public static Transform GetAccessPoint(ITransitEntity entity, NPC npc)
		{
			return null;
		}

		public static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			return false;
		}

		public static int GetNavMeshAgentID(string name)
		{
			return 0;
		}

		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			hit = default(NavMeshHit);
			return false;
		}

		private static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			return default(Vector3);
		}

		public static void ClearCache()
		{
		}
	}
}
