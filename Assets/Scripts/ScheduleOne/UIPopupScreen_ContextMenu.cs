namespace ScheduleOne
{
	public class UIPopupScreen_ContextMenu : global::ScheduleOne.UIPopupScreen
	{
		public class ContextMenuOption
		{
			public int optionID;

			public string optionName;

			public global::System.Action optionAction;

			public ContextMenuOption(int id, string name, global::System.Action action)
			{
			}
		}

		public enum AnchorType
		{
			TopLeft = 0,
			BottomLeft = 1,
			Center = 2
		}

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Prefab for the Option Selectable")]
		private global::ScheduleOne.UISelectable selectablePrefab;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Transform where the Option Selectables will be parented to")]
		private global::UnityEngine.Transform contentParent;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("RectTransform where the anchoring point of the context menu will be")]
		private global::UnityEngine.RectTransform anchorRectTransform;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Canvas to control the visibility")]
		private global::UnityEngine.Canvas canvas;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Screen blocker to block mouse interaction with ui elements behind the context menu and darken the background")]
		private global::UnityEngine.GameObject screenBlocker;

		private global::ScheduleOne.UIPopupScreen_ContextMenu.AnchorType anchor;

		private global::System.Collections.Generic.List<global::ScheduleOne.UIPopupScreen_ContextMenu.ContextMenuOption> options;

		private global::System.Collections.Generic.Queue<global::ScheduleOne.UISelectable> selectablePool;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.UISelectable> activeSelectables;

		public global::ScheduleOne.UIPopupScreen_ContextMenu.AnchorType Anchor
		{
			get
			{
				return default(global::ScheduleOne.UIPopupScreen_ContextMenu.AnchorType);
			}
			set
			{
			}
		}

		protected override void OnAwake()
		{
		}

		protected override void OnStarted()
		{
		}

		protected override void OnDestroyed()
		{
		}

		private void HandleInputDeviceChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}

		public void AddOption(int id, string name, global::System.Action action)
		{
		}

		public override void Close()
		{
		}

		private void Open()
		{
		}

		public override void Open(params object[] args)
		{
		}

		private void Clear()
		{
		}

		private void SelectPanel(int selectedIndex)
		{
		}

		private global::ScheduleOne.UISelectable GetSelectableFromPool()
		{
			return null;
		}

		private void SetPosition(global::UnityEngine.Vector2 pos)
		{
		}
	}
}
