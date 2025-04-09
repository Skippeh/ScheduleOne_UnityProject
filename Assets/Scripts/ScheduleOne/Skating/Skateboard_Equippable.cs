using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Skating
{
	public class Skateboard_Equippable : Equippable_Viewmodel
	{
		public const float ModelLerpSpeed = 8f;

		public const float SurfaceSampleDistance = 0.4f;

		public const float SurfaceSampleRayLength = 0.7f;

		public const float BoardSpawnUpwardsShift = 0.1f;

		public const float BoardSpawnAngleLimit = 30f;

		public const float MountTime = 0.33f;

		public const float BoardMomentumTransfer = 1.2f;

		public const float DismountAngle = 80f;

		public Skateboard SkateboardPrefab;

		public bool blockDismount;

		[Header("References")]
		public Transform ModelContainer;

		public Transform ModelPosition_Raised;

		public Transform ModelPosition_Lowered;

		private float mountTime;

		public bool IsRiding { get; private set; }

		public Skateboard ActiveSkateboard { get; private set; }

		public override void Equip(ItemInstance item)
		{
		}

		private void Exit(ExitAction action)
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

		private Pose GetSkateboardSpawnPose()
		{
			return default(Pose);
		}
	}
}
