namespace ScheduleOne.UI.Management
{
	public class ItemFieldUI : global::UnityEngine.MonoBehaviour
	{
		public bool ShowNoneAsAny;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::UnityEngine.UI.Image IconImg;

		public global::TMPro.TextMeshProUGUI SelectionLabel;

		public global::UnityEngine.GameObject NoneSelected;

		public global::UnityEngine.GameObject MultipleSelected;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.ItemField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.ItemField> field)
		{
		}

		private void Refresh(global::ScheduleOne.ItemFramework.ItemDefinition newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		private void OptionSelected(global::ScheduleOne.UI.Management.ItemSelector.Option option)
		{
		}
	}
}
