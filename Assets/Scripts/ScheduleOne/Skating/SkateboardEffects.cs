using UnityEngine;

namespace ScheduleOne.Skating
{
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardEffects : MonoBehaviour
	{
		private Skateboard skateboard;

		[Header("References")]
		public TrailRenderer[] Trails;

		private float trailsOpacity;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
