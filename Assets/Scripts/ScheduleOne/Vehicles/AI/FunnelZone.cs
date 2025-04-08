namespace ScheduleOne.Vehicles.AI
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.BoxCollider))]
	public class FunnelZone : global::UnityEngine.MonoBehaviour
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.AI.FunnelZone> funnelZones;

		public global::UnityEngine.BoxCollider col;

		public global::UnityEngine.Transform entryPoint;

		protected virtual void Awake()
		{
		}

		public static global::ScheduleOne.Vehicles.AI.FunnelZone GetFunnelZone(global::UnityEngine.Vector3 point)
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
