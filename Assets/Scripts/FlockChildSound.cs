[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.AudioSource))]
public class FlockChildSound : global::UnityEngine.MonoBehaviour
{
	public global::ScheduleOne.Audio.AudioSourceController controller;

	public global::UnityEngine.AudioClip[] _idleSounds;

	public float _idleSoundRandomChance;

	public global::UnityEngine.AudioClip[] _flightSounds;

	public float _flightSoundRandomChance;

	public global::UnityEngine.AudioClip[] _scareSounds;

	public float _pitchMin;

	public float _pitchMax;

	public float _volumeMin;

	public float _volumeMax;

	private FlockChild _flockChild;

	private global::UnityEngine.AudioSource _audio;

	private bool _hasLanded;

	public void Start()
	{
	}

	public void PlayRandomSound()
	{
	}

	public void ScareSound()
	{
	}
}
