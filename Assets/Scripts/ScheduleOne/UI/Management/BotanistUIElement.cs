namespace ScheduleOne.UI.Management
{
	public class BotanistUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image SupplyIcon;

		public global::UnityEngine.GameObject NoSupply;

		public global::TMPro.TextMeshProUGUI SupplyLabel;

		public global::UnityEngine.RectTransform[] PotRects;

		public global::ScheduleOne.Employees.Botanist AssignedBotanist { get; protected set; }

		public void Initialize(global::ScheduleOne.Employees.Botanist bot)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
