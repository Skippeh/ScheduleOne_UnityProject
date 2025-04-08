namespace Funly.SkyStudio
{
	public class LightningSpawnArea : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Tooltip("Dimensions of the lightning area where lightning bolts will be spawned inside randomly.")]
		public global::UnityEngine.Vector3 lightningArea;

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
