namespace ScheduleOne.UI.Management
{
	public class ManagementWorldspaceCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Management.ManagementWorldspaceCanvas>
	{
		public const float VISIBILITY_RANGE = 5f;

		public const float PROPERTY_CANVAS_RANGE = 50f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.AnimationCurve ScaleCurve;

		public global::ScheduleOne.Management.TransitLineVisuals TransitRouteVisualsPrefab;

		public global::ScheduleOne.UI.Input.InputPrompt CrosshairPrompt;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask ObjectSelectionLayerMask;

		public global::UnityEngine.Color HoveredOutlineColor;

		public global::UnityEngine.Color SelectedOutlineColor;

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> ShownConfigurables;

		public global::ScheduleOne.Management.IConfigurable HoveredConfigurable;

		private global::ScheduleOne.Management.IConfigurable OutlinedConfigurable;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> SelectedConfigurables;

		public bool IsOpen { get; protected set; }

		public global::ScheduleOne.Property.Property CurrentProperty => null;

		public void Open()
		{
		}

		public void Close(bool preserveSelection = false)
		{
		}

		private void Update()
		{
		}

		private void UpdateInputPrompt()
		{
		}

		private void UpdateUIs()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateSelection()
		{
		}

		private void AddToSelection(global::ScheduleOne.Management.IConfigurable config)
		{
		}

		private void RemoveFromSelection(global::ScheduleOne.Management.IConfigurable config)
		{
		}

		private void ClearSelection()
		{
		}

		private void RemoveNullConfigurables()
		{
		}

		private global::ScheduleOne.Management.IConfigurable GetHoveredConfigurable()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> GetConfigurablesToShow()
		{
			return null;
		}

		public void ShowCrosshairPrompt(string message)
		{
		}

		public void HideCrosshairPrompt()
		{
		}
	}
}
