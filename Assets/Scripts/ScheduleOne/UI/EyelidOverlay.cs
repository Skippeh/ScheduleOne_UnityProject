using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		public const float MaxTiredOpenAmount = 0.625f;

		public bool AutoUpdate;

		[Header("Settings")]
		public float Open;

		public float Closed;

		[Header("References")]
		public RectTransform Upper;

		public RectTransform Lower;

		public Canvas Canvas;

		[Range(0f, 1f)]
		public float CurrentOpen;

		public FloatSmoother OpenMultiplier;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetOpen(float openness)
		{
		}
	}
}
