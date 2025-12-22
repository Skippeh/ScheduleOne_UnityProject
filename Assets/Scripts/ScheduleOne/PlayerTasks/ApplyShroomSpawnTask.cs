namespace ScheduleOne.PlayerTasks
{
	public class ApplyShroomSpawnTask : global::ScheduleOne.PlayerTasks.Task
	{
		private enum EStage
		{
			BreakUpChunks = 0,
			MixIntoSoil = 1
		}

		private const float DistanceBetweenMixes = 0.08f;

		private const float MixRadius = 0.1f;

		private const int MaskTextureSize = 128;

		private const int SmallChunkCount = 16;

		private global::ScheduleOne.ItemFramework.ShroomSpawnDefinition _spawnDefinition;

		private global::ScheduleOne.ObjectScripts.MushroomBed _mushroomBed;

		private global::ScheduleOne.PlayerTasks.SpawnChunk _baseSpawnChunk;

		private global::ScheduleOne.PlayerTasks.ApplyShroomSpawnTask.EStage _currentStage;

		private global::UnityEngine.Rendering.Universal.DecalProjector _mixProjector;

		private global::UnityEngine.Vector3 _lastMixPosition;

		private global::UnityEngine.Texture2D _maskingTexture;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerTasks.SpawnChunk> _mixedChunks;

		private bool _mixMouseUp;

		public ApplyShroomSpawnTask(global::ScheduleOne.ObjectScripts.MushroomBed mushroomBed, global::ScheduleOne.ItemFramework.ShroomSpawnDefinition spawnDefinition)
		{
		}

		public override void StopTask()
		{
		}

		public override void Success()
		{
		}

		public override void Update()
		{
		}

		public override void LateUpdate()
		{
		}

		private void UpdateInstructionText()
		{
		}

		private void UpdateProgression()
		{
		}

		private bool GetCursorHoverOnSoil(out global::UnityEngine.Vector3 hitPoint)
		{
			hitPoint = default(global::UnityEngine.Vector3);
			return false;
		}

		private void TriggerMix(global::UnityEngine.Vector3 mixPoint)
		{
		}

		private void PaintMask(int x, int y)
		{
		}

		private global::UnityEngine.Texture2D CreateMaskTexture()
		{
			return null;
		}
	}
}
