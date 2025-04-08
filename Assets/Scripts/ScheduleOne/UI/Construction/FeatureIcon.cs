namespace ScheduleOne.UI.Construction
{
	public class FeatureIcon : global::UnityEngine.MonoBehaviour
	{
		public static global::ScheduleOne.UI.Construction.FeatureIcon selectedFeatureIcon;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform rectTransform;

		public global::UnityEngine.UI.Image icon;

		public global::TMPro.TextMeshProUGUI text;

		public global::UnityEngine.UI.Image background;

		private bool hovered;

		public global::ScheduleOne.Construction.Features.Feature feature { get; protected set; }

		public bool isSelected { get; protected set; }

		public void AssignFeature(global::ScheduleOne.Construction.Features.Feature _feature)
		{
		}

		public void UpdateTransform()
		{
		}

		public void Clicked()
		{
		}

		public void SetIsSelected(bool s)
		{
		}

		private void UpdateColors()
		{
		}

		public void PointerEnter()
		{
		}

		public void PointerExit()
		{
		}
	}
}
