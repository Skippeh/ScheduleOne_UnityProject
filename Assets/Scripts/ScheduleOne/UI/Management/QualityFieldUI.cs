namespace ScheduleOne.UI.Management
{
	public class QualityFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::UnityEngine.UI.Button[] QualityButtons;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.QualityField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.QualityField> field)
		{
		}

		private void Refresh(global::ScheduleOne.ItemFramework.EQuality value)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void ValueChanged(global::ScheduleOne.ItemFramework.EQuality value)
		{
		}
	}
}
