using System.Collections.Generic;
using ScheduleOne.DevUtilities;

namespace ScheduleOne
{
	public class AchievementManager : PersistentSingleton<AchievementManager>
	{
		public enum EAchievement
		{
			COMPLETE_PROLOGUE = 0,
			RV_DESTROYED = 1,
			DEALER_RECRUITED = 2,
			MASTER_CHEF = 3,
			BUSINESSMAN = 4,
			BIGWIG = 5,
			MAGNATE = 6,
			UPSTANDING_CITIZEN = 7,
			ROLLING_IN_STYLE = 8,
			LONG_ARM_OF_THE_LAW = 9,
			INDIAN_DEALER = 10
		}

		private EAchievement[] achievements;

		private Dictionary<EAchievement, bool> achievementUnlocked;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void PullAchievements()
		{
		}

		public void UnlockAchievement(EAchievement achievement)
		{
		}
	}
}
