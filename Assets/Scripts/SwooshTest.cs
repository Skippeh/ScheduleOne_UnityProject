public class SwooshTest : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.AnimationClip _animation;

	private global::UnityEngine.AnimationState _animationState;

	[global::UnityEngine.SerializeField]
	private int _start;

	[global::UnityEngine.SerializeField]
	private int _end;

	private float _startN;

	private float _endN;

	private float _time;

	private float _prevTime;

	private float _prevAnimTime;

	[global::UnityEngine.SerializeField]
	private MeleeWeaponTrail _trail;

	private bool _firstFrame;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
