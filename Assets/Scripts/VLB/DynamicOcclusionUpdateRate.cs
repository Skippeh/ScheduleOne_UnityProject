namespace VLB
{
	[global::System.Flags]
	public enum DynamicOcclusionUpdateRate
	{
		Never = 1,
		OnEnable = 2,
		OnBeamMove = 4,
		EveryXFrames = 8,
		OnBeamMoveAndEveryXFrames = 0xC
	}
}
