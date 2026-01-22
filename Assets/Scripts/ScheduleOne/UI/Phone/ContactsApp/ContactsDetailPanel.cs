namespace ScheduleOne.UI.Phone.ContactsApp
{
	public class ContactsDetailPanel : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Color DependenceColor_Min;

		public global::UnityEngine.Color DependenceColor_Max;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Text NameLabel;

		public global::UnityEngine.UI.Text TypeLabel;

		public global::UnityEngine.UI.Text UnlockHintLabel;

		public global::UnityEngine.RectTransform RelationshipContainer;

		public global::UnityEngine.UI.Scrollbar RelationshipScrollbar;

		public global::UnityEngine.UI.Text RelationshipLabel;

		public global::UnityEngine.RectTransform AddictionContainer;

		public global::UnityEngine.UI.Scrollbar AddictionScrollbar;

		public global::UnityEngine.UI.Text AddictionLabel;

		public global::UnityEngine.RectTransform DebtContainer;

		public global::UnityEngine.UI.Text DebtLabel;

		public global::UnityEngine.RectTransform PropertiesContainer;

		public global::UnityEngine.UI.Text PropertiesLabel;

		public global::UnityEngine.RectTransform MostPurchasedProductsContainer;

		public global::UnityEngine.UI.Text MostPurchasedProductsLabel;

		public global::UnityEngine.RectTransform TotalSpentContainer;

		public global::UnityEngine.UI.Text TotalSpentLabel;

		public global::UnityEngine.UI.Button ShowOnMapButton;

		public global::UnityEngine.RectTransform StandardsContainer;

		public global::UnityEngine.UI.Image StandardsStar;

		public global::UnityEngine.UI.Text StandardsLabel;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _generalColorFont;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _proudctColorFont;

		private global::ScheduleOne.Map.POI poi;

		private const int MAX_PURCHASED_PRODUCTS_DISPLAYED = 3;

		public global::ScheduleOne.NPCs.NPC SelectedNPC { get; protected set; }

		public void Open(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public void ShowOnMap()
		{
		}
	}
}
