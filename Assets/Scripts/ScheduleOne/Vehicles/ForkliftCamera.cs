using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class ForkliftCamera : VehicleCamera
	{
		[Header("Forklift References")]
		[SerializeField]
		protected Transform forkCamPos;

		[SerializeField]
		protected Light guidanceLight;

		protected bool forkliftCamActive;

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}
	}
}
