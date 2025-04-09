using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	public class PoliceBelt : Accessory
	{
		[Header("References")]
		[SerializeField]
		protected GameObject BatonObject;

		[SerializeField]
		protected GameObject TaserObject;

		[SerializeField]
		protected GameObject GunObject;

		public void SetBatonVisible(bool vis)
		{
		}

		public void SetTaserVisible(bool vis)
		{
		}

		public void SetGunVisible(bool vis)
		{
		}
	}
}
