namespace ScheduleOne.Graffiti
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Graffiti.SpraySurface))]
	public class SpraySurfaceInteraction : global::UnityEngine.MonoBehaviour
	{
		public const float CAMERA_MOVE_TIME = 0.15f;

		public const int MAX_PIXELS_BEFORE_NEW_STROKE = 1000;

		public const int MANHATTAN_DISTANCE_BETWEEN_PAINTED_PIXELS = 3;

		public const int XP_GAIN = 50;

		public const float CARTEL_INFLUENCE_CHANGE = -0.05f;

		public const int PAINTED_PIXEL_LIMIT = 25000;

		public global::ScheduleOne.Graffiti.SpraySurface SpraySurface;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.UI.Image SprayImg;

		public global::ScheduleOne.Audio.AudioSourceController SpraySound;

		public global::ScheduleOne.Audio.AudioSourceController CleanSound;

		private global::ScheduleOne.Graffiti.ESprayColor selectedColor;

		private global::ScheduleOne.Graffiti.UShort2 lastPaintedPixelCoord;

		private bool paintedLastFrame;

		private global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.UShort2> currentStrokePixels;

		private bool isPaintingStroke;

		private float timeSinceStrokeStart;

		public bool IsOpen { get; private set; }

		private bool confirmationPanelOpen => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void PlayerSpawned()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		private void ResizeCanvas()
		{
		}

		private void Update()
		{
		}

		private void UpdateCursor()
		{
		}

		private void FixedUpdate()
		{
		}

		private void StartStroke()
		{
		}

		private void EndStroke(bool stopSpraySound)
		{
		}

		private bool GetCursorPositionOnSurface(out ushort pixelX, out ushort pixelY)
		{
			pixelX = default(ushort);
			pixelY = default(ushort);
			return false;
		}

		private global::UnityEngine.Ray GetCursorRay()
		{
			return default(global::UnityEngine.Ray);
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}

		private void UseGraffitiCleaner()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void Open()
		{
		}

		private void Close()
		{
		}

		private void Reward()
		{
		}

		private void EquippedSlotChanged(int equippedSlotIndex)
		{
		}

		private void SetColor(global::ScheduleOne.Graffiti.ESprayColor color)
		{
		}

		private void Clear()
		{
		}

		private static bool IsSprayCanEquipped()
		{
			return false;
		}

		private static bool IsGraffitiCleanerEquipped()
		{
			return false;
		}
	}
}
