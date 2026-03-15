namespace ScheduleOne.Weather
{
	public class SkyProfileFrame
	{
		public global::UnityEngine.Color AmbientLightSkyColor;

		public global::UnityEngine.Color AmbientLightEquatorColor;

		public global::UnityEngine.Color AmbientLightGroundColor;

		public global::UnityEngine.Color SkyUpperColor;

		public global::UnityEngine.Color SkyMiddleColor;

		public global::UnityEngine.Color SkyLowerColor;

		public float SkyMiddleColorPosition;

		public float HorizonTrasitionStart;

		public float HorizonTransitionLength;

		public float StarTransitionStart;

		public float StarTransitionLength;

		public float HorizonStarScale;

		public SkyProfileFrame(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay)
		{
		}
	}
}
