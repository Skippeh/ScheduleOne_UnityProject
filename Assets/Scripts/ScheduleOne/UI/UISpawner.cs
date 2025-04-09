using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	public class UISpawner : MonoBehaviour
	{
		public RectTransform SpawnArea;

		public GameObject[] Prefabs;

		public float MinInterval;

		public float MaxInterval;

		public float SpawnRateMultiplier;

		public Vector2 MinScale;

		public Vector2 MaxScale;

		public bool UniformScale;

		private float nextSpawnTime;

		public UnityEvent<GameObject> OnSpawn;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
