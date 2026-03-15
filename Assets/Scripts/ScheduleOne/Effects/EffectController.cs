namespace ScheduleOne.Effects
{
	public abstract class EffectController : global::FishNet.Object.NetworkBehaviour
	{
		protected float _distanceToPlayerNormalised;

		protected float _enclosureBlend;

		protected global::UnityEngine.Vector3 _playerPosition;

		protected global::UnityEngine.Vector3 _anchoredPosition;

		private bool NetworkInitialize___EarlyScheduleOne_002EEffects_002EEffectControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEffects_002EEffectControllerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsActive { get; protected set; }

		public abstract void Activate();

		public abstract void Deactivate();

		public virtual void UpdateProperties(global::UnityEngine.Vector3 anchorPosition, global::UnityEngine.Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend)
		{
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
