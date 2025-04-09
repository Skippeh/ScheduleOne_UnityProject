using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IKControl : MonoBehaviour
{
	protected Animator animator;

	public bool ikActive;

	public Transform rightHandObj;

	public Transform lookObj;

	private void Start()
	{
	}

	private void OnAnimatorIK()
	{
	}
}
