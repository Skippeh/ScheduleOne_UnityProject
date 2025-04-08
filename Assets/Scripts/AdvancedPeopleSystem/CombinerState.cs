namespace AdvancedPeopleSystem
{
	public enum CombinerState : byte
	{
		NotCombined = 0,
		InProgressCombineMesh = 1,
		InProgressBlendshapeTransfer = 2,
		InProgressClear = 3,
		Combined = 4,
		UsedPreBuitMeshes = 5
	}
}
