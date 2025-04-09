using System;
using System.Collections.Generic;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.UI.Relations;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ContactsApp
{
	public class ContactsApp : App<ContactsApp>
	{
		[Serializable]
		public class RegionUI
		{
			public EMapRegion Region;

			public Button Button;

			public RectTransform Container;

			public RectTransform ConnectionsContainer;

			public List<NPC> npcs { get; set; }
		}

		public EMapRegion SelectedRegion;

		private Dictionary<EMapRegion, RegionUI> RegionDict;

		[Header("References")]
		public RectTransform CirclesContainer;

		public RectTransform DemoCirclesContainer;

		public RectTransform TutorialCirclesContainer;

		public RectTransform ConnectionsContainer;

		public RectTransform ContentRect;

		public RectTransform SelectionIndicator;

		public ContactsDetailPanel DetailPanel;

		public RegionUI[] RegionUIs;

		public RectTransform RegionSelectionContainer;

		public RectTransform RegionSelectionIndicator;

		public RectTransform LockedRegionContainer;

		public Text RegionRankRequirementLabel;

		public Image SelectedRegionIcon;

		[Header("Prefabs")]
		public GameObject ConnectionPrefab;

		private List<RelationCircle> RelationCircles;

		private Coroutine contentMoveRoutine;

		private List<Tuple<NPC, NPC>> connections;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private RelationCircle GetRelationCircle(string npcID)
		{
			return null;
		}

		private void CircleClicked(RelationCircle circ)
		{
		}

		private void Select(RelationCircle circ)
		{
		}

		public void SetSelectedRegion(EMapRegion region)
		{
		}

		private void ZoomToRect(RectTransform rect)
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
