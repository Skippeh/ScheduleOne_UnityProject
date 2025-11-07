namespace ScheduleOne.Product
{
	public abstract class ProductVisualsSetter : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform VisualsContainer;

		public abstract void ApplyVisuals(global::ScheduleOne.Product.ProductDefinition productDefinition);

		public void ApplyVisuals(global::ScheduleOne.Product.ProductItemInstance productInstance)
		{
		}

		public void ResetVisuals()
		{
		}

		protected bool TryCastProductDefinition<T>(global::ScheduleOne.Product.ProductDefinition definition, out T castedDefinition) where T : global::ScheduleOne.Product.ProductDefinition
		{
			castedDefinition = null;
			return false;
		}
	}
}
