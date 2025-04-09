using System.Collections.Generic;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Building
{
	public class BuildUpdate_Cash : BuildUpdate_StoredItem
	{
		public int amountIndex;

		protected List<Transform> bills;

		private WorldSpaceLabel amountLabel;

		private float placeAmount => 0f;

		private void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		private void UpdateLabel()
		{
		}

		private void RefreshGhostModelAppearance()
		{
		}

		protected override void Place()
		{
		}

		protected override void PostPlace()
		{
		}

		public override void Stop()
		{
		}

		public float GetRelevantCashBalane()
		{
			return 0f;
		}
	}
}
