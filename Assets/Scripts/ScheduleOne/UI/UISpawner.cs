namespace ScheduleOne.UI
{
	public class UISpawner : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.RectTransform SpawnArea;

		public global::UnityEngine.GameObject[] Prefabs;

		public float MinInterval;

		public float MaxInterval;

		public float SpawnRateMultiplier;

		public global::UnityEngine.Vector2 MinScale;

		public global::UnityEngine.Vector2 MaxScale;

		public bool UniformScale;

		private float nextSpawnTime;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.GameObject> OnSpawn;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
