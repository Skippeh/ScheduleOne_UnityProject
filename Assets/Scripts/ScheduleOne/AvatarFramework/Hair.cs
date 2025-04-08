namespace ScheduleOne.AvatarFramework
{
	public class Hair : global::ScheduleOne.AvatarFramework.Accessory
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject[] hairToHide;

		public bool BlockedByHat { get; protected set; }

		public void SetBlockedByHat(bool blocked)
		{
		}

		protected virtual void BlockHair()
		{
		}

		protected virtual void UnBlockHair()
		{
		}
	}
}
