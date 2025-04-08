public class TrailerCop : global::UnityEngine.MonoBehaviour
{
	public global::ScheduleOne.Police.PoliceOfficer Officer;

	public global::UnityEngine.Transform StartPoint;

	public global::UnityEngine.Transform EndPoint;

	public global::UnityEngine.Transform FaceTarget;

	public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable Equippable;

	public float Speed;

	public bool RaiseWeapon;

	public global::UnityEngine.Transform ShootTarget;

	[global::EasyButtons.Button]
	public void Play()
	{
	}

	private void Update()
	{
	}

	public void Shoot()
	{
	}
}
