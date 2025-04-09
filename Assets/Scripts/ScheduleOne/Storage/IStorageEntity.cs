using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Employees;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public interface IStorageEntity
	{
		[CompilerGenerated]
		private sealed class _003CClearReserve_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StoredItem item;

			public IStorageEntity _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CClearReserve_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		Transform storedItemContainer { get; }

		Dictionary<StoredItem, Employee> reservedItems { get; }

		List<StoredItem> GetStoredItems();

		List<StorageGrid> GetStorageGrids();

		List<StoredItem> GetStoredItemsByID(string ID)
		{
			return null;
		}

		void ReserveItem(StoredItem item, Employee employee)
		{
		}

		void DereserveItem(StoredItem item)
		{
		}

		bool IsItemReserved(StoredItem item)
		{
			return false;
		}

		Employee WhoIsReserving(StoredItem item)
		{
			return null;
		}

		List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CClearReserve_003Ed__12))]
		IEnumerator ClearReserve(StoredItem item)
		{
			return null;
		}

		bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation)
		{
			grid = null;
			originCoordinate = null;
			rotation = default(float);
			return false;
		}

		int HowManyCanFit(int sizeX, int sizeY, int limit = int.MaxValue)
		{
			return 0;
		}
	}
}
