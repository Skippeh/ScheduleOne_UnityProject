using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class BunsenBurner : MonoBehaviour
	{
		public bool LockDial;

		[Header("Settings")]
		public Gradient FlameColor;

		public AnimationCurve LightIntensity;

		public float HandleRotationSpeed;

		public AnimationCurve FlamePitch;

		[Header("References")]
		public ParticleSystem Flame;

		public Light Light;

		public Transform Handle;

		public Clickable HandleClickable;

		public Transform Handle_Min;

		public Transform Handle_Max;

		public Transform Highlight;

		public Animation Anim;

		public AudioSourceController FlameSound;

		public bool Interactable { get; private set; }

		public bool IsDialHeld { get; private set; }

		public float CurrentDialValue { get; private set; }

		public float CurrentHeat { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateEffects()
		{
		}

		public void SetDialPosition(float pos)
		{
		}

		public void SetInteractable(bool e)
		{
		}

		public void ClickStart(RaycastHit hit)
		{
		}

		public void ClickEnd()
		{
		}
	}
}
