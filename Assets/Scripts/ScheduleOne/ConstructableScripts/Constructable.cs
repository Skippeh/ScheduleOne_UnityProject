using System.Collections.Generic;
using EPOOutline;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Construction.Features;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	public class Constructable : NetworkBehaviour
	{
		[Header("Basic settings")]
		[SerializeField]
		protected bool isStatic;

		[SerializeField]
		protected string constructableName;

		[SerializeField]
		protected string constructableDescription;

		[SerializeField]
		protected string constructableAssetPath;

		[SerializeField]
		protected string ID;

		[SerializeField]
		protected Sprite constructableIcon;

		[Header("Bounds settings")]
		public BoxCollider boundingBox;

		[Header("Construction Handler")]
		[SerializeField]
		protected GameObject constructionHandler_Asset;

		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> outlineRenderers;

		protected Outlinable outlineEffect;

		[Header("Features")]
		public List<Feature> features;

		private bool isDestroyed;

		private Dictionary<Transform, LayerMask> originalLayers;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstructableScripts_002EConstructableAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstructableScripts_002EConstructableAssembly_002DCSharp_002Edll_Excuted;

		public bool IsStatic => false;

		public string ConstructableName => null;

		public string ConstructableDescription => null;

		public string ConstructableAssetPath => null;

		public string PrefabID => null;

		public Sprite ConstructableIcon => null;

		public GameObject _constructionHandler_Asset => null;

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

		[ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
		}

		[ObserversRpc]
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

		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		public void HideOutline()
		{
		}

		public virtual Vector3 GetCosmeticCenter()
		{
			return default(Vector3);
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

		public void SetLayerRecursively(GameObject go, int layerNumber)
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

		private void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
		{
		}

		private void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
		}

		private void RpcReader___Observers_DestroyConstructableWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EConstructableScripts_002EConstructable_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
