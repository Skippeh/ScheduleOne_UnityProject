namespace ScheduleOne.NPCs
{
	public class NPCPathCache
	{
		[global::System.Serializable]
		public class PathCache
		{
			public global::UnityEngine.Vector3 Start;

			public global::UnityEngine.Vector3 End;

			public global::UnityEngine.AI.NavMeshPath Path;

			public PathCache(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.AI.NavMeshPath path)
			{
			}
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPCPathCache.PathCache> Paths { get; private set; }

		public global::UnityEngine.AI.NavMeshPath GetPath(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float sqrMaxDistance)
		{
			return null;
		}

		public void AddPath(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.AI.NavMeshPath path)
		{
		}
	}
}
