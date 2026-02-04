namespace ScheduleOne.NPCs.Behaviour
{
	public class MoveItemBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public enum EState
		{
			Idle = 0,
			WalkingToSource = 1,
			Grabbing = 2,
			WalkingToDestination = 3,
			Placing = 4
		}

		private global::ScheduleOne.Management.TransitRoute assignedRoute;

		private global::ScheduleOne.ItemFramework.ItemInstance itemToRetrieveTemplate;

		private int grabbedAmount;

		private int maxMoveAmount;

		private global::ScheduleOne.NPCs.Behaviour.MoveItemBehaviour.EState currentState;

		private global::UnityEngine.Coroutine walkToSourceRoutine;

		private global::UnityEngine.Coroutine grabRoutine;

		private global::UnityEngine.Coroutine walkToDestinationRoutine;

		private global::UnityEngine.Coroutine placingRoutine;

		private bool skipPickup;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EMoveItemBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EMoveItemBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public bool Initialized { get; protected set; }

		public void Initialize(global::ScheduleOne.Management.TransitRoute route, global::ScheduleOne.ItemFramework.ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = false)
		{
		}

		public void Resume(global::ScheduleOne.Management.TransitRoute route, global::ScheduleOne.ItemFramework.ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1)
		{
		}

		public override void Activate()
		{
		}

		public override void Pause()
		{
		}

		public override void Resume()
		{
		}

		public override void Deactivate()
		{
		}

		public override void Disable()
		{
		}

		private void StartTransit()
		{
		}

		private bool IsNpcInventoryItemValid(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return false;
		}

		private void EndTransit()
		{
		}

		public override void OnActiveTick()
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

		public bool IsTransitRouteValid(global::ScheduleOne.Management.TransitRoute route, string itemID, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public bool IsTransitRouteValid(global::ScheduleOne.Management.TransitRoute route, global::ScheduleOne.ItemFramework.ItemInstance templateItem, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public bool IsTransitRouteValid(global::ScheduleOne.Management.TransitRoute route, string itemID)
		{
			return false;
		}

		public bool IsDestinationValid(global::ScheduleOne.Management.TransitRoute route, global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return false;
		}

		public bool IsDestinationValid(global::ScheduleOne.Management.TransitRoute route, global::ScheduleOne.ItemFramework.ItemInstance item, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public bool CanGetToSource(global::ScheduleOne.Management.TransitRoute route)
		{
			return false;
		}

		private global::UnityEngine.Transform GetSourceAccessPoint(global::ScheduleOne.Management.TransitRoute route)
		{
			return null;
		}

		private bool IsAtSource()
		{
			return false;
		}

		public bool CanGetToDestination(global::ScheduleOne.Management.TransitRoute route)
		{
			return false;
		}

		private global::UnityEngine.Transform GetDestinationAccessPoint(global::ScheduleOne.Management.TransitRoute route)
		{
			return null;
		}

		private bool IsAtDestination()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.MoveItemData GetSaveData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.MoveItemData moveItemData)
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
