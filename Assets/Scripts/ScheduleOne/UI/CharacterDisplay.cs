namespace ScheduleOne.UI
{
	public class CharacterDisplay : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.CharacterDisplay>
	{
		[global::System.Serializable]
		public class SlotAlignmentPoint
		{
			public global::ScheduleOne.Clothing.EClothingSlot SlotType;

			public global::UnityEngine.Transform Point;
		}

		public global::ScheduleOne.UI.CharacterDisplay.SlotAlignmentPoint[] AlignmentPoints;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Container;

		public global::ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::UnityEngine.Transform AvatarContainer;

		private float targetRotation;

		public bool IsOpen { get; private set; }

		protected override void Awake()
		{
		}

		public void SetOpen(bool open)
		{
		}

		private void Update()
		{
		}

		public void SetAppearance(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}
	}
}
