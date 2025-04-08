namespace ScheduleOne.Map
{
	public class MapPositionUtility : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Map.MapPositionUtility>
	{
		public global::UnityEngine.Transform OriginPoint;

		public global::UnityEngine.Transform EdgePoint;

		public float MapDimensions;

		private float conversionFactor { get; set; }

		protected override void Awake()
		{
		}

		public global::UnityEngine.Vector2 GetMapPosition(global::UnityEngine.Vector3 worldPosition)
		{
			return default(global::UnityEngine.Vector2);
		}

		[global::EasyButtons.Button]
		public void Recalculate()
		{
		}
	}
}
