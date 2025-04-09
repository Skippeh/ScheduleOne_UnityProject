using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Misc
{
	public class TreeScaler : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		protected List<Transform> branchMeshes;

		public float minScale;

		public float maxScale;

		public float minScaleDistance;

		public float maxScaleDistance;

		protected virtual void Start()
		{
		}

		private void UpdateScale()
		{
		}
	}
}
