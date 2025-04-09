using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.Quests;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Employees
{
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		[Serializable]
		public class EmployeeAppearance
		{
			public AvatarSettings Settings;

			public Sprite Mugshot;
		}

		public const float MALE_EMPLOYEE_CHANCE = 0.67f;

		public List<Employee> AllEmployees;

		public Quest_Employees[] EmployeeQuests;

		[Header("Prefabs")]
		public Botanist BotanistPrefab;

		public Packager PackagerPrefab;

		public Chemist ChemistPrefab;

		public Cleaner CleanerPrefab;

		[Header("Appearances")]
		public List<EmployeeAppearance> MaleAppearances;

		public List<EmployeeAppearance> FemaleAppearances;

		[Header("Voices")]
		public VODatabase[] MaleVoices;

		public VODatabase[] FemaleVoices;

		[Header("Names")]
		public string[] MaleFirstNames;

		public string[] FemaleFirstNames;

		public string[] LastNames;

		private List<string> takenNames;

		private List<int> takenMaleAppearances;

		private List<int> takenFemaleAppearances;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EEmployeeManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EEmployeeManagerAssembly_002DCSharp_002Edll_Excuted;

		public void CreateNewEmployee(ScheduleOne.Property.Property property, EEmployeeType type)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void CreateEmployee(ScheduleOne.Property.Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		public Employee CreateEmployee_Server(ScheduleOne.Property.Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			return null;
		}

		private bool IsPositionValid(Vector3 position)
		{
			return false;
		}

		private bool IsRotationValid(Quaternion rotation)
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

		public EmployeeAppearance GetAppearance(bool male, int index)
		{
			return null;
		}

		public VODatabase GetVoice(bool male, int index)
		{
			return null;
		}

		public void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
			index = default(int);
			settings = null;
		}

		public Employee GetEmployeePrefab(EEmployeeType type)
		{
			return null;
		}

		public List<Employee> GetEmployeesByType(EEmployeeType type)
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

		private void RpcWriter___Server_CreateEmployee_311954683(ScheduleOne.Property.Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		public void RpcLogic___CreateEmployee_311954683(ScheduleOne.Property.Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		private void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public override void Awake()
		{
		}
	}
}
