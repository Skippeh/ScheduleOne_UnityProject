namespace ScheduleOne.Weather
{
	public class ShaderEffectHandler : global::ScheduleOne.Effects.EffectHandler
	{
		[global::UnityEngine.Header("Mesh Renderers")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> _meshRenderers;

		private global::UnityEngine.MaterialPropertyBlock[] _propertyBlocks;

		public override void Initialise()
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		public override void SetVectorParameterForAll(string variable, global::UnityEngine.Vector3 value)
		{
		}

		public override void SetVectorParameterForAll(string variable, global::UnityEngine.Vector2 value)
		{
		}

		public override void SetNumericParameter(string effectName, string variable, float value)
		{
		}

		public override void SetNumericParameterForAll(string variable, float value)
		{
		}

		public override void SetVectorParameter(string effectName, string variable, global::UnityEngine.Vector3 value)
		{
		}

		public override void SetVectorParameter(string effectName, string variable, global::UnityEngine.Vector2 value)
		{
		}

		public override void SetColorParameterForAll(string variable, global::UnityEngine.Color value)
		{
		}
	}
}
