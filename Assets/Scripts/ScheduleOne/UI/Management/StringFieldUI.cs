namespace ScheduleOne.UI.Management
{
	public class StringFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::TMPro.TMP_InputField InputField;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.StringField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.StringField> field)
		{
		}

		private void Refresh(string newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void ValueChanged(string value)
		{
		}
	}
}
