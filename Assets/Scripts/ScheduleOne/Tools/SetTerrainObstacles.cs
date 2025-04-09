using UnityEngine;

namespace ScheduleOne.Tools
{
	public class SetTerrainObstacles : MonoBehaviour
	{
		public BoxCollider Bounds;

		private TreeInstance[] Obstacle;

		private Terrain terrain;

		private float width;

		private float lenght;

		private float hight;

		private bool isError;

		private void Start()
		{
		}
	}
}
