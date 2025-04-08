namespace ScheduleOne.Tools
{
	public class OptimizedColliderGroup : global::UnityEngine.MonoBehaviour
	{
		public const int UPDATE_DISTANCE = 5;

		public global::UnityEngine.Collider[] Colliders;

		public float ColliderEnableMaxDistance;

		private float sqrColliderEnableMaxDistance;

		private bool collidersEnabled;

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void RegisterEvent()
		{
		}

		[global::EasyButtons.Button]
		public void GetColliders()
		{
		}

		public void Start()
		{
		}

		private void Refresh()
		{
		}

		private void SetCollidersEnabled(bool enabled)
		{
		}
	}
}
