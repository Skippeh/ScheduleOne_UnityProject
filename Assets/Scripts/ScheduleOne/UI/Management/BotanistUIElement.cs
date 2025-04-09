using ScheduleOne.Employees;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class BotanistUIElement : WorldspaceUIElement
	{
		[Header("References")]
		public Image SupplyIcon;

		public GameObject NoSupply;

		public TextMeshProUGUI SupplyLabel;

		public RectTransform[] PotRects;

		public Botanist AssignedBotanist { get; protected set; }

		public void Initialize(Botanist bot)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
