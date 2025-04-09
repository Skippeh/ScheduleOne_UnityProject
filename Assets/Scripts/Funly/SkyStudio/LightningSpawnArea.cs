using UnityEngine;

namespace Funly.SkyStudio
{
	public class LightningSpawnArea : MonoBehaviour
	{
		[Tooltip("Dimensions of the lightning area where lightning bolts will be spawned inside randomly.")]
		public Vector3 lightningArea;

		public void OnDrawGizmosSelected()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
