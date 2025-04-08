namespace Funly.SkyStudio
{
	public struct ProfileBlendingState
	{
		public global::Funly.SkyStudio.SkyProfile blendedProfile;

		public global::Funly.SkyStudio.SkyProfile fromProfile;

		public global::Funly.SkyStudio.SkyProfile toProfile;

		public float progress;

		public float outProgress;

		public float inProgress;

		public float timeOfDay;

		public ProfileBlendingState(global::Funly.SkyStudio.SkyProfile blendedProfile, global::Funly.SkyStudio.SkyProfile fromProfile, global::Funly.SkyStudio.SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay)
		{
			this.blendedProfile = null;
			this.fromProfile = null;
			this.toProfile = null;
			this.progress = 0f;
			this.outProgress = 0f;
			this.inProgress = 0f;
			this.timeOfDay = 0f;
		}
	}
}
