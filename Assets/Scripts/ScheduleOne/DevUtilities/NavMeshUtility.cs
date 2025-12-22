namespace ScheduleOne.DevUtilities
{
	public static class NavMeshUtility
	{
		public const float SAMPLE_MAX_DISTANCE = 2f;

		public static global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector3, global::UnityEngine.Vector3> SampleCache;

		public static global::System.Collections.Generic.List<global::UnityEngine.Vector3> sampleCacheKeys;

		public const float SAMPLE_CACHE_MAX_SQR_DIST = 1f;

		public const float MAX_CACHE_SIZE = 10000f;

		public static float GetPathLength(global::UnityEngine.AI.NavMeshPath path)
		{
			return 0f;
		}

		public static global::UnityEngine.Transform GetReachableAccessPoint(global::ScheduleOne.Management.ITransitEntity entity, global::ScheduleOne.NPCs.NPC npc)
		{
			return null;
		}

		public static bool IsAtTransitEntity(global::ScheduleOne.Management.ITransitEntity entity, global::ScheduleOne.NPCs.NPC npc, float distanceThreshold = 0.4f)
		{
			return false;
		}

		public static int GetNavMeshAgentID(string name)
		{
			return 0;
		}

		public static bool SamplePosition(global::UnityEngine.Vector3 sourcePosition, out global::UnityEngine.AI.NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			hit = default(global::UnityEngine.AI.NavMeshHit);
			return false;
		}

		private static global::UnityEngine.Vector3 Quantize(global::UnityEngine.Vector3 position, float precision = 0.1f)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static void ClearCache()
		{
		}
	}
}
