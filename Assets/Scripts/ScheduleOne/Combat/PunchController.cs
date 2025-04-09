using ScheduleOne.Audio;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	public class PunchController : MonoBehaviour
	{
		public const float MAX_PUNCH_LOAD = 1f;

		public const float MIN_COOLDOWN = 0.1f;

		public const float MAX_COOLDOWN = 0.2f;

		public const float PUNCH_RANGE = 1.25f;

		public const float PUNCH_DEBOUNCE = 0.1f;

		[Header("Settings")]
		public Vector3 ViewmodelAvatarOffset;

		public float MinPunchDamage;

		public float MaxPunchDamage;

		public float MinPunchForce;

		public float MaxPunchForce;

		[Header("Stamina Settings")]
		public float MinStaminaCost;

		public float MaxStaminaCost;

		[Header("References")]
		public AudioSourceController PunchSound;

		public RuntimeAnimatorController PunchAnimator;

		private float punchLoad;

		private float remainingCooldown;

		private Player player;

		private Coroutine punchRoutine;

		private bool itemEquippedLastFrame;

		private float timeSincePunchingEnabled;

		public bool PunchingEnabled { get; set; }

		public bool IsLoading => false;

		public bool IsPunching { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateCooldown()
		{
		}

		private void UpdateInput()
		{
		}

		private bool CanStartLoading()
		{
			return false;
		}

		private void StartLoad()
		{
		}

		private void Release()
		{
		}

		private void Punch(float power)
		{
		}

		private void ExecuteHit(float power)
		{
		}

		private void SetPunchingEnabled(bool enabled)
		{
		}

		private bool ShouldBeEnabled()
		{
			return false;
		}
	}
}
