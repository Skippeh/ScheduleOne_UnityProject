using System.Collections.Generic;
using UnityEngine;

public class FlockController : MonoBehaviour
{
	public FlockChild _childPrefab;

	public int _childAmount;

	public bool _slowSpawn;

	public float _spawnSphere;

	public float _spawnSphereHeight;

	public float _spawnSphereDepth;

	public float _minSpeed;

	public float _maxSpeed;

	public float _minScale;

	public float _maxScale;

	public float _soarFrequency;

	public string _soarAnimation;

	public string _flapAnimation;

	public string _idleAnimation;

	public float _diveValue;

	public float _diveFrequency;

	public float _minDamping;

	public float _maxDamping;

	public float _waypointDistance;

	public float _minAnimationSpeed;

	public float _maxAnimationSpeed;

	public float _randomPositionTimer;

	public float _positionSphere;

	public float _positionSphereHeight;

	public float _positionSphereDepth;

	public bool _childTriggerPos;

	public bool _forceChildWaypoints;

	public float _forcedRandomDelay;

	public bool _flatFly;

	public bool _flatSoar;

	public bool _birdAvoid;

	public int _birdAvoidHorizontalForce;

	public bool _birdAvoidDown;

	public bool _birdAvoidUp;

	public int _birdAvoidVerticalForce;

	public float _birdAvoidDistanceMax;

	public float _birdAvoidDistanceMin;

	public float _soarMaxTime;

	public LayerMask _avoidanceMask;

	public List<FlockChild> _roamers;

	public Vector3 _posBuffer;

	public int _updateDivisor;

	public float _newDelta;

	public int _updateCounter;

	public float _activeChildren;

	public bool _groupChildToNewTransform;

	public Transform _groupTransform;

	public string _groupName;

	public bool _groupChildToFlock;

	public Vector3 _startPosOffset;

	public Transform _thisT;

	public void Start()
	{
	}

	public void AddChild(int amount)
	{
	}

	public void AddChildToParent(Transform obj)
	{
	}

	public void RemoveChild(int amount)
	{
	}

	public void Update()
	{
	}

	public void InstantiateGroup()
	{
	}

	public void UpdateChildAmount()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void SetFlockRandomPosition()
	{
	}

	public void destroyBirds()
	{
	}
}
