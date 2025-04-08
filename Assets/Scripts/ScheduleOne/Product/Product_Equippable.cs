namespace ScheduleOne.Product
{
	public class Product_Equippable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Packaging.FilledPackagingVisuals Visuals;

		public global::UnityEngine.Transform ModelContainer;

		[global::UnityEngine.Header("Settings")]
		public bool Consumable;

		public string ConsumeDescription;

		public float ConsumeTime;

		public float EffectsApplyDelay;

		public string ConsumeAnimationBool;

		public string ConsumeAnimationTrigger;

		public string ConsumeEquippableAssetPath;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onConsumeInputStart;

		public global::UnityEngine.Events.UnityEvent onConsumeInputComplete;

		public global::UnityEngine.Events.UnityEvent onConsumeInputCancel;

		private float consumeTime;

		private bool consumingInProgress;

		private global::UnityEngine.Vector3 defaultModelPosition;

		private int productAmount;

		private global::UnityEngine.Coroutine consumeRoutine;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
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
