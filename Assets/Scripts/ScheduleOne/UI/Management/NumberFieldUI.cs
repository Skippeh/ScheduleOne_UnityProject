namespace ScheduleOne.UI.Management
{
	public class NumberFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::UnityEngine.UI.Slider Slider;

		public global::TMPro.TextMeshProUGUI ValueLabel;

		public global::TMPro.TextMeshProUGUI MinValueLabel;

		public global::TMPro.TextMeshProUGUI MaxValueLabel;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.NumberField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.NumberField> field)
		{
		}

		private void Refresh(float newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void ValueChanged(float value)
		{
		}
	}
}
