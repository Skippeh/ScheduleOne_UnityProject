using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Trash
{
	[RequireComponent(typeof(BoxCollider))]
	public class TrashGenerator : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		public const float TRASH_GENERATION_FRACTION = 0.2f;

		public const float DEFAULT_TRASH_PER_M2 = 0.015f;

		public static List<TrashGenerator> AllGenerators;

		[Range(1f, 200f)]
		[SerializeField]
		private int MaxTrashCount;

		[SerializeField]
		private List<TrashItem> generatedTrash;

		[Header("Settings")]
		public LayerMask GroundCheckMask;

		private BoxCollider boxCollider;

		public string StaticGUID;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public Guid GUID { get; protected set; }

		public void SetGUID(Guid guid)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void AddGeneratedTrash(TrashItem item)
		{
		}

		public void RemoveGeneratedTrash(TrashItem item)
		{
		}

		[Button]
		private void RegenerateGUID()
		{
		}

		[Button]
		private void AutoCalculateTrashCount()
		{
		}

		[Button]
		private void GenerateMaxTrash()
		{
		}

		private void SleepStart()
		{
		}

		private void GenerateTrash(int count)
		{
		}

		public bool ShouldSave()
		{
			return false;
		}

		public virtual string GetSaveString()
		{
			return null;
		}
	}
}
