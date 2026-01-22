public class DevTesting : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Header("Components")]
	public global::UnityEngine.Transform locationA;

	public global::UnityEngine.Transform locationB;

	private global::UnityEngine.Vector3 pointA;

	private global::UnityEngine.Vector3 pointB;

	private global::UnityEngine.Vector3 _dir;

	[global::EasyButtons.Button]
	public void CheckDirection()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
