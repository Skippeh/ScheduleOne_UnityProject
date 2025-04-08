namespace ScheduleOne.UI.Management
{
	public class ObjectFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public string InstructionText;

		public string ExtendedInstructionText;

		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::UnityEngine.UI.Image IconImg;

		public global::TMPro.TextMeshProUGUI SelectionLabel;

		public global::UnityEngine.GameObject NoneSelected;

		public global::UnityEngine.GameObject MultipleSelected;

		public global::UnityEngine.RectTransform ClearButton;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.ObjectField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.ObjectField> field)
		{
		}

		private void Refresh(global::ScheduleOne.EntityFramework.BuildableItem newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		private bool ObjectValid(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectsSelected(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> objs)
		{
		}

		private void ObjectSelected(global::ScheduleOne.EntityFramework.BuildableItem obj)
		{
		}

		public void ClearClicked()
		{
		}
	}
}
