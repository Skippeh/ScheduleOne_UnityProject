namespace ScheduleOne.UI.WorldspacePopup
{
	public class WorldspacePopup : global::UnityEngine.MonoBehaviour
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup> ActivePopups;

		[global::UnityEngine.Range(0f, 1f)]
		public float CurrentFillLevel;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI UIPrefab;

		public bool DisplayOnHUD;

		public bool ScaleWithDistance;

		public global::UnityEngine.Vector3 WorldspaceOffset;

		public float Range;

		public float SizeMultiplier;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI WorldspaceUI;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.RectTransform HUDUI;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI HUDUIIcon;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.CanvasGroup HUDUICanvasGroup;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI> UIs;

		private global::UnityEngine.Coroutine popupCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI CreateUI(global::UnityEngine.RectTransform parent)
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public void Popup()
		{
		}
	}
}
