namespace ScheduleOne.PlayerTasks
{
	public class UseBrickPress : global::ScheduleOne.PlayerTasks.Task
	{
		public enum EStep
		{
			Pouring = 0,
			Pressing = 1,
			Complete = 2
		}

		public const float PRODUCT_SCALE = 0.75f;

		protected global::ScheduleOne.PlayerTasks.UseBrickPress.EStep currentStep;

		protected global::ScheduleOne.ObjectScripts.BrickPress press;

		protected global::ScheduleOne.Product.ProductItemInstance product;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Product.FunctionalProduct> products;

		protected global::ScheduleOne.PlayerTasks.Draggable container;

		public override string TaskName { get; protected set; }

		public UseBrickPress(global::ScheduleOne.ObjectScripts.BrickPress _press, global::ScheduleOne.Product.ProductItemInstance _product)
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
