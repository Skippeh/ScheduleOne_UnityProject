namespace ScheduleOne.UI.Phone
{
	public class UtilitiesApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.UtilitiesApp>
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text water_Usage;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text water_Cost;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text water_Total;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text electricity_Usage;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text electricity_Cost;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text electricity_Total;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text dumpster_Count;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text dumpster_EmptyCost;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text dumpster_Total;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button dumpsterButton;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.UI.PropertyDropdown propertySelector;

		private global::ScheduleOne.Property.Property selectedProperty;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		protected virtual void RefreshShownValues()
		{
		}

		protected virtual void OnDayPass()
		{
		}

		private float Round(float n, float decimals)
		{
			return 0f;
		}

		public override void SetOpen(bool open)
		{
		}
	}
}
