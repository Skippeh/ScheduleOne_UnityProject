using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		[Serializable]
		public class SlotAlignmentPoint
		{
			public EClothingSlot SlotType;

			public Transform Point;
		}

		public SlotAlignmentPoint[] AlignmentPoints;

		[Header("References")]
		public Transform Container;

		public ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		public ScheduleOne.AvatarFramework.Avatar Avatar;

		public Transform AvatarContainer;

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

		public void SetAppearance(AvatarSettings settings)
		{
		}
	}
}
