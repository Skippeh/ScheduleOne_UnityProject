using System;
using ScheduleOne.AvatarFramework;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class AvatarAppearanceData : SaveData
	{
		public AvatarSettings AvatarSettings;

		public AvatarAppearanceData(AvatarSettings avatarSettings)
		{
		}
	}
}
