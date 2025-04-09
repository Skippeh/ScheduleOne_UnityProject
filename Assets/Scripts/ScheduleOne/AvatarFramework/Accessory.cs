using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	public class Accessory : MonoBehaviour
	{
		[Header("Settings")]
		public string Name;

		public string AssetPath;

		public bool ReduceFootSize;

		[Range(0f, 1f)]
		public float FootSizeReduction;

		public bool ShouldBlockHair;

		public bool ColorAllMeshes;

		[Header("References")]
		public MeshRenderer[] meshesToColor;

		public SkinnedMeshRenderer[] skinnedMeshesToColor;

		public SkinnedMeshRenderer[] skinnedMeshesToBind;

		public SkinnedMeshRenderer[] shapeKeyMeshRends;

		private void Awake()
		{
		}

		public void ApplyColor(Color col)
		{
		}

		public void ApplyShapeKeys(float gender, float weight)
		{
		}

		public void BindBones(Transform[] bones)
		{
		}
	}
}
