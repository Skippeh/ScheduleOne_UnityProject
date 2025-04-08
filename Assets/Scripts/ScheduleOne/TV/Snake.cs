namespace ScheduleOne.TV
{
	public class Snake : global::ScheduleOne.TV.TVApp
	{
		public enum EGameState
		{
			Ready = 0,
			Playing = 1
		}

		public const int SIZE_X = 20;

		public const int SIZE_Y = 12;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.TV.SnakeTile TilePrefab;

		public float TimePerTile;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform PlaySpace;

		public global::ScheduleOne.TV.SnakeTile[] Tiles;

		public global::TMPro.TextMeshProUGUI ScoreText;

		private global::UnityEngine.Vector2 lastFoodPosition;

		private float _timeSinceLastMove;

		private float _timeOnGameOver;

		public global::UnityEngine.Events.UnityEvent onStart;

		public global::UnityEngine.Events.UnityEvent onEat;

		public global::UnityEngine.Events.UnityEvent onGameOver;

		public global::UnityEngine.Events.UnityEvent onWin;

		public global::UnityEngine.Vector2 HeadPosition { get; private set; }

		public global::System.Collections.Generic.List<global::UnityEngine.Vector2> Tail { get; private set; }

		public global::UnityEngine.Vector2 LastTailPosition { get; private set; }

		public global::UnityEngine.Vector2 Direction { get; private set; }

		public global::UnityEngine.Vector2 QueuedDirection { get; private set; }

		public global::UnityEngine.Vector2 NextDirection { get; private set; }

		public global::ScheduleOne.TV.Snake.EGameState GameState { get; private set; }

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateInput()
		{
		}

		private void UpdateMovement()
		{
		}

		private void MoveSnake()
		{
		}

		private global::ScheduleOne.TV.SnakeTile GetTile(global::UnityEngine.Vector2 position)
		{
			return null;
		}

		private void StartGame(global::UnityEngine.Vector2 initialDir)
		{
		}

		private void Eat()
		{
		}

		private void SpawnFood()
		{
		}

		private void GameOver()
		{
		}

		private void Win()
		{
		}

		protected override void TryPause()
		{
		}

		[global::EasyButtons.Button]
		public void CreateTiles()
		{
		}
	}
}
