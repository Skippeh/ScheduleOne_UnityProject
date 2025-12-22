namespace ScheduleOne.StationFramework
{
	public class MushroomSpawnStationItem : global::ScheduleOne.StationFramework.StationItem
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.MeshRenderer[] _renderers;

		[global::UnityEngine.SerializeField]
		private int _materialIndex;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _injectionPortHighlight;

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Collider InjectionPortCollider { get; private set; }

		protected override void Awake()
		{
		}

		public void SetInocculationAmount(float amount)
		{
		}

		public void SetInjectionPortHighlightActive(bool active)
		{
		}
	}
}
