namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_PowerTower : global::ScheduleOne.Construction.ConstructionMethods.ConstructUpdate_OutdoorGrid
	{
		[global::UnityEngine.Header("Materials")]
		public global::UnityEngine.Material specialMat;

		public global::UnityEngine.Material powerLine_GhostMat;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject cosmeticPowerNode;

		public float LengthFactor;

		protected global::UnityEngine.Transform tempPowerLineContainer;

		protected global::System.Collections.Generic.List<global::UnityEngine.Transform> tempSegments;

		private global::ScheduleOne.Property.Utilities.Power.PowerNode hoveredPowerNode;

		protected global::ScheduleOne.Property.Utilities.Power.PowerNode startNode;

		protected float powerLineInitialDistance;

		protected override void Start()
		{
		}

		public override void ConstructionStop()
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		private global::ScheduleOne.ObjectScripts.PowerTower GetHoveredPowerTower()
		{
			return null;
		}

		protected global::ScheduleOne.Property.Utilities.Power.PowerNode GetHoveredPowerNode()
		{
			return null;
		}

		protected override global::ScheduleOne.ConstructableScripts.Constructable_GridBased PlaceNewConstructable()
		{
			return null;
		}

		private void CompletePowerLine(global::ScheduleOne.Property.Utilities.Power.PowerNode target)
		{
		}

		private void StopCreatingPowerLine()
		{
		}
	}
}
