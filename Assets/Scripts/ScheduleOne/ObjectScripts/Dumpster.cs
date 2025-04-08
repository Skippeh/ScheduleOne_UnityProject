namespace ScheduleOne.ObjectScripts
{
	public class Dumpster : global::ScheduleOne.EntityFramework.GridItem
	{
		public static float capacity;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject lid_IntObj;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject inner_IntObj;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform lid;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform trash;

		public global::UnityEngine.Transform standPoint;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected float trash_MinY;

		[global::UnityEngine.SerializeField]
		protected float trash_MaxY;

		private float lid_CurrentAngle;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EDumpsterAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EDumpsterAssembly_002DCSharp_002Edll_Excuted;

		public bool lidOpen { get; protected set; }

		public float currentTrashLevel { get; protected set; }

		public bool isFull => false;

		protected virtual void Update()
		{
		}

		public virtual void Lid_Hovered()
		{
		}

		public virtual void Lid_Interacted()
		{
		}

		protected bool DoesPlayerHaveBinEquipped()
		{
			return false;
		}

		public void ChangeTrashLevel(float change)
		{
		}

		public void SetTrashLevel(float trashLevel)
		{
		}

		private void UpdateTrashVisuals()
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
