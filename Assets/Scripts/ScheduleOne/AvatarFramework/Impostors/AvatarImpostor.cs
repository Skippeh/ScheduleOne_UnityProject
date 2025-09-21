namespace ScheduleOne.AvatarFramework.Impostors
{
	public class AvatarImpostor : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.MeshRenderer meshRenderer;

		public global::UnityEngine.Transform AnchorBone;

		private global::UnityEngine.Transform cachedCamera;

		private global::UnityEngine.Vector3 anchorBoneOffset;

		public bool HasTexture { get; private set; }

		private global::UnityEngine.Transform Camera => null;

		private void Awake()
		{
		}

		public void SetAvatarSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		private void LateUpdate()
		{
		}

		private void Realign()
		{
		}

		public void EnableImpostor()
		{
		}

		public void DisableImpostor()
		{
		}
	}
}
