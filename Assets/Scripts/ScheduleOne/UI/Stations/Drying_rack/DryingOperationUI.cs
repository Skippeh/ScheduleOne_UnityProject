using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Tooltips;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations.Drying_rack
{
	public class DryingOperationUI : MonoBehaviour
	{
		[Header("References")]
		public RectTransform Rect;

		public Image Icon;

		public TextMeshProUGUI QuantityLabel;

		public Button Button;

		public Tooltip Tooltip;

		public DryingOperation AssignedOperation { get; protected set; }

		public RectTransform Alignment { get; private set; }

		public void SetOperation(DryingOperation operation)
		{
		}

		public void SetAlignment(RectTransform alignment)
		{
		}

		public void RefreshQuantity()
		{
		}

		public void Start()
		{
		}

		public void UpdatePosition()
		{
		}

		private void Clicked()
		{
		}
	}
}
