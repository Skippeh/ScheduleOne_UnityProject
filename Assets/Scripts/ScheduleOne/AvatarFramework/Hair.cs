using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	public class Hair : Accessory
	{
		[SerializeField]
		private GameObject[] hairToHide;

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
