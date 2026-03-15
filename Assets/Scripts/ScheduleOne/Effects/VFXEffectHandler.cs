namespace ScheduleOne.Effects
{
	public class VFXEffectHandler : global::ScheduleOne.Effects.EffectHandler
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::UnityEngine.VFX.VisualEffect> _visualEffects;

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		public override void SetColorParameterForAll(string variable, global::UnityEngine.Color value)
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

		public override void SetVectorParameterForAll(string variable, global::UnityEngine.Vector3 value)
		{
		}

		public override void SetVectorParameterForAll(string variable, global::UnityEngine.Vector2 value)
		{
		}
	}
}
