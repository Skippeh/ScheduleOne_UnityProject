namespace ScheduleOne.UI.Management
{
	public class ObjectListFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public string FieldText;

		public string InstructionText;

		public string ExtendedInstructionText;

		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::UnityEngine.GameObject NoneSelected;

		public global::UnityEngine.GameObject MultipleSelected;

		public global::UnityEngine.RectTransform[] Entries;

		public global::UnityEngine.UI.Button Button;

		public global::UnityEngine.GameObject EditIcon;

		public global::UnityEngine.GameObject NoMultiEdit;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.ObjectListField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.ObjectListField> field)
		{
		}

		private void Refresh(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> newVal)
		{
		}

		private void RemoveEntryClicked(int index)
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

		public void Clear()
		{
		}
	}
}
