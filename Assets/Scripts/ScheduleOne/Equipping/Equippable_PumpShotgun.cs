namespace ScheduleOne.Equipping
{
	public class Equippable_PumpShotgun : global::ScheduleOne.Equipping.Equippable_RangedWeapon
	{
		[global::UnityEngine.Header("Shotgun Settings")]
		public int PelletCount;

		protected override global::UnityEngine.Vector3[] GetBulletDirections()
		{
			return null;
		}
	}
}
