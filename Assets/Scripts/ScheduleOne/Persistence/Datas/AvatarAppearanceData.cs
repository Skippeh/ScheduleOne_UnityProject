namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class AvatarAppearanceData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.AvatarFramework.AvatarSettings AvatarSettings;

		public AvatarAppearanceData(global::ScheduleOne.AvatarFramework.AvatarSettings avatarSettings)
		{
		}
	}
}
