namespace ScheduleOne.UI.Stations.Drying_rack
{
	public class DryingOperationUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.UI.Image Icon;

		public global::TMPro.TextMeshProUGUI QuantityLabel;

		public global::UnityEngine.UI.Button Button;

		public global::ScheduleOne.UI.Tooltips.Tooltip Tooltip;

		private float _dryMultiplier;

		public global::ScheduleOne.ObjectScripts.DryingOperation AssignedOperation { get; protected set; }

		public global::UnityEngine.RectTransform Alignment { get; private set; }

		public void SetOperation(global::ScheduleOne.ObjectScripts.DryingOperation operation)
		{
		}

		public void SetAlignment(global::UnityEngine.RectTransform alignment)
		{
		}

		public void RefreshQuantity()
		{
		}

		public void Start()
		{
		}

		public void SetDryRate(float dryMultiplier)
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
