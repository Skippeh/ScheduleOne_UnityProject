namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class PreBuiltBlendshape
	{
		[global::UnityEngine.SerializeField]
		public string name;

		[global::UnityEngine.SerializeField]
		public float weight;

		public PreBuiltBlendshape(string name, float weight)
		{
		}
	}
}
