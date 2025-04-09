using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.UI.WorldspacePopup
{
	public class WorldspacePopup : MonoBehaviour
	{
		public static List<WorldspacePopup> ActivePopups;

		[Range(0f, 1f)]
		public float CurrentFillLevel;

		[Header("Settings")]
		public WorldspacePopupUI UIPrefab;

		public bool DisplayOnHUD;

		public bool ScaleWithDistance;

		public Vector3 WorldspaceOffset;

		public float Range;

		public float SizeMultiplier;

		[HideInInspector]
		public WorldspacePopupUI WorldspaceUI;

		[HideInInspector]
		public RectTransform HUDUI;

		[HideInInspector]
		public WorldspacePopupUI HUDUIIcon;

		[HideInInspector]
		public CanvasGroup HUDUICanvasGroup;

		private List<WorldspacePopupUI> UIs;

		private Coroutine popupCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public WorldspacePopupUI CreateUI(RectTransform parent)
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
