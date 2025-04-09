using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
[AddComponentMenu("")]
public class AmplifyColorTriggerProxy2D : AmplifyColorTriggerProxyBase
{
	private CircleCollider2D circleCollider;

	private Rigidbody2D rigidBody;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
