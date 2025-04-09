using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		public ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		public Animator Animator;

		public ScheduleOne.AvatarFramework.Avatar Avatar;

		public Transform RightHandContainer;

		private Vector3 baseOffset;

		public bool IsVisible { get; private set; }

		protected override void Awake()
		{
		}

		public void SetVisibility(bool isVisible)
		{
		}

		public void SetAppearance(AvatarSettings settings)
		{
		}

		public void SetAnimatorController(RuntimeAnimatorController controller)
		{
		}

		public void SetOffset(Vector3 offset)
		{
		}
	}
}
