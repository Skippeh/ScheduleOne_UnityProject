namespace ScheduleOne.Weather
{
	public class WeatherVolume : global::FishNet.Object.NetworkBehaviour
	{
		[global::UnityEngine.Header("Controllers")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherEffectController> _effectControllers;

		[global::UnityEngine.Header("Profile")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherProfile _weatherProfile;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		private bool _showGizmos;

		private global::UnityEngine.Vector3 _weatherBounds;

		private global::UnityEngine.Vector3 _volumeSize;

		private global::UnityEngine.Vector3 _blendSize;

		private global::UnityEngine.Vector3 _anchorPosition;

		private float _blendAmount;

		private bool _isInitialized;

		private global::UnityEngine.Vector3 _velocity;

		private bool NetworkInitialize___EarlyScheduleOne_002EWeather_002EWeatherVolumeAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EWeather_002EWeatherVolumeAssembly_002DCSharp_002Edll_Excuted;

		public float BlendAmount => 0f;

		public global::UnityEngine.Vector3 WeatherBounds => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 BlendSize => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 VolumeSize => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 Center => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 MinBounds => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 MaxBounds => default(global::UnityEngine.Vector3);

		public global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherEffectController> EffectControllers => null;

		public global::ScheduleOne.Weather.WeatherProfile WeatherProfile => null;

		protected global::UnityEngine.Vector3 TopRightBlendCorner => default(global::UnityEngine.Vector3);

		protected global::UnityEngine.Vector3 BottomRightBlendCorner => default(global::UnityEngine.Vector3);

		protected global::UnityEngine.Vector3 TopLeftBlendCorner => default(global::UnityEngine.Vector3);

		protected global::UnityEngine.Vector3 BottomLeftBlendCorner => default(global::UnityEngine.Vector3);

		[global::FishNet.Object.ObserversRpc(BufferLast = true, RunLocally = true)]
		public void Initialise(global::UnityEngine.Vector3 weatherBounds, global::UnityEngine.Vector3 volumeSize, global::UnityEngine.Vector3 blendSize, float blendAmount, global::UnityEngine.Vector3 anchorPosition, float heightMapWorldSize)
		{
		}

		private void Update()
		{
		}

		public void SetAnchor(global::UnityEngine.Vector3 anchorPosition)
		{
		}

		public void SetNeighbourVolume(global::ScheduleOne.Weather.WeatherVolume neighbourVolume)
		{
		}

		public void BlendEffects(float blend, global::UnityEngine.AnimationCurve blendCurve)
		{
		}

		public void SetShaderNumericParameter(string paramater, float value)
		{
		}

		public void SetShaderColorParameter(string paramater, global::UnityEngine.Color value)
		{
		}

		public void SetVisualEffectNumericParameter(string paramater, float value)
		{
		}

		public void UpdateVolume(global::UnityEngine.Vector3 playerPosition, float enclosureBlend)
		{
		}

		public bool IsInRightHalf(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		public global::UnityEngine.Vector2 GetClosestPointOnLeft(global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector2);
		}

		public global::UnityEngine.Vector2 GetClosestPointOnRight(global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector2);
		}

		private void OnDrawGizmos()
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Observers_Initialise_1999361799(global::UnityEngine.Vector3 weatherBounds, global::UnityEngine.Vector3 volumeSize, global::UnityEngine.Vector3 blendSize, float blendAmount, global::UnityEngine.Vector3 anchorPosition, float heightMapWorldSize)
		{
		}

		public void RpcLogic___Initialise_1999361799(global::UnityEngine.Vector3 weatherBounds, global::UnityEngine.Vector3 volumeSize, global::UnityEngine.Vector3 blendSize, float blendAmount, global::UnityEngine.Vector3 anchorPosition, float heightMapWorldSize)
		{
		}

		private void RpcReader___Observers_Initialise_1999361799(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
