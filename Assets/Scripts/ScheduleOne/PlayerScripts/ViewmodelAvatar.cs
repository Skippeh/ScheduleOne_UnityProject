namespace ScheduleOne.PlayerScripts
{
	public class ViewmodelAvatar : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.PlayerScripts.ViewmodelAvatar>
	{
		public global::ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		public global::UnityEngine.Animator Animator;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::UnityEngine.Transform RightHandContainer;

		private global::UnityEngine.Vector3 baseOffset;

		public bool IsVisible { get; private set; }

		protected override void Awake()
		{
		}

		public void SetVisibility(bool isVisible)
		{
		}

		public void SetAppearance(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void SetAnimatorController(global::UnityEngine.RuntimeAnimatorController controller)
		{
		}

		public void SetOffset(global::UnityEngine.Vector3 offset)
		{
		}
	}
}
