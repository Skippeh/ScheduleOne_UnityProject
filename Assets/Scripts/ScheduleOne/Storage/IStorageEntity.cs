namespace ScheduleOne.Storage
{
	public interface IStorageEntity
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CClearReserve_003Ed__12 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Storage.StoredItem item;

			public global::ScheduleOne.Storage.IStorageEntity _003C_003E4__this;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CClearReserve_003Ed__12(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		global::UnityEngine.Transform storedItemContainer { get; }

		global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StoredItem, global::ScheduleOne.Employees.Employee> reservedItems { get; }

		global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> GetStoredItems();

		global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageGrid> GetStorageGrids();

		global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> GetStoredItemsByID(string ID)
		{
			return null;
		}

		void ReserveItem(global::ScheduleOne.Storage.StoredItem item, global::ScheduleOne.Employees.Employee employee)
		{
		}

		void DereserveItem(global::ScheduleOne.Storage.StoredItem item)
		{
		}

		bool IsItemReserved(global::ScheduleOne.Storage.StoredItem item)
		{
			return false;
		}

		global::ScheduleOne.Employees.Employee WhoIsReserving(global::ScheduleOne.Storage.StoredItem item)
		{
			return null;
		}

		global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> GetNonReservedItemsByPrefabID(string prefabID, global::ScheduleOne.Employees.Employee whosAskin)
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Storage.IStorageEntity._003CClearReserve_003Ed__12))]
		global::System.Collections.IEnumerator ClearReserve(global::ScheduleOne.Storage.StoredItem item)
		{
			return null;
		}

		bool TryFitItem(int sizeX, int sizeY, out global::ScheduleOne.Storage.StorageGrid grid, out global::ScheduleOne.Tiles.Coordinate originCoordinate, out float rotation)
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
