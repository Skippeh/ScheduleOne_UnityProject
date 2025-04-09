using ScheduleOne.Map;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ContactsApp
{
	public class ContactsDetailPanel : MonoBehaviour
	{
		[Header("Settings")]
		public Color DependenceColor_Min;

		public Color DependenceColor_Max;

		[Header("References")]
		public VerticalLayoutGroup LayoutGroup;

		public Text NameLabel;

		public Text TypeLabel;

		public Text UnlockHintLabel;

		public RectTransform RelationshipContainer;

		public Scrollbar RelationshipScrollbar;

		public Text RelationshipLabel;

		public RectTransform AddictionContainer;

		public Scrollbar AddictionScrollbar;

		public Text AddictionLabel;

		public RectTransform PropertiesContainer;

		public Text PropertiesLabel;

		public Button ShowOnMapButton;

		public RectTransform StandardsContainer;

		public Image StandardsStar;

		public Text StandardsLabel;

		private POI poi;

		public NPC SelectedNPC { get; protected set; }

		public void Open(NPC npc)
		{
		}

		public void ShowOnMap()
		{
		}
	}
}
