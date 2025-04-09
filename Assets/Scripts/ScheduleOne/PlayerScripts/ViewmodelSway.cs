using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		[Header("Settings - Breathing")]
		public bool breatheBobbingEnabled;

		[Range(0f, 0.0004f)]
		[SerializeField]
		protected float breathingHeightMultiplier;

		[Range(0f, 10f)]
		[SerializeField]
		protected float breathingSpeedMultiplier;

		private float lastHeight;

		private Vector3 breatheBobPos;

		[Header("Settings - Sway - Movement")]
		public bool swayingEnabled;

		[Range(0f, 0.1f)]
		[SerializeField]
		protected float horizontalSwayMultiplier;

		[Range(0f, 0.1f)]
		[SerializeField]
		protected float verticalSwayMultiplier;

		[Range(0f, 0.5f)]
		[SerializeField]
		protected float maxHorizontal;

		[Range(0f, 0.5f)]
		[SerializeField]
		protected float maxVertical;

		[SerializeField]
		protected float swaySmooth;

		[SerializeField]
		protected float returnMultiplier;

		private Vector3 initialPos;

		private Vector3 swayPos;

		[Header("Settings - Walk Bob")]
		public bool walkBobbingEnabled;

		[SerializeField]
		protected AnimationCurve verticalMovement;

		[SerializeField]
		protected AnimationCurve horizontalMovement;

		[Range(0f, 0.1f)]
		[SerializeField]
		protected float verticalBobHeight;

		[Range(0f, 5f)]
		[SerializeField]
		protected float verticalBobSpeed;

		[Range(0f, 0.1f)]
		[SerializeField]
		protected float horizontalBobWidth;

		[Range(0f, 5f)]
		[SerializeField]
		protected float horizontalBobSpeed;

		[SerializeField]
		protected float walkBobSmooth;

		[SerializeField]
		protected float sprintSpeedMultiplier;

		[HideInInspector]
		public float walkBobMultiplier;

		private Vector3 walkBobPos;

		private float timeSinceWalkStart_vert;

		private float timeSinceWalkStart_horiz;

		[Header("Settings - Jump Jolt")]
		public bool jumpJoltEnabled;

		[SerializeField]
		protected AnimationCurve jumpCurve;

		[SerializeField]
		protected float jumpJoltTime;

		[SerializeField]
		protected float jumpJoltHeight;

		[SerializeField]
		protected float jumpJoltSmooth;

		[Header("Settings - Equip Bop")]
		[SerializeField]
		protected float equipBopVerticalOffset;

		[SerializeField]
		protected float equipBopTime;

		private Vector3 equipBopPos;

		private float timeSinceJumpStart;

		private Vector3 jumpPos;

		[Header("Settings - Falling")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float fallOffsetRate;

		[Range(0f, 2f)]
		[SerializeField]
		protected float maxFallOffsetAmount;

		private Vector3 fallOffsetPos;

		[Header("Settings - Land Jolt")]
		[SerializeField]
		protected AnimationCurve landCurve;

		[SerializeField]
		protected float landJoltTime;

		[SerializeField]
		protected float landJoltSmooth;

		private Vector3 landPos;

		private float timeSinceLanded;

		private float landJoltMultiplier;

		protected float calculatedJumpJoltHeight => 0f;

		protected override void Start()
		{
		}

		protected override void Awake()
		{
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected void Update()
		{
		}

		private void InventoryStateChanged(bool active)
		{
		}

		public void RefreshViewmodel()
		{
		}

		protected void BreatheBob()
		{
		}

		protected void Sway()
		{
		}

		protected void WalkBob()
		{
		}

		protected void StartJump()
		{
		}

		protected void UpdateJump()
		{
		}

		protected void Land()
		{
		}
	}
}
