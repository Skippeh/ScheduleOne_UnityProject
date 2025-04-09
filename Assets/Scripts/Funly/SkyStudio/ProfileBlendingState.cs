namespace Funly.SkyStudio
{
	public struct ProfileBlendingState
	{
		public SkyProfile blendedProfile;

		public SkyProfile fromProfile;

		public SkyProfile toProfile;

		public float progress;

		public float outProgress;

		public float inProgress;

		public float timeOfDay;

		public ProfileBlendingState(SkyProfile blendedProfile, SkyProfile fromProfile, SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay)
		{
			this.blendedProfile = blendedProfile;
			this.fromProfile = fromProfile;
			this.toProfile = toProfile;
			this.progress = progress;
			this.inProgress = inProgress;
			this.outProgress = outProgress;
			this.timeOfDay = timeOfDay;
		}
	}
}
