using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property.Utilities.Power;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_PowerLine : ConstructUpdate_Base
	{
		[Header("Settings")]
		[SerializeField]
		protected Material ghostPowerLine_Material;

		[Header("References")]
		[SerializeField]
		protected GameObject cosmeticPowerNode;

		protected Transform tempPowerLineContainer;

		protected PowerNode hoveredPowerNode;

		protected List<Transform> tempSegments;

		protected PowerNode startNode;

		protected float powerLineInitialDistance;

		protected virtual void Start()
		{
		}

		public override void ConstructionStop()
		{
		}

		public void Exit(ExitAction exit)
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected PowerNode GetHoveredPowerNode()
		{
			return null;
		}

		private void CompletePowerLine(PowerNode target)
		{
		}

		private void StopCreatingPowerLine()
		{
		}
	}
}
