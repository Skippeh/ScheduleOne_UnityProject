namespace ScheduleOne.Law
{
	public class LawController : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Law.LawController>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public const float DAILY_INTENSITY_DRAIN = 0.05f;

		[global::UnityEngine.Range(1f, 10f)]
		public int LE_Intensity;

		private float internalLawIntensity;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Law.LawActivitySettings MondaySettings;

		public global::ScheduleOne.Law.LawActivitySettings TuesdaySettings;

		public global::ScheduleOne.Law.LawActivitySettings WednesdaySettings;

		public global::ScheduleOne.Law.LawActivitySettings ThursdaySettings;

		public global::ScheduleOne.Law.LawActivitySettings FridaySettings;

		public global::ScheduleOne.Law.LawActivitySettings SaturdaySettings;

		public global::ScheduleOne.Law.LawActivitySettings SundaySettings;

		[global::UnityEngine.Header("Demo Settings")]
		public float IntensityIncreasePerDay;

		private global::ScheduleOne.Persistence.Loaders.LawLoader loader;

		public bool OverrideSettings { get; protected set; }

		public global::ScheduleOne.Law.LawActivitySettings OverriddenSettings { get; protected set; }

		public global::ScheduleOne.Law.LawActivitySettings CurrentSettings { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		protected override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnLoadComplete()
		{
		}

		private void MinPass()
		{
		}

		private void HourPass()
		{
		}

		private void DayPass()
		{
		}

		public global::ScheduleOne.Law.LawActivitySettings GetSettings()
		{
			return null;
		}

		public global::ScheduleOne.Law.LawActivitySettings GetSettings(global::ScheduleOne.GameTime.EDay day)
		{
			return null;
		}

		public void OverrideSetings(global::ScheduleOne.Law.LawActivitySettings settings)
		{
		}

		public void EndOverride()
		{
		}

		public void ChangeInternalIntensity(float change)
		{
		}

		public void SetInternalIntensity(float intensity)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.LawData data)
		{
		}
	}
}
