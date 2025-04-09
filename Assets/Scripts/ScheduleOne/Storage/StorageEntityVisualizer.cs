using UnityEngine;

namespace ScheduleOne.Storage
{
	[RequireComponent(typeof(StorageEntity))]
	public class StorageEntityVisualizer : StorageVisualizer
	{
		private StorageEntity storageEntity;

		protected virtual void Start()
		{
		}
	}
}
