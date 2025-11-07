namespace ScheduleOne.Product
{
	public class Product_Equippable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Product.ProductVisualsSetter Visuals;

		public global::UnityEngine.Transform ModelContainer;

		private global::ScheduleOne.Product.FirstPersonProductConsumeAnimation consumeAnimation;

		private bool isConsumable;

		private float consumeTime;

		private bool consumingInProgress;

		private global::UnityEngine.Vector3 defaultModelPosition;

		private global::UnityEngine.Coroutine consumeRoutine;

		public string ConsumeDescription => null;

		public float ConsumeTime => 0f;

		public float EffectsApplyDelay => 0f;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		protected virtual void ApplyProductVisuals(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
		{
		}

		protected virtual void StartPrepare()
		{
		}

		protected virtual void CancelPrepare()
		{
		}

		protected virtual void Consume()
		{
		}

		protected virtual void ApplyEffects()
		{
		}
	}
}
