using System;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Growing
{
	public class FunctionalSeed : MonoBehaviour
	{
		public Action onSeedExitVial;

		public Draggable Vial;

		public Collider SeedBlocker;

		public VialCap Cap;

		public Collider SeedCollider;

		public Rigidbody SeedRigidbody;

		public TrashItem TrashPrefab;

		public void TriggerExit(Collider other)
		{
		}
	}
}
