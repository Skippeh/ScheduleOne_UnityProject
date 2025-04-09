using System;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponTrail : MonoBehaviour
{
	[Serializable]
	public class Point
	{
		public float timeCreated;

		public Vector3 basePosition;

		public Vector3 tipPosition;
	}

	[SerializeField]
	private bool _emit;

	private bool _use;

	[SerializeField]
	private float _emitTime;

	[SerializeField]
	private Material _material;

	[SerializeField]
	private float _lifeTime;

	[SerializeField]
	private Color[] _colors;

	[SerializeField]
	private float[] _sizes;

	[SerializeField]
	private float _minVertexDistance;

	[SerializeField]
	private float _maxVertexDistance;

	private float _minVertexDistanceSqr;

	private float _maxVertexDistanceSqr;

	[SerializeField]
	private float _maxAngle;

	[SerializeField]
	private bool _autoDestruct;

	[SerializeField]
	private int subdivisions;

	[SerializeField]
	private Transform _base;

	[SerializeField]
	private Transform _tip;

	private List<Point> _points;

	private List<Point> _smoothedPoints;

	private GameObject _trailObject;

	private Mesh _trailMesh;

	private Vector3 _lastPosition;

	public bool Emit
	{
		set
		{
		}
	}

	public bool Use
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void RemoveOldPoints(List<Point> pointList)
	{
	}
}
