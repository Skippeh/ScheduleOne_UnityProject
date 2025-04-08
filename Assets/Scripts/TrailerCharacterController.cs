public class TrailerCharacterController : global::UnityEngine.MonoBehaviour
{
	public global::UnityEngine.Transform StartPos;

	public global::UnityEngine.Transform EndPos;

	public global::UnityEngine.Transform Character;

	public float WalkSpeed;

	private global::UnityEngine.Coroutine routine;

	private void Awake()
	{
	}

	[global::EasyButtons.Button]
	public void Play()
	{
	}

	[global::EasyButtons.Button]
	public void Stop()
	{
	}
}
