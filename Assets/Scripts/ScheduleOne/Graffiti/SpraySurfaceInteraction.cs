namespace ScheduleOne.Graffiti
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Graffiti.SpraySurface))]
	public class SpraySurfaceInteraction : global::UnityEngine.MonoBehaviour
	{
		private const float CameraLerpTime = 0.15f;

		private const int MaxPixelsBeforeNewStroke = 1000;

		private const int ManhattanDistanceBetweenPaintedPixels = 3;

		private const int FixedPaintedPixelLimit = 25000;

		private const int CanvasPadding = 12;

		public global::ScheduleOne.Graffiti.SpraySurface SpraySurface;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.UI.Image SprayImg;

		public global::ScheduleOne.Audio.AudioSourceController SpraySound;

		public global::ScheduleOne.Audio.AudioSourceController CleanSound;

		public bool _allowDraw;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		public float PaintedPixelLimitMultiplier;

		private global::ScheduleOne.Graffiti.ESprayColor selectedColor;

		private byte selectedStrokeSize;

		private global::ScheduleOne.Graffiti.UShort2 lastPaintedPixelCoord;

		private bool paintedLastFrame;

		private global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.UShort2> currentStrokePixels;

		private bool isPaintingStroke;

		private float timeSinceStrokeStart;

		private int _startPaintedPixelCount;

		public bool IsOpen { get; private set; }

		private bool confirmationPanelOpen => false;

		private int _paintedPixelLimit => 0;

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

		private void ResizeCanvas()
		{
		}

		private void Update()
		{
		}

		private void UpdateCursor()
		{
		}

		private void UpdateSpraySound()
		{
		}

		private void CheckCameraInBounds()
		{
		}

		private void FixedUpdate()
		{
		}

		private void StartStroke(bool recordHistory = true)
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

		private void EquippedSlotChanged(int equippedSlotIndex)
		{
		}

		private void SetColor(global::ScheduleOne.Graffiti.ESprayColor color)
		{
		}

		private void SetStrokeSize(byte strokeSize)
		{
		}

		private void UpdateRemainingPaintIndicator()
		{
		}

		public void Undo()
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
