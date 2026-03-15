[global::System.Serializable]
public class DynamicGradient
{
	public global::UnityEngine.Gradient Gradient;

	[global::UnityEngine.Range(0f, 2f)]
	[global::UnityEngine.SerializeField]
	private float _saturationMultiplier;

	[global::UnityEngine.Range(0f, 2f)]
	[global::UnityEngine.SerializeField]
	private float _brightnessMultiplier;

	public global::UnityEngine.Color Evaluate(float value)
	{
		return default(global::UnityEngine.Color);
	}
}
