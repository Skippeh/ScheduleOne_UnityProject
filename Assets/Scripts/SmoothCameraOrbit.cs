[global::UnityEngine.AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : global::UnityEngine.MonoBehaviour
{
	public global::UnityEngine.Transform target;

	public global::UnityEngine.Vector3 targetOffset;

	public float distance;

	public float maxDistance;

	public float minDistance;

	public float xSpeed;

	public float ySpeed;

	public int yMinLimit;

	public int yMaxLimit;

	public int zoomRate;

	public float panSpeed;

	public float zoomDampening;

	public float autoRotate;

	public float autoRotateSpeed;

	private float xDeg;

	private float yDeg;

	private float currentDistance;

	private float desiredDistance;

	private global::UnityEngine.Quaternion currentRotation;

	private global::UnityEngine.Quaternion desiredRotation;

	private global::UnityEngine.Quaternion rotation;

	private global::UnityEngine.Vector3 position;

	private float idleTimer;

	private float idleSmooth;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void Init()
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
