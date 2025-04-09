using ScheduleOne.Construction.Features;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction
{
	public class FeatureIcon : MonoBehaviour
	{
		public static FeatureIcon selectedFeatureIcon;

		[Header("References")]
		public RectTransform rectTransform;

		public Image icon;

		public TextMeshProUGUI text;

		public Image background;

		private bool hovered;

		public Feature feature { get; protected set; }

		public bool isSelected { get; protected set; }

		public void AssignFeature(Feature _feature)
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
