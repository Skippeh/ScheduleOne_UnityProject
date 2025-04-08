namespace ScheduleOne.Misc
{
	public class CarStopper : global::UnityEngine.MonoBehaviour
	{
		public bool isActive;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform blocker;

		public global::UnityEngine.AI.NavMeshObstacle Obstacle;

		private float moveTime;

		protected virtual void Update()
		{
		}
	}
}
