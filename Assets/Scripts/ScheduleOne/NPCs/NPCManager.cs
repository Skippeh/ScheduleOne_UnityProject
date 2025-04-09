using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	public class NPCManager : NetworkSingleton<NPCManager>, IBaseSaveable, ISaveable
	{
		public static List<NPC> NPCRegistry;

		public Transform[] NPCWarpPoints;

		public Transform NPCContainer;

		[Header("Employee Prefabs")]
		public GameObject BotanistPrefab;

		public GameObject PackagerPrefab;

		[Header("Prefabs")]
		public NPCPoI NPCPoIPrefab;

		public NPCPoI PotentialCustomerPoIPrefab;

		public NPCPoI PotentialDealerPoIPrefab;

		private NPCsLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public void Update()
		{
		}

		public static NPC GetNPC(string id)
		{
			return null;
		}

		public static List<NPC> GetNPCsInRegion(EMapRegion region)
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public List<Transform> GetOrderedDistanceWarpPoints(Vector3 origin)
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
