namespace ScheduleOne.PlayerScripts
{
	public class ViewmodelSway : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.PlayerScripts.ViewmodelSway>
	{
		public bool DEBUG;

		[global::UnityEngine.Header("Settings - Breathing")]
		public bool breatheBobbingEnabled;

		[global::UnityEngine.Range(0f, 0.0004f)]
		[global::UnityEngine.SerializeField]
		protected float breathingHeightMultiplier;

		[global::UnityEngine.Range(0f, 10f)]
		[global::UnityEngine.SerializeField]
		protected float breathingSpeedMultiplier;

		private float lastHeight;

		private global::UnityEngine.Vector3 breatheBobPos;

		[global::UnityEngine.Header("Settings - Sway - Movement")]
		public bool swayingEnabled;

		[global::UnityEngine.Range(0f, 0.1f)]
		[global::UnityEngine.SerializeField]
		protected float horizontalSwayMultiplier;

		[global::UnityEngine.Range(0f, 0.1f)]
		[global::UnityEngine.SerializeField]
		protected float verticalSwayMultiplier;

		[global::UnityEngine.Range(0f, 0.5f)]
		[global::UnityEngine.SerializeField]
		protected float maxHorizontal;

		[global::UnityEngine.Range(0f, 0.5f)]
		[global::UnityEngine.SerializeField]
		protected float maxVertical;

		[global::UnityEngine.SerializeField]
		protected float swaySmooth;

		[global::UnityEngine.SerializeField]
		protected float returnMultiplier;

		private global::UnityEngine.Vector3 initialPos;

		private global::UnityEngine.Vector3 swayPos;

		[global::UnityEngine.Header("Settings - Walk Bob")]
		public bool walkBobbingEnabled;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve verticalMovement;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve horizontalMovement;

		[global::UnityEngine.Range(0f, 0.1f)]
		[global::UnityEngine.SerializeField]
		protected float verticalBobHeight;

		[global::UnityEngine.Range(0f, 5f)]
		[global::UnityEngine.SerializeField]
		protected float verticalBobSpeed;

		[global::UnityEngine.Range(0f, 0.1f)]
		[global::UnityEngine.SerializeField]
		protected float horizontalBobWidth;

		[global::UnityEngine.Range(0f, 5f)]
		[global::UnityEngine.SerializeField]
		protected float horizontalBobSpeed;

		[global::UnityEngine.SerializeField]
		protected float walkBobSmooth;

		[global::UnityEngine.SerializeField]
		protected float sprintSpeedMultiplier;

		[global::UnityEngine.HideInInspector]
		public float walkBobMultiplier;

		private global::UnityEngine.Vector3 walkBobPos;

		private float timeSinceWalkStart_vert;

		private float timeSinceWalkStart_horiz;

		[global::UnityEngine.Header("Settings - Jump Jolt")]
		public bool jumpJoltEnabled;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve jumpCurve;

		[global::UnityEngine.SerializeField]
		protected float jumpJoltTime;

		[global::UnityEngine.SerializeField]
		protected float jumpJoltHeight;

		[global::UnityEngine.SerializeField]
		protected float jumpJoltSmooth;

		[global::UnityEngine.Header("Settings - Equip Bop")]
		[global::UnityEngine.SerializeField]
		protected float equipBopVerticalOffset;

		[global::UnityEngine.SerializeField]
		protected float equipBopTime;

		private global::UnityEngine.Vector3 equipBopPos;

		private float timeSinceJumpStart;

		private global::UnityEngine.Vector3 jumpPos;

		[global::UnityEngine.Header("Settings - Falling")]
		[global::UnityEngine.Range(0f, 1f)]
		[global::UnityEngine.SerializeField]
		protected float fallOffsetRate;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float maxFallOffsetAmount;

		private global::UnityEngine.Vector3 fallOffsetPos;

		[global::UnityEngine.Header("Settings - Land Jolt")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve landCurve;

		[global::UnityEngine.SerializeField]
		protected float landJoltTime;

		[global::UnityEngine.SerializeField]
		protected float landJoltSmooth;

		private global::UnityEngine.Vector3 landPos;

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

		private void OnEquippedSlotChanged(int slotIndex)
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
