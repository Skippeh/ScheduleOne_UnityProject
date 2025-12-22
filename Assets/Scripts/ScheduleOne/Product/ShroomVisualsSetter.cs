namespace ScheduleOne.Product
{
	public class ShroomVisualsSetter : global::ScheduleOne.Product.ProductVisualsSetter
	{
		protected enum EShroomMaterialType
		{
			Mushroom = 0,
			Bulk = 1
		}

		[global::System.Serializable]
		protected class MeshMaterialSettings
		{
			public global::UnityEngine.MeshRenderer Mesh;

			public global::System.Collections.Generic.List<global::ScheduleOne.Product.ShroomVisualsSetter.EShroomMaterialType> Materials;
		}

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Product.ShroomVisualsSetter.MeshMaterialSettings[] _meshes;

		public override void ApplyVisuals(global::ScheduleOne.Product.ProductDefinition definition)
		{
		}
	}
}
