namespace ScheduleOne.PlayerTasks
{
	public class Moveable : global::ScheduleOne.PlayerTasks.Clickable
	{
		protected global::UnityEngine.Vector3 clickOffset;

		protected float clickDist;

		[global::UnityEngine.Header("Bounds")]
		[global::UnityEngine.SerializeField]
		protected float yMax;

		[global::UnityEngine.SerializeField]
		protected float yMin;

		public override void StartClick(global::UnityEngine.RaycastHit hit)
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
