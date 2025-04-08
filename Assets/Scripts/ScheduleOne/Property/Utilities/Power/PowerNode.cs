namespace ScheduleOne.Property.Utilities.Power
{
	public class PowerNode : global::UnityEngine.MonoBehaviour
	{
		public bool poweredNode;

		public bool consumptionNode;

		public bool isConnectedToPower;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform connectionPoint;

		public global::System.Collections.Generic.List<global::ScheduleOne.Property.Utilities.Power.PowerLine> connections;

		public global::UnityEngine.Transform pConnectionPoint => null;

		public bool IsConnectedTo(global::ScheduleOne.Property.Utilities.Power.PowerNode node)
		{
			return false;
		}

		public void RecalculatePowerNetwork()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Property.Utilities.Power.PowerNode> GetConnectedNodes(global::System.Collections.Generic.List<global::ScheduleOne.Property.Utilities.Power.PowerNode> exclusions)
		{
			return null;
		}
	}
}
