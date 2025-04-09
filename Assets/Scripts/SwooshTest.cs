using UnityEngine;

public class SwooshTest : MonoBehaviour
{
	[SerializeField]
	private AnimationClip _animation;

	private AnimationState _animationState;

	[SerializeField]
	private int _start;

	[SerializeField]
	private int _end;

	private float _startN;

	private float _endN;

	private float _time;

	private float _prevTime;

	private float _prevAnimTime;

	[SerializeField]
	private MeleeWeaponTrail _trail;

	private bool _firstFrame;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
