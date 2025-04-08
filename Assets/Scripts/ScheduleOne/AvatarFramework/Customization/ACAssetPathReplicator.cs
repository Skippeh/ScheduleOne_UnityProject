namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACAssetPathReplicator<T> : global::ScheduleOne.AvatarFramework.Customization.ACReplicator where T : global::UnityEngine.Object
	{
		private global::ScheduleOne.AvatarFramework.Customization.ACSelection<T> selection;

		protected virtual void Awake()
		{
		}

		protected override void AvatarSettingsChanged(global::ScheduleOne.AvatarFramework.AvatarSettings newSettings)
		{
		}
	}
}
