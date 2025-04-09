using UnityEngine;

namespace ScheduleOne.Skating
{
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardVisuals : MonoBehaviour
	{
		[Header("Settings")]
		public float MaxBoardLean;

		public float BoardLeanRate;

		[Header("References")]
		public Transform Board;

		private Skateboard skateboard;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
