namespace ScheduleOne.Packaging
{
	public class FilledPackagingVisuals : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class MeshIndexPair
		{
			public global::UnityEngine.MeshRenderer Mesh;

			public int MaterialIndex;
		}

		[global::System.Serializable]
		public class BaseVisuals
		{
			public global::UnityEngine.Transform Container;
		}

		[global::System.Serializable]
		public class WeedVisuals : global::ScheduleOne.Packaging.FilledPackagingVisuals.BaseVisuals
		{
			public global::ScheduleOne.Packaging.FilledPackagingVisuals.MeshIndexPair[] MainMeshes;

			public global::ScheduleOne.Packaging.FilledPackagingVisuals.MeshIndexPair[] SecondaryMeshes;

			public global::ScheduleOne.Packaging.FilledPackagingVisuals.MeshIndexPair[] LeafMeshes;

			public global::ScheduleOne.Packaging.FilledPackagingVisuals.MeshIndexPair[] StemMeshes;
		}

		[global::System.Serializable]
		public class MethVisuals : global::ScheduleOne.Packaging.FilledPackagingVisuals.BaseVisuals
		{
			public global::UnityEngine.MeshRenderer[] CrystalMeshes;
		}

		[global::System.Serializable]
		public class CocaineVisuals : global::ScheduleOne.Packaging.FilledPackagingVisuals.BaseVisuals
		{
			public global::UnityEngine.MeshRenderer[] RockMeshes;
		}

		public global::ScheduleOne.Packaging.FilledPackagingVisuals.WeedVisuals weedVisuals;

		public global::ScheduleOne.Packaging.FilledPackagingVisuals.MethVisuals methVisuals;

		public global::ScheduleOne.Packaging.FilledPackagingVisuals.CocaineVisuals cocaineVisuals;

		public void ResetVisuals()
		{
		}
	}
}
