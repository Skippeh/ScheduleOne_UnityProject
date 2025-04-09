using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	public class Moveable : Clickable
	{
		protected Vector3 clickOffset;

		protected float clickDist;

		[Header("Bounds")]
		[SerializeField]
		protected float yMax;

		[SerializeField]
		protected float yMin;

		public override void StartClick(RaycastHit hit)
		{
		}

		protected virtual void Update()
		{
		}

		public override void EndClick()
		{
		}
	}
}
