namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarEquippable : global::UnityEngine.MonoBehaviour
	{
		public enum ETriggerType
		{
			Trigger = 0,
			Bool = 1
		}

		public enum EHand
		{
			Left = 0,
			Right = 1
		}

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Transform AlignmentPoint;

		[global::UnityEngine.Range(0f, 1f)]
		public float Suspiciousness;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable.EHand Hand;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable.ETriggerType TriggerType;

		public string AnimationTrigger;

		public string AssetPath;

		protected global::ScheduleOne.AvatarFramework.Avatar avatar;

		[global::EasyButtons.Button]
		public void RecalculateAssetPath()
		{
		}

		protected virtual void Awake()
		{
		}

		public virtual void Equip(global::ScheduleOne.AvatarFramework.Avatar _avatar)
		{
		}

		public virtual void InitializeAnimation()
		{
		}

		public virtual void Unequip()
		{
		}

		private void PositionAnimationModel()
		{
		}

		protected void SetTrigger(string anim)
		{
		}

		protected void SetBool(string anim, bool val)
		{
		}

		protected void ResetTrigger(string anim)
		{
		}

		public virtual void ReceiveMessage(string message, object parameter)
		{
		}
	}
}
