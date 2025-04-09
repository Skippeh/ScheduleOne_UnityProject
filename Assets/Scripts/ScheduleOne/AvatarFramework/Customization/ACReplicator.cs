using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACReplicator : MonoBehaviour
	{
		public string propertyName;

		private void Start()
		{
		}

		protected virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}
	}
}
