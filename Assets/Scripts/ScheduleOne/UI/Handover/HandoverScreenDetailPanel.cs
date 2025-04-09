using ScheduleOne.Economy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		public LayoutGroup LayoutGroup;

		public RectTransform Container;

		public TextMeshProUGUI NameLabel;

		public RectTransform RelationshipContainer;

		public Scrollbar RelationshipScrollbar;

		public RectTransform AddictionContainer;

		public Scrollbar AdditionScrollbar;

		public Image StandardsStar;

		public TextMeshProUGUI StandardsLabel;

		public TextMeshProUGUI EffectsLabel;

		public void Open(Customer customer)
		{
		}

		public void Close()
		{
		}
	}
}
