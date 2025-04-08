namespace ScheduleOne.UI.Phone.ContactsApp
{
	public class ContactsApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.ContactsApp.ContactsApp>
	{
		[global::System.Serializable]
		public class RegionUI
		{
			public global::ScheduleOne.Map.EMapRegion Region;

			public global::UnityEngine.UI.Button Button;

			public global::UnityEngine.RectTransform Container;

			public global::UnityEngine.RectTransform ConnectionsContainer;

			public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> npcs { get; set; }
		}

		public global::ScheduleOne.Map.EMapRegion SelectedRegion;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Map.EMapRegion, global::ScheduleOne.UI.Phone.ContactsApp.ContactsApp.RegionUI> RegionDict;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform CirclesContainer;

		public global::UnityEngine.RectTransform DemoCirclesContainer;

		public global::UnityEngine.RectTransform TutorialCirclesContainer;

		public global::UnityEngine.RectTransform ConnectionsContainer;

		public global::UnityEngine.RectTransform ContentRect;

		public global::UnityEngine.RectTransform SelectionIndicator;

		public global::ScheduleOne.UI.Phone.ContactsApp.ContactsDetailPanel DetailPanel;

		public global::ScheduleOne.UI.Phone.ContactsApp.ContactsApp.RegionUI[] RegionUIs;

		public global::UnityEngine.RectTransform RegionSelectionContainer;

		public global::UnityEngine.RectTransform RegionSelectionIndicator;

		public global::UnityEngine.RectTransform LockedRegionContainer;

		public global::UnityEngine.UI.Text RegionRankRequirementLabel;

		public global::UnityEngine.UI.Image SelectedRegionIcon;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject ConnectionPrefab;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Relations.RelationCircle> RelationCircles;

		private global::UnityEngine.Coroutine contentMoveRoutine;

		private global::System.Collections.Generic.List<global::System.Tuple<global::ScheduleOne.NPCs.NPC, global::ScheduleOne.NPCs.NPC>> connections;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private global::ScheduleOne.UI.Relations.RelationCircle GetRelationCircle(string npcID)
		{
			return null;
		}

		private void CircleClicked(global::ScheduleOne.UI.Relations.RelationCircle circ)
		{
		}

		private void Select(global::ScheduleOne.UI.Relations.RelationCircle circ)
		{
		}

		public void SetSelectedRegion(global::ScheduleOne.Map.EMapRegion region)
		{
		}

		private void ZoomToRect(global::UnityEngine.RectTransform rect)
		{
		}

		private void StopContentMove()
		{
		}

		public override void SetOpen(bool open)
		{
		}
	}
}
