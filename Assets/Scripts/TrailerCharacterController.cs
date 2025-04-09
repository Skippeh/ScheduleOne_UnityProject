using EasyButtons;
using UnityEngine;

public class TrailerCharacterController : MonoBehaviour
{
	public Transform StartPos;

	public Transform EndPos;

	public Transform Character;

	public float WalkSpeed;

	private Coroutine routine;

	private void Awake()
	{
	}

	[Button]
	public void Play()
	{
	}

	[Button]
	public void Stop()
	{
	}
}
