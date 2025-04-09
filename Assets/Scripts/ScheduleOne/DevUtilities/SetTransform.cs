using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class SetTransform : MonoBehaviour
	{
		[Header("Frequency Settings")]
		public bool SetOnAwake;

		public bool SetOnUpdate;

		public bool SetOnLateUpdate;

		[Header("Transform Settings")]
		public bool SetPosition;

		public Vector3 LocalPosition;

		public bool SetRotation;

		public Vector3 LocalRotation;

		public bool SetScale;

		public Vector3 LocalScale;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Set()
		{
		}
	}
}
