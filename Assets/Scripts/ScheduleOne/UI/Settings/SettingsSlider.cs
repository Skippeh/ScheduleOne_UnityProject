namespace ScheduleOne.UI.Settings
{
	public class SettingsSlider : global::UnityEngine.MonoBehaviour
	{
		public float ValueDisplayTime;

		public bool DisplayValue;

		protected global::UnityEngine.UI.Slider slider;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI valueLabel;

		protected float timeOnValueChange;

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnValueChanged(float value)
		{
		}

		protected void SetDisplayValue(float value)
		{
		}

		protected void SetValueWithoutNotify(float value)
		{
		}

		protected virtual string GetDisplayValue(float value)
		{
			return null;
		}
	}
}
