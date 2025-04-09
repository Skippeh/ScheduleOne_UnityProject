using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	public class Product_Equippable : Equippable_Viewmodel
	{
		[Header("References")]
		public FilledPackagingVisuals Visuals;

		public Transform ModelContainer;

		[Header("Settings")]
		public bool Consumable;

		public string ConsumeDescription;

		public float ConsumeTime;

		public float EffectsApplyDelay;

		public string ConsumeAnimationBool;

		public string ConsumeAnimationTrigger;

		public string ConsumeEquippableAssetPath;

		[Header("Events")]
		public UnityEvent onConsumeInputStart;

		public UnityEvent onConsumeInputComplete;

		public UnityEvent onConsumeInputCancel;

		private float consumeTime;

		private bool consumingInProgress;

		private Vector3 defaultModelPosition;

		private int productAmount;

		private Coroutine consumeRoutine;

		public override void Equip(ItemInstance item)
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
