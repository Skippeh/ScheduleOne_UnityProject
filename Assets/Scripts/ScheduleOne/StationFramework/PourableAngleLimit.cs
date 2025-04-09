using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	public class PourableAngleLimit : MonoBehaviour
	{
		public PourableModule Pourable;

		public DraggableConstraint Constraint;

		[Header("Settings")]
		public float AngleAtMaxFill;

		public float AngleAtMinFill;

		public float PourAngleMaxFill;

		public float PourAngleMinFill;

		private void Awake()
		{
		}

		public void FixedUpdate()
		{
		}
	}
}
