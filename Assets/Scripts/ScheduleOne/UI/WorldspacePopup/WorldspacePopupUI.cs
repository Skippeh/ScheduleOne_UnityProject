namespace ScheduleOne.UI.WorldspacePopup
{
	public class WorldspacePopupUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup Popup;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.UI.Image FillImage;

		public global::UnityEngine.Events.UnityEvent onDestroyed;

		public void SetFill(float fill)
		{
		}

		public void Destroy()
		{
		}
	}
}
