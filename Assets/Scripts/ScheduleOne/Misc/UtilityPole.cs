namespace ScheduleOne.Misc
{
	public class UtilityPole : global::UnityEngine.MonoBehaviour
	{
		public const float CABLE_CULL_DISTANCE = 100f;

		public const float CABLE_CULL_DISTANCE_SQR = 10000f;

		public global::ScheduleOne.Misc.UtilityPole previousPole;

		public global::ScheduleOne.Misc.UtilityPole nextPole;

		public bool Connection1Enabled;

		public bool Connection2Enabled;

		public float LengthFactor;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform cable1Connection;

		public global::UnityEngine.Transform cable2Connection;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> cable1Segments;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> cable2Segments;

		public global::UnityEngine.Transform Cable1Container;

		public global::UnityEngine.Transform Cable2Container;

		private global::UnityEngine.Vector3 cableStart;

		private global::UnityEngine.Vector3 cableEnd;

		private global::UnityEngine.Vector3 cableMid;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void UpdateCulling()
		{
		}

		[global::EasyButtons.Button]
		public void Orient()
		{
		}

		[global::EasyButtons.Button]
		public void DrawLines()
		{
		}
	}
}
