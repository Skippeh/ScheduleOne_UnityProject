using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	public class AvatarImpostor : MonoBehaviour
	{
		public MeshRenderer meshRenderer;

		private Transform cachedCamera;

		public bool HasTexture { get; private set; }

		private Transform Camera => null;

		public void SetAvatarSettings(AvatarSettings settings)
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
