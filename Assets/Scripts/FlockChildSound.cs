using ScheduleOne.Audio;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	public AudioSourceController controller;

	public AudioClip[] _idleSounds;

	public float _idleSoundRandomChance;

	public AudioClip[] _flightSounds;

	public float _flightSoundRandomChance;

	public AudioClip[] _scareSounds;

	public float _pitchMin;

	public float _pitchMax;

	public float _volumeMin;

	public float _volumeMax;

	private FlockChild _flockChild;

	private AudioSource _audio;

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
