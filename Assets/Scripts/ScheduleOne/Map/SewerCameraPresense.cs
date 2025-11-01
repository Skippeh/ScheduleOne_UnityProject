namespace ScheduleOne.Map
{
	public class SewerCameraPresense : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Map.SewerCameraPresense>
	{
		public global::UnityEngine.Transform FullPresenseVolumesContainer;

		public global::UnityEngine.Transform FadeVolumesContainer;

		public global::Funly.SkyStudio.SkyProfileOverride SewerSkyProfileOverride;

		public global::UnityEngine.Rendering.Volume SewerPPVolume;

		private global::UnityEngine.BoxCollider[] fullPresenceVolumes;

		private global::ScheduleOne.Map.SewerCameraFadeVolume[] fadeVolumes;

		public float CameraPresenceInSewerArea { get; private set; }

		public float SmoothedCameraPresenceInSewerArea { get; private set; }

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdatePresense()
		{
		}

		public bool IsPointInSewerArea(global::UnityEngine.Vector3 point)
		{
			return false;
		}
	}
}
