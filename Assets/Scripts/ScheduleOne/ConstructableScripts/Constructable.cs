namespace ScheduleOne.ConstructableScripts
{
	public class Constructable : global::FishNet.Object.NetworkBehaviour
	{
		[global::UnityEngine.Header("Basic settings")]
		[global::UnityEngine.SerializeField]
		protected bool isStatic;

		[global::UnityEngine.SerializeField]
		protected string constructableName;

		[global::UnityEngine.SerializeField]
		protected string constructableDescription;

		[global::UnityEngine.SerializeField]
		protected string constructableAssetPath;

		[global::UnityEngine.SerializeField]
		protected string ID;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Sprite constructableIcon;

		[global::UnityEngine.Header("Bounds settings")]
		public global::UnityEngine.BoxCollider boundingBox;

		[global::UnityEngine.Header("Construction Handler")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject constructionHandler_Asset;

		[global::UnityEngine.Header("Outline settings")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> outlineRenderers;

		protected global::EPOOutline.Outlinable outlineEffect;

		[global::UnityEngine.Header("Features")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Construction.Features.Feature> features;

		private bool isDestroyed;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.Transform, global::UnityEngine.LayerMask> originalLayers;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstructableScripts_002EConstructableAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstructableScripts_002EConstructableAssembly_002DCSharp_002Edll_Excuted;

		public bool IsStatic => false;

		public string ConstructableName => null;

		public string ConstructableDescription => null;

		public string ConstructableAssetPath => null;

		public string PrefabID => null;

		public global::UnityEngine.Sprite ConstructableIcon => null;

		public global::UnityEngine.GameObject _constructionHandler_Asset => null;

		public bool isVisible { get; protected set; }

		public virtual void Awake()
		{
		}

		public override void OnStartClient()
		{
		}

		public virtual bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public virtual bool CanBeDestroyed()
		{
			return false;
		}

		public virtual void DestroyConstructable(bool callOnServer = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void DestroyConstructableWrapper()
		{
		}

		public virtual bool CanBeModified()
		{
			return false;
		}

		public virtual bool CanBePickedUpByHand()
		{
			return false;
		}

		public virtual bool CanBeSelected()
		{
			return false;
		}

		public virtual string GetBuildableVersionAssetPath()
		{
			return null;
		}

		public void ShowOutline(global::ScheduleOne.EntityFramework.BuildableItem.EOutlineColor color)
		{
		}

		public void HideOutline()
		{
		}

		public virtual global::UnityEngine.Vector3 GetCosmeticCenter()
		{
			return default(global::UnityEngine.Vector3);
		}

		public float GetBoundingBoxLongestSide()
		{
			return 0f;
		}

		public virtual void SetInvisible()
		{
		}

		public virtual void RestoreVisibility()
		{
		}

		public void SetLayerRecursively(global::UnityEngine.GameObject go, int layerNumber)
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

		private void RpcWriter___Server_Destroy_Networked_2166136261()
		{
		}

		private void RpcLogic___Destroy_Networked_2166136261()
		{
		}

		private void RpcReader___Server_Destroy_Networked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
		{
		}

		private void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
		}

		private void RpcReader___Observers_DestroyConstructableWrapper_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EConstructableScripts_002EConstructable_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
