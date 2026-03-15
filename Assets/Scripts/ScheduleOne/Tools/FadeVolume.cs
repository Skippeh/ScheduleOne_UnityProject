namespace ScheduleOne.Tools
{
	public class FadeVolume : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("StartPoint")]
		private global::UnityEngine.Transform _startPoint;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("EndPoint")]
		private global::UnityEngine.Transform _endPoint;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("BoxCollider")]
		private global::UnityEngine.BoxCollider _boxCollider;

		private void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public float GetPositionScalar(global::UnityEngine.Vector3 point)
		{
			return 0f;
		}
	}
}
