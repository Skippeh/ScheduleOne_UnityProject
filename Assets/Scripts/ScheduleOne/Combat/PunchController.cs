namespace ScheduleOne.Combat
{
	public class PunchController : global::UnityEngine.MonoBehaviour
	{
		public const float MAX_PUNCH_LOAD = 1f;

		public const float MIN_COOLDOWN = 0.1f;

		public const float MAX_COOLDOWN = 0.2f;

		public const float PUNCH_RANGE = 1.25f;

		public const float PUNCH_DEBOUNCE = 0.1f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Vector3 ViewmodelAvatarOffset;

		public float MinPunchDamage;

		public float MaxPunchDamage;

		public float MinPunchForce;

		public float MaxPunchForce;

		[global::UnityEngine.Header("Stamina Settings")]
		public float MinStaminaCost;

		public float MaxStaminaCost;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController PunchSound;

		public global::UnityEngine.RuntimeAnimatorController PunchAnimator;

		private float punchLoad;

		private float remainingCooldown;

		private global::ScheduleOne.PlayerScripts.Player player;

		private global::UnityEngine.Coroutine punchRoutine;

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
