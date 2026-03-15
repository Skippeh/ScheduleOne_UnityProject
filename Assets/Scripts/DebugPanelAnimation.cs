[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Image))]
public class DebugPanelAnimation : global::UnityEngine.MonoBehaviour
{
	public enum AnimationType
	{
		Alpha = 0,
		Scale = 1
	}

	[global::UnityEngine.Header("Target Image")]
	public global::UnityEngine.UI.Image targetImage;

	[global::UnityEngine.Header("Animation Settings")]
	public DebugPanelAnimation.AnimationType animationType;

	public global::UnityEngine.AnimationCurve alphaCurve;

	public float duration;

	private float timer;

	private bool isPlaying;

	private global::UnityEngine.Color originalColor;

	private global::UnityEngine.Vector3 originalScale;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Play()
	{
	}
}
