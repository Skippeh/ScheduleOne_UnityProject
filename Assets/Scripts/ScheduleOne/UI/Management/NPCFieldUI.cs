namespace ScheduleOne.UI.Management
{
	public class NPCFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::UnityEngine.UI.Image IconImg;

		public global::TMPro.TextMeshProUGUI SelectionLabel;

		public global::UnityEngine.GameObject NoneSelected;

		public global::UnityEngine.GameObject MultipleSelected;

		public global::UnityEngine.RectTransform ClearButton;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.NPCField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.NPCField> field)
		{
		}

		private void Refresh(global::ScheduleOne.NPCs.NPC newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		public void NPCSelected(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public void ClearClicked()
		{
		}
	}
}
