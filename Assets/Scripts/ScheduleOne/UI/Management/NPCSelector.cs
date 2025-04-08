namespace ScheduleOne.UI.Management
{
	public class NPCSelector : global::UnityEngine.MonoBehaviour
	{
		public const float SELECTION_RANGE = 5f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask DetectionMask;

		public global::UnityEngine.Color HoverOutlineColor;

		private global::System.Type TypeRequirement;

		private global::System.Action<global::ScheduleOne.NPCs.NPC> callback;

		private global::ScheduleOne.NPCs.NPC hoveredNPC;

		private global::ScheduleOne.NPCs.NPC highlightedNPC;

		public bool IsOpen { get; protected set; }

		private void Start()
		{
		}

		public virtual void Open(string selectionTitle, global::System.Type typeRequirement, global::System.Action<global::ScheduleOne.NPCs.NPC> _callback)
		{
		}

		public virtual void Close(bool returnToClipboard)
		{
		}

		private void Update()
		{
		}

		private global::ScheduleOne.NPCs.NPC GetHoveredNPC()
		{
			return null;
		}

		public bool IsNPCTypeValid(global::ScheduleOne.NPCs.NPC npc)
		{
			return false;
		}

		public void NPCClicked(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		private void ClipboardClosed()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exitAction)
		{
		}
	}
}
