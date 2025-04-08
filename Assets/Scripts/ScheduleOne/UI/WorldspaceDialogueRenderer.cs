namespace ScheduleOne.UI
{
	public class WorldspaceDialogueRenderer : global::UnityEngine.MonoBehaviour
	{
		private const float FadeDist = 2f;

		[global::UnityEngine.Header("Settings")]
		public float MaxRange;

		public float BaseScale;

		public global::UnityEngine.AnimationCurve Scale;

		public global::UnityEngine.Vector2 Padding;

		public global::UnityEngine.Vector3 WorldSpaceOffset;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.CanvasGroup CanvasGroup;

		public global::UnityEngine.RectTransform Background;

		public global::TMPro.TextMeshProUGUI Text;

		public global::UnityEngine.Animation Anim;

		private global::UnityEngine.Vector3 localOffset;

		private float CurrentOpacity;

		private global::UnityEngine.Coroutine hideCoroutine;

		public string ShownText { get; protected set; }

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdatePosition()
		{
		}

		public void ShowText(string text, float duration = 0f)
		{
		}

		public void HideText()
		{
		}

		private void SetOpacity(float op)
		{
		}
	}
}
