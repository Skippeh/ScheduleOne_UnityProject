using EasyButtons;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Police;
using UnityEngine;

public class TrailerCop : MonoBehaviour
{
	public PoliceOfficer Officer;

	public Transform StartPoint;

	public Transform EndPoint;

	public Transform FaceTarget;

	public AvatarEquippable Equippable;

	public float Speed;

	public bool RaiseWeapon;

	public Transform ShootTarget;

	[Button]
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
