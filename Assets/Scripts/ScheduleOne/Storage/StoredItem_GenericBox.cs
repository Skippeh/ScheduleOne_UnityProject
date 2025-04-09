using UnityEngine;

namespace ScheduleOne.Storage
{
	public class StoredItem_GenericBox : StoredItem
	{
		private const float ReferenceIconWidth = 1024f;

		[Header("References")]
		[SerializeField]
		protected SpriteRenderer icon1;

		[SerializeField]
		protected SpriteRenderer icon2;

		[Header("Settings")]
		public float IconScale;

		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}
	}
}
