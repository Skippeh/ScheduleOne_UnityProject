namespace ScheduleOne.Stealth
{
	public class PlayerVisibility : global::FishNet.Object.NetworkBehaviour
	{
		public const float MAX_VISIBLITY = 100f;

		public float CurrentVisibility;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vision.VisibilityAttribute> activeAttributes;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vision.VisibilityAttribute> filteredAttributes;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask visibilityCheckMask;

		[global::UnityEngine.Header("References")]
		public global::System.Collections.Generic.List<global::UnityEngine.Transform> visibilityPoints;

		private global::ScheduleOne.Vision.VisibilityAttribute environmentalVisibility;

		private global::System.Collections.Generic.List<global::UnityEngine.RaycastHit> hits;

		private bool NetworkInitialize___EarlyScheduleOne_002EStealth_002EPlayerVisibilityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStealth_002EPlayerVisibilityAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Vision.VisionEvent HighestVisionEvent { get; set; }

		public override void OnStartClient()
		{
		}

		private void FixedUpdate()
		{
		}

		private float CalculateVisibility()
		{
			return 0f;
		}

		public global::ScheduleOne.Vision.VisibilityAttribute GetAttribute(string name)
		{
			return null;
		}

		private void UpdateEnvironmentalVisibilityAttribute()
		{
		}

		public float CalculateExposureToPoint(global::UnityEngine.Vector3 point, float checkRange = 50f, global::ScheduleOne.NPCs.NPC checkingNPC = null)
		{
			return 0f;
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public virtual void Awake()
		{
		}
	}
}
