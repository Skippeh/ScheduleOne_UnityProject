namespace Funly.SkyStudio
{
	public class BaseSpriteItemData
	{
		public enum SpriteState
		{
			Unknown = 0,
			NotStarted = 1,
			Animating = 2,
			Complete = 3
		}

		public global::Funly.SkyStudio.SpriteSheetData spriteSheetData;

		public float delay;

		public global::UnityEngine.Matrix4x4 modelMatrix { get; protected set; }

		public global::Funly.SkyStudio.BaseSpriteItemData.SpriteState state { get; protected set; }

		public global::UnityEngine.Vector3 spritePosition { get; set; }

		public float startTime { get; protected set; }

		public float endTime { get; protected set; }

		public void SetTRSMatrix(global::UnityEngine.Vector3 worldPosition, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 scale)
		{
		}

		public void Start()
		{
		}

		public void Continue()
		{
		}

		public void Reset()
		{
		}

		public static float CalculateStartTimeWithDelay(float delay)
		{
			return 0f;
		}

		public static float CalculateEndTime(float startTime, int itemCount, int animationSpeed)
		{
			return 0f;
		}
	}
}
