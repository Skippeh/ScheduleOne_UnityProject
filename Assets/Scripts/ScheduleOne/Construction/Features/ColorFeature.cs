using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	public class ColorFeature : Feature
	{
		[Serializable]
		public class NamedColor
		{
			public string colorName;

			public Color color;

			public float price;
		}

		[Serializable]
		public class SecondaryPaintTarget
		{
			public List<MeshRenderer> colorTargets;

			public float sChange;

			public float vChange;
		}

		[Header("References")]
		[SerializeField]
		protected List<MeshRenderer> colorTargets;

		[SerializeField]
		protected List<SecondaryPaintTarget> secondaryTargets;

		[Header("Color settings")]
		public List<NamedColor> colors;

		public int defaultColorIndex;

		[SyncVar]
		public int ownedColorIndex;

		public SyncVar<int> syncVar___ownedColorIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EColorFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EColorFeatureAssembly_002DCSharp_002Edll_Excuted;

		public int SyncAccessor_ownedColorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override FI_Base CreateInterface(Transform parent)
		{
			return null;
		}

		public override void Default()
		{
		}

		private void ApplyColor(NamedColor color)
		{
		}

		public static Color ModifyColor(Color original, float sChange, float vChange)
		{
			return default(Color);
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
		}

		private void ReceiveData()
		{
		}

		private void BuyColor(NamedColor color)
		{
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

		private void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
		}

		protected virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
		}

		private void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EConstruction_002EFeatures_002EColorFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
