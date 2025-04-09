using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class MoveItemBehaviour : Behaviour
	{
		public enum EState
		{
			Idle = 0,
			WalkingToSource = 1,
			Grabbing = 2,
			WalkingToDestination = 3,
			Placing = 4
		}

		private TransitRoute assignedRoute;

		private ItemInstance itemToRetrieveTemplate;

		private int grabbedAmount;

		private int maxMoveAmount;

		private EState currentState;

		private Coroutine walkToSourceRoutine;

		private Coroutine grabRoutine;

		private Coroutine walkToDestinationRoutine;

		private Coroutine placingRoutine;

		private bool skipPickup;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EMoveItemBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EMoveItemBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public bool Initialized { get; protected set; }

		public void Initialize(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = false)
		{
		}

		public void Resume(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1)
		{
		}

		protected override void Begin()
		{
		}

		protected override void Pause()
		{
		}

		protected override void Resume()
		{
		}

		protected override void End()
		{
		}

		public override void Disable()
		{
		}

		private void StartTransit()
		{
		}

		private bool IsNpcInventoryItemValid(ItemInstance item)
		{
			return false;
		}

		private void EndTransit()
		{
		}

		public override void ActiveMinPass()
		{
		}

		public void WalkToSource()
		{
		}

		public void GrabItem()
		{
		}

		private void TakeItem()
		{
		}

		public void WalkToDestination()
		{
		}

		public void PlaceItem()
		{
		}

		private int GetAmountToGrab()
		{
			return 0;
		}

		private void StopCurrentActivity()
		{
		}

		public bool IsTransitRouteValid(TransitRoute route, string itemID, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public bool IsTransitRouteValid(TransitRoute route, ItemInstance templateItem, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public bool IsTransitRouteValid(TransitRoute route, string itemID)
		{
			return false;
		}

		public bool IsDestinationValid(TransitRoute route, ItemInstance item)
		{
			return false;
		}

		public bool CanGetToSource(TransitRoute route)
		{
			return false;
		}

		private Transform GetSourceAccessPoint(TransitRoute route)
		{
			return null;
		}

		private bool IsAtSource()
		{
			return false;
		}

		public bool CanGetToDestination(TransitRoute route)
		{
			return false;
		}

		private Transform GetDestinationAccessPoint(TransitRoute route)
		{
			return null;
		}

		private bool IsAtDestination()
		{
			return false;
		}

		public MoveItemData GetSaveData()
		{
			return null;
		}

		public void Load(MoveItemData moveItemData)
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

		public override void Awake()
		{
		}
	}
}
