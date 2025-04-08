namespace ScheduleOne.Employees
{
	public class EmployeeManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Employees.EmployeeManager>
	{
		[global::System.Serializable]
		public class EmployeeAppearance
		{
			public global::ScheduleOne.AvatarFramework.AvatarSettings Settings;

			public global::UnityEngine.Sprite Mugshot;
		}

		public const float MALE_EMPLOYEE_CHANCE = 0.67f;

		public global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee> AllEmployees;

		public global::ScheduleOne.Quests.Quest_Employees[] EmployeeQuests;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.Employees.Botanist BotanistPrefab;

		public global::ScheduleOne.Employees.Packager PackagerPrefab;

		public global::ScheduleOne.Employees.Chemist ChemistPrefab;

		public global::ScheduleOne.Employees.Cleaner CleanerPrefab;

		[global::UnityEngine.Header("Appearances")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Employees.EmployeeManager.EmployeeAppearance> MaleAppearances;

		public global::System.Collections.Generic.List<global::ScheduleOne.Employees.EmployeeManager.EmployeeAppearance> FemaleAppearances;

		[global::UnityEngine.Header("Voices")]
		public global::ScheduleOne.VoiceOver.VODatabase[] MaleVoices;

		public global::ScheduleOne.VoiceOver.VODatabase[] FemaleVoices;

		[global::UnityEngine.Header("Names")]
		public string[] MaleFirstNames;

		public string[] FemaleFirstNames;

		public string[] LastNames;

		private global::System.Collections.Generic.List<string> takenNames;

		private global::System.Collections.Generic.List<int> takenMaleAppearances;

		private global::System.Collections.Generic.List<int> takenFemaleAppearances;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EEmployeeManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EEmployeeManagerAssembly_002DCSharp_002Edll_Excuted;

		public void CreateNewEmployee(global::ScheduleOne.Property.Property property, global::ScheduleOne.Employees.EEmployeeType type)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void CreateEmployee(global::ScheduleOne.Property.Property property, global::ScheduleOne.Employees.EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, string guid = "")
		{
		}

		public global::ScheduleOne.Employees.Employee CreateEmployee_Server(global::ScheduleOne.Property.Property property, global::ScheduleOne.Employees.EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, string guid)
		{
			return null;
		}

		private bool IsPositionValid(global::UnityEngine.Vector3 position)
		{
			return false;
		}

		private bool IsRotationValid(global::UnityEngine.Quaternion rotation)
		{
			return false;
		}

		private bool IsFloatValid(float value)
		{
			return false;
		}

		public void RegisterName(string name)
		{
		}

		public void RegisterAppearance(bool male, int index)
		{
		}

		public void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
			firstName = null;
			lastName = null;
		}

		public global::ScheduleOne.Employees.EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			return null;
		}

		public global::ScheduleOne.VoiceOver.VODatabase GetVoice(bool male, int index)
		{
			return null;
		}

		public void GetRandomAppearance(bool male, out int index, out global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
			index = default(int);
			settings = null;
		}

		public global::ScheduleOne.Employees.Employee GetEmployeePrefab(global::ScheduleOne.Employees.EEmployeeType type)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee> GetEmployeesByType(global::ScheduleOne.Employees.EEmployeeType type)
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

		private void RpcWriter___Server_CreateEmployee_311954683(global::ScheduleOne.Property.Property property, global::ScheduleOne.Employees.EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, string guid = "")
		{
		}

		public void RpcLogic___CreateEmployee_311954683(global::ScheduleOne.Property.Property property, global::ScheduleOne.Employees.EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, string guid = "")
		{
		}

		private void RpcReader___Server_CreateEmployee_311954683(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public override void Awake()
		{
		}
	}
}
