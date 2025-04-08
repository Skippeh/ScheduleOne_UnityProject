namespace ScheduleOne.Storage
{
	public class StoredItem_GenericBox : global::ScheduleOne.Storage.StoredItem
	{
		private const float ReferenceIconWidth = 1024f;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.SpriteRenderer icon1;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.SpriteRenderer icon2;

		[global::UnityEngine.Header("Settings")]
		public float IconScale;

		public override void InitializeStoredItem(global::ScheduleOne.Storage.StorableItemInstance _item, global::ScheduleOne.Storage.StorageGrid grid, global::UnityEngine.Vector2 _originCoordinate, float _rotation)
		{
		}
	}
}
