using FishNet.Object;
using ScheduleOne.Employees;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class Bed : NetworkBehaviour
	{
		public const int MIN_SLEEP_TIME = 1800;

		public const float SLEEP_TIME_SCALE = 1f;

		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		public GameObject Clipboard;

		public SpriteRenderer MugshotSprite;

		public TextMeshPro NameLabel;

		public MeshRenderer BlanketMesh;

		[Header("Materials")]
		public Material DefaultBlanket;

		public Material BotanistBlanket;

		public Material ChemistBlanket;

		public Material PackagerBlanket;

		public Material CleanerBlanket;

		public UnityEvent onAssignedEmployeeChanged;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EBedAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EBedAssembly_002DCSharp_002Edll_Excuted;

		public Employee AssignedEmployee { get; protected set; }

		public virtual void Awake()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private bool CanSleep()
		{
			return false;
		}

		public void SetAssignedEmployee(Employee employee)
		{
		}

		private void UpdateMaterial()
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

		private void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EBed_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
