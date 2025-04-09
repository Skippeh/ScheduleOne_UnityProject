using System.Collections.Generic;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.PlayerTasks
{
	public class UseBrickPress : Task
	{
		public enum EStep
		{
			Pouring = 0,
			Pressing = 1,
			Complete = 2
		}

		public const float PRODUCT_SCALE = 0.75f;

		protected EStep currentStep;

		protected BrickPress press;

		protected ProductItemInstance product;

		protected List<FunctionalProduct> products;

		protected Draggable container;

		public override string TaskName { get; protected set; }

		public UseBrickPress(BrickPress _press, ProductItemInstance _product)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		private void CheckMould()
		{
		}

		private void BeginPress()
		{
		}

		private void FinishPress()
		{
		}
	}
}
