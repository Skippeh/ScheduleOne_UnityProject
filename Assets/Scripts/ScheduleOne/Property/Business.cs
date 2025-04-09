using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Property
{
	public class Business : Property, ISaveable
	{
		public static List<Business> Businesses;

		public static List<Business> UnownedBusinesses;

		public static List<Business> OwnedBusinesses;

		[Header("Settings")]
		public float LaunderCapacity;

		public List<LaunderingOperation> LaunderingOperations;

		public static Action<LaunderingOperation> onOperationStarted;

		public static Action<LaunderingOperation> onOperationFinished;

		private BusinessLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EBusinessAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EBusinessAssembly_002DCSharp_002Edll_Excuted;

		public float currentLaunderTotal => 0f;

		public float appliedLaunderLimit => 0f;

		public new string SaveFileName => null;

		public new Loader Loader => null;

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected virtual void MinPass()
		{
		}

		protected virtual void MinsPass(int mins)
		{
		}

		private void TimeSkipped(int minsPassed)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public virtual void Load(BusinessData businessData, string containerPath)
		{
		}

		protected override void RecieveOwned()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
		}

		[TargetRpc]
		[ObserversRpc]
		private void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		protected void CompleteOperation(LaunderingOperation op)
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

		private void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		public void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProperty_002EBusiness_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
