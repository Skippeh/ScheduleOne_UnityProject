using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Tools
{
	[RequireComponent(typeof(NPCMovement))]
	public class NPCWalkTo : MonoBehaviour
	{
		public Transform Target;

		public float RepathRate;

		private float timeSinceLastPath;

		private void Update()
		{
		}
	}
}
