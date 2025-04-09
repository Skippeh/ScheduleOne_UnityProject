using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	public class DeadDrop : MonoBehaviour, IGUIDRegisterable
	{
		public static List<DeadDrop> DeadDrops;

		public string DeadDropName;

		public string DeadDropDescription;

		public StorageEntity Storage;

		public POI PoI;

		public OptimizedLight Light;

		public string ItemCountVariable;

		[SerializeField]
		protected string BakedGUID;

		public Guid GUID { get; protected set; }

		[Button]
		public void RegenerateGUID()
		{
		}

		protected virtual void Awake()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Start()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public void OnDestroy()
		{
		}

		public static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			return null;
		}

		private void UpdateDeadDrop()
		{
		}
	}
}
