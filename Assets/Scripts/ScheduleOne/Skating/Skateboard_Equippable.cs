namespace ScheduleOne.Skating
{
	public class Skateboard_Equippable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		public const float ModelLerpSpeed = 8f;

		public const float SurfaceSampleDistance = 0.4f;

		public const float SurfaceSampleRayLength = 0.7f;

		public const float BoardSpawnUpwardsShift = 0.05f;

		public const float BoardSpawnAngleLimit = 30f;

		public const float MountTime = 0.33f;

		public const float BoardMomentumTransfer = 1.2f;

		public const float DismountAngle = 80f;

		public global::ScheduleOne.Skating.Skateboard SkateboardPrefab;

		public bool blockDismount;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform ModelContainer;

		public global::UnityEngine.Transform ModelPosition_Raised;

		public global::UnityEngine.Transform ModelPosition_Lowered;

		private float mountTime;

		public bool IsRiding { get; private set; }

		public global::ScheduleOne.Skating.Skateboard ActiveSkateboard { get; private set; }

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected override void Update()
		{
		}

		private void UpdateModel()
		{
		}

		public override void Unequip()
		{
		}

		public void Mount()
		{
		}

		public void Dismount()
		{
		}

		private bool CanMountHere()
		{
			return false;
		}

		private global::UnityEngine.Pose GetSkateboardSpawnPose()
		{
			return default(global::UnityEngine.Pose);
		}
	}
}
