namespace ScheduleOne.UI
{
	public class CartelInfluenceChangePopup : global::UnityEngine.MonoBehaviour
	{
		public const float SLIDER_ANIMATION_DURATION = 1.5f;

		public global::UnityEngine.Animation Anim;

		public global::UnityEngine.UI.Slider Slider;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::TMPro.TextMeshProUGUI InfluenceCountLabel;

		private void Start()
		{
		}

		public void Show(global::ScheduleOne.Map.EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		private void SetDisplayedInfluence(float influence)
		{
		}
	}
}
