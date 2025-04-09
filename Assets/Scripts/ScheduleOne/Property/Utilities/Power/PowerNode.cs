using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Power
{
	public class PowerNode : MonoBehaviour
	{
		public bool poweredNode;

		public bool consumptionNode;

		public bool isConnectedToPower;

		[Header("References")]
		[SerializeField]
		protected Transform connectionPoint;

		public List<PowerLine> connections;

		public Transform pConnectionPoint => null;

		public bool IsConnectedTo(PowerNode node)
		{
			return false;
		}

		public void RecalculatePowerNetwork()
		{
		}

		public List<PowerNode> GetConnectedNodes(List<PowerNode> exclusions)
		{
			return null;
		}
	}
}
