namespace ScheduleOne.AvatarFramework
{
	public class Accessory : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string Name;

		public string AssetPath;

		public bool ReduceFootSize;

		[global::UnityEngine.Range(0f, 1f)]
		public float FootSizeReduction;

		public bool ShouldBlockHair;

		public bool ColorAllMeshes;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.MeshRenderer[] meshesToColor;

		public global::UnityEngine.SkinnedMeshRenderer[] skinnedMeshesToColor;

		public global::UnityEngine.SkinnedMeshRenderer[] skinnedMeshesToBind;

		public global::UnityEngine.SkinnedMeshRenderer[] shapeKeyMeshRends;

		private void Awake()
		{
		}

		public void ApplyColor(global::UnityEngine.Color col)
		{
		}

		public void ApplyShapeKeys(float gender, float weight)
		{
		}

		public void BindBones(global::UnityEngine.Transform[] bones)
		{
		}
	}
}
