namespace ScheduleOne.DevUtilities
{
	public class ObjectSelector : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.ObjectSelector>
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected float detectionRange;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.LayerMask detectionMask;

		private global::System.Collections.Generic.List<global::System.Type> allowedTypes;

		private global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> selectedObjects;

		private global::System.Collections.Generic.List<global::ScheduleOne.ConstructableScripts.Constructable> selectedConstructables;

		public global::System.Action onClose;

		private int selectionLimit;

		private bool exitOnSelectionLimit;

		private global::ScheduleOne.EntityFramework.BuildableItem hoveredBuildable;

		private global::ScheduleOne.ConstructableScripts.Constructable hoveredConstructable;

		private global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> outlinedObjects;

		private global::System.Collections.Generic.List<global::ScheduleOne.ConstructableScripts.Constructable> outlinedConstructables;

		public bool isSelecting { get; protected set; }

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private global::ScheduleOne.EntityFramework.BuildableItem GetHoveredBuildable()
		{
			return null;
		}

		private global::ScheduleOne.ConstructableScripts.Constructable GetHoveredConstructable()
		{
			return null;
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void StartSelecting(string selectionTitle, global::System.Collections.Generic.List<global::System.Type> _typeRestriction, ref global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> initialSelection_Objects, ref global::System.Collections.Generic.List<global::ScheduleOne.ConstructableScripts.Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)
		{
		}

		public void StopSelecting()
		{
		}
	}
}
