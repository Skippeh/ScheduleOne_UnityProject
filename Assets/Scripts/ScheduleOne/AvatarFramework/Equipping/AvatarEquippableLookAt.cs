using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	[RequireComponent(typeof(AvatarEquippable))]
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		public int Priority;

		private Avatar avatar;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
