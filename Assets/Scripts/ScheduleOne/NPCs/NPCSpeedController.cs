using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	public class NPCSpeedController : MonoBehaviour
	{
		[Serializable]
		public class SpeedControl
		{
			public string id;

			public int priority;

			public float speed;

			public SpeedControl(string id, int priority, float speed)
			{
			}
		}

		[Header("Settings")]
		[Range(0f, 1f)]
		public float DefaultWalkSpeed;

		public float SpeedMultiplier;

		[Header("References")]
		public NPCMovement Movement;

		protected List<SpeedControl> speedControlStack;

		[Header("Debug")]
		public SpeedControl ActiveSpeedControl;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private SpeedControl GetHighestPriorityControl()
		{
			return null;
		}

		public void AddSpeedControl(SpeedControl control)
		{
		}

		public SpeedControl GetSpeedControl(string id)
		{
			return null;
		}

		public bool DoesSpeedControlExist(string id)
		{
			return false;
		}

		public void RemoveSpeedControl(string id)
		{
		}
	}
}
