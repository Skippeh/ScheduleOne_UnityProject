namespace ScheduleOne.Vehicles
{
	public class VehicleColor : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class BodyMesh
		{
			public global::UnityEngine.MeshRenderer Renderer;

			public int MaterialIndex;
		}

		public global::ScheduleOne.Vehicles.VehicleColor.BodyMesh[] BodyMeshes;

		public global::ScheduleOne.Vehicles.Modification.EVehicleColor DefaultColor;

		private global::ScheduleOne.Vehicles.Modification.EVehicleColor displayedColor;

		private bool initialColorApplied;

		private void Start()
		{
		}

		public virtual void ApplyColor(global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}
	}
}
