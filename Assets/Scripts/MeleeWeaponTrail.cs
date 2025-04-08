public class MeleeWeaponTrail : global::UnityEngine.MonoBehaviour
{
	[global::System.Serializable]
	public class Point
	{
		public float timeCreated;

		public global::UnityEngine.Vector3 basePosition;

		public global::UnityEngine.Vector3 tipPosition;
	}

	[global::UnityEngine.SerializeField]
	private bool _emit;

	private bool _use;

	[global::UnityEngine.SerializeField]
	private float _emitTime;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _material;

	[global::UnityEngine.SerializeField]
	private float _lifeTime;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Color[] _colors;

	[global::UnityEngine.SerializeField]
	private float[] _sizes;

	[global::UnityEngine.SerializeField]
	private float _minVertexDistance;

	[global::UnityEngine.SerializeField]
	private float _maxVertexDistance;

	private float _minVertexDistanceSqr;

	private float _maxVertexDistanceSqr;

	[global::UnityEngine.SerializeField]
	private float _maxAngle;

	[global::UnityEngine.SerializeField]
	private bool _autoDestruct;

	[global::UnityEngine.SerializeField]
	private int subdivisions;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Transform _base;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Transform _tip;

	private global::System.Collections.Generic.List<MeleeWeaponTrail.Point> _points;

	private global::System.Collections.Generic.List<MeleeWeaponTrail.Point> _smoothedPoints;

	private global::UnityEngine.GameObject _trailObject;

	private global::UnityEngine.Mesh _trailMesh;

	private global::UnityEngine.Vector3 _lastPosition;

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

	private void RemoveOldPoints(global::System.Collections.Generic.List<MeleeWeaponTrail.Point> pointList)
	{
	}
}
