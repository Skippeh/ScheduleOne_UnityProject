using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.NPCs
{
	public class NPCPathCache
	{
		[Serializable]
		public class PathCache
		{
			public Vector3 Start;

			public Vector3 End;

			public NavMeshPath Path;

			public PathCache(Vector3 start, Vector3 end, NavMeshPath path)
			{
			}
		}

		public List<PathCache> Paths { get; private set; }

		public NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			return null;
		}

		public void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
		}
	}
}
