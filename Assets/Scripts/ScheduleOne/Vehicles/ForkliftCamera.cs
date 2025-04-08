namespace ScheduleOne.Vehicles
{
	public class ForkliftCamera : global::ScheduleOne.Vehicles.VehicleCamera
	{
		[global::UnityEngine.Header("Forklift References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform forkCamPos;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Light guidanceLight;

		protected bool forkliftCamActive;

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}
	}
}
