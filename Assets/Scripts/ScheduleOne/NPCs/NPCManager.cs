namespace ScheduleOne.NPCs
{
	public class NPCManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.NPCs.NPCManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> NPCRegistry;

		public global::UnityEngine.Transform[] NPCWarpPoints;

		public global::UnityEngine.Transform NPCContainer;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.Map.NPCPoI NPCPoIPrefab;

		public global::ScheduleOne.Map.NPCPoI PotentialCustomerPoIPrefab;

		public global::ScheduleOne.Map.NPCPoI PotentialDealerPoIPrefab;

		private global::ScheduleOne.Persistence.Loaders.NPCsLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public static global::ScheduleOne.NPCs.NPC GetNPC(string id)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> GetNPCsInRegion(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> GetOrderedDistanceWarpPoints(global::UnityEngine.Vector3 origin)
		{
			return null;
		}

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		[global::EasyButtons.Button]
		public void GetNPCsWithSewerKey()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
