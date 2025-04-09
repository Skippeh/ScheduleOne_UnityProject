using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		public Transform[] Bullets;

		public override void Equip(ItemInstance item)
		{
		}

		public override void Fire()
		{
		}

		public override void Reload()
		{
		}

		protected override void NotifyIncrementalReload()
		{
		}

		private void SetDisplayedBullets(int count)
		{
		}
	}
}
