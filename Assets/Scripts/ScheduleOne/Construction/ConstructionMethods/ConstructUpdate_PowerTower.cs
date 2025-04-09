using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Property.Utilities.Power;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_PowerTower : ConstructUpdate_OutdoorGrid
	{
		[Header("Materials")]
		public Material specialMat;

		public Material powerLine_GhostMat;

		[Header("References")]
		[SerializeField]
		protected GameObject cosmeticPowerNode;

		public float LengthFactor;

		protected Transform tempPowerLineContainer;

		protected List<Transform> tempSegments;

		private PowerNode hoveredPowerNode;

		protected PowerNode startNode;

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

		public void Exit(ExitAction exit)
		{
		}

		private PowerTower GetHoveredPowerTower()
		{
			return null;
		}

		protected PowerNode GetHoveredPowerNode()
		{
			return null;
		}

		protected override Constructable_GridBased PlaceNewConstructable()
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
