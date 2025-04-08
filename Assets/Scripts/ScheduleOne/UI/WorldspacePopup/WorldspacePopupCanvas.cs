namespace ScheduleOne.UI.WorldspacePopup
{
	public class WorldspacePopupCanvas : global::UnityEngine.MonoBehaviour
	{
		public const float WORLDSPACE_ICON_SCALE_MULTIPLIER = 0.4f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform WorldspaceContainer;

		public global::UnityEngine.RectTransform HudContainer;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject HudIconContainerPrefab;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI> activeWorldspaceUIs;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> activeHUDUIs;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup> popupsWithUI;

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private bool ShouldCreateUI(global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup popup)
		{
			return false;
		}

		private global::ScheduleOne.UI.WorldspacePopup.WorldspacePopupUI CreateWorldspaceIcon(global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup popup)
		{
			return null;
		}

		private global::UnityEngine.RectTransform CreateHUDIcon(global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup popup)
		{
			return null;
		}

		private void DestroyWorldspaceIcon(global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup popup)
		{
		}

		private void DestroyHUDIcon(global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup popup)
		{
		}
	}
}
