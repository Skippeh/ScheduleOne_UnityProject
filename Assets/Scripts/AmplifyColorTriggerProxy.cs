using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
[AddComponentMenu("")]
public class AmplifyColorTriggerProxy : AmplifyColorTriggerProxyBase
{
	private SphereCollider sphereCollider;

	private Rigidbody rigidBody;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
