using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.NPCs;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Stealth
{
	public class PlayerVisibility : NetworkBehaviour
	{
		public const float MAX_VISIBLITY = 100f;

		public float CurrentVisibility;

		public List<VisibilityAttribute> activeAttributes;

		public List<VisibilityAttribute> filteredAttributes;

		[Header("Settings")]
		public LayerMask visibilityCheckMask;

		[Header("References")]
		public List<Transform> visibilityPoints;

		private VisibilityAttribute environmentalVisibility;

		private List<RaycastHit> hits;

		private bool NetworkInitialize___EarlyScheduleOne_002EStealth_002EPlayerVisibilityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStealth_002EPlayerVisibilityAssembly_002DCSharp_002Edll_Excuted;

		public VisionEvent HighestVisionEvent { get; set; }

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

		public VisibilityAttribute GetAttribute(string name)
		{
			return null;
		}

		private void UpdateEnvironmentalVisibilityAttribute()
		{
		}

		public float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)
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
