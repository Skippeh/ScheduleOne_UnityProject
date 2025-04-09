using UnityEngine;

public class FlockChild : MonoBehaviour
{
	[HideInInspector]
	public FlockController _spawner;

	[HideInInspector]
	public Vector3 _wayPoint;

	public float _speed;

	[HideInInspector]
	public bool _dived;

	[HideInInspector]
	public float _stuckCounter;

	[HideInInspector]
	public float _damping;

	[HideInInspector]
	public bool _soar;

	[HideInInspector]
	public bool _landing;

	[HideInInspector]
	public float _targetSpeed;

	[HideInInspector]
	public bool _move;

	public GameObject _model;

	public Transform _modelT;

	[HideInInspector]
	public float _avoidValue;

	[HideInInspector]
	public float _avoidDistance;

	private float _soarTimer;

	private bool _instantiated;

	private static int _updateNextSeed;

	private int _updateSeed;

	[HideInInspector]
	public bool _avoid;

	public Transform _thisT;

	public Vector3 _landingPosOffset;

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

	public Vector3 findWaypoint()
	{
		return default(Vector3);
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
