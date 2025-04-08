namespace ScheduleOne.UI.Items
{
	public class ItemInfoContent : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public float Height;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI NameLabel;

		public global::TMPro.TextMeshProUGUI DescriptionLabel;

		public virtual void Initialize(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		public virtual void Initialize(global::ScheduleOne.ItemFramework.ItemDefinition definition)
		{
		}
	}
}
