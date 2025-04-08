public class FlockChild : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.HideInInspector]
	public FlockController _spawner;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.Vector3 _wayPoint;

	public float _speed;

	[global::UnityEngine.HideInInspector]
	public bool _dived;

	[global::UnityEngine.HideInInspector]
	public float _stuckCounter;

	[global::UnityEngine.HideInInspector]
	public float _damping;

	[global::UnityEngine.HideInInspector]
	public bool _soar;

	[global::UnityEngine.HideInInspector]
	public bool _landing;

	[global::UnityEngine.HideInInspector]
	public float _targetSpeed;

	[global::UnityEngine.HideInInspector]
	public bool _move;

	public global::UnityEngine.GameObject _model;

	public global::UnityEngine.Transform _modelT;

	[global::UnityEngine.HideInInspector]
	public float _avoidValue;

	[global::UnityEngine.HideInInspector]
	public float _avoidDistance;

	private float _soarTimer;

	private bool _instantiated;

	private static int _updateNextSeed;

	private int _updateSeed;

	[global::UnityEngine.HideInInspector]
	public bool _avoid;

	public global::UnityEngine.Transform _thisT;

	public global::UnityEngine.Vector3 _landingPosOffset;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void OnDisable()
	{
	}

	public void OnEnable()
	{
	}

	public void FindRequiredComponents()
	{
	}

	public void RandomizeStartAnimationFrame()
	{
	}

	public void InitAvoidanceValues()
	{
	}

	public void SetRandomScale()
	{
	}

	public void SoarTimeLimit()
	{
	}

	public void CheckForDistanceToWaypoint()
	{
	}

	public void RotationBasedOnWaypointOrAvoidance()
	{
	}

	public bool Avoidance()
	{
		return false;
	}

	public void LimitRotationOfModel()
	{
	}

	public void Wander(float delay)
	{
	}

	public void SetRandomMode()
	{
	}

	public void Flap()
	{
	}

	public global::UnityEngine.Vector3 findWaypoint()
	{
		return default(global::UnityEngine.Vector3);
	}

	public void Soar()
	{
	}

	public void Dive()
	{
	}

	public void animationSpeed()
	{
	}
}
