using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACAssetPathReplicator<T> : ACReplicator where T : Object
	{
		private ACSelection<T> selection;

		protected virtual void Awake()
		{
		}

		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}
	}
}
