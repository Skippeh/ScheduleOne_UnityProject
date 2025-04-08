namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class MinMaxFacialBlendshapes
	{
		public string name;

		[global::UnityEngine.Range(-100f, 100f)]
		public float Min;

		[global::UnityEngine.Range(-100f, 100f)]
		public float Max;

		public float GetRandom()
		{
			return 0f;
		}
	}
}
