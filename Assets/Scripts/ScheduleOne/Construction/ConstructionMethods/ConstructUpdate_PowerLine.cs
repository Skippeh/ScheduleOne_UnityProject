namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_PowerLine : global::ScheduleOne.Construction.ConstructionMethods.ConstructUpdate_Base
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material ghostPowerLine_Material;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject cosmeticPowerNode;

		protected global::UnityEngine.Transform tempPowerLineContainer;

		protected global::ScheduleOne.Property.Utilities.Power.PowerNode hoveredPowerNode;

		protected global::System.Collections.Generic.List<global::UnityEngine.Transform> tempSegments;

		protected global::ScheduleOne.Property.Utilities.Power.PowerNode startNode;

		protected float powerLineInitialDistance;

		protected virtual void Start()
		{
		}

		public override void ConstructionStop()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected global::ScheduleOne.Property.Utilities.Power.PowerNode GetHoveredPowerNode()
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
