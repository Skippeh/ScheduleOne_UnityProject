namespace ScheduleOne.TV
{
	public class RunnerGame : global::ScheduleOne.TV.TVApp
	{
		public float GameSpeed;

		public float MinGameSpeed;

		public float MaxGameSpeed;

		public float SpeedIncreaseRate;

		public int ScoreRate;

		public float Gravity;

		public float JumpForce;

		public float GlobalForceMultiplier;

		public float DropForce;

		public global::UnityEngine.RectTransform Character;

		public global::ScheduleOne.UI.Flipboard CharacterFlipboard;

		public global::ScheduleOne.UI.SlidingRect Ground;

		public global::ScheduleOne.UI.UISpawner CloudSpawner;

		public global::ScheduleOne.UI.UISpawner ObstacleSpawner;

		public global::TMPro.TextMeshProUGUI ScoreLabel;

		public global::TMPro.TextMeshProUGUI HighScoreLabel;

		public global::UnityEngine.GameObject StartScreen;

		public global::UnityEngine.GameObject GameOverScreen;

		public global::UnityEngine.Animation NewHighScoreAnimation;

		public global::UnityEngine.Sprite JumpSprite;

		private bool isJumping;

		private bool isGrounded;

		private bool isReady;

		private float score;

		private float yVelocity;

		private float defaultCharacterY;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.UIMover> clouds;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.UIMover> obstacles;

		public global::UnityEngine.Events.UnityEvent onJump;

		public global::UnityEngine.Events.UnityEvent onHit;

		public global::UnityEngine.Events.UnityEvent onNewHighScore;

		protected override void Awake()
		{
		}

		public override void Open()
		{
		}

		protected override void TryPause()
		{
		}

		public void Update()
		{
		}

		private void Jump()
		{
		}

		private void CloudSpawned(global::UnityEngine.GameObject cloud)
		{
		}

		private void ObstacleSpawned(global::UnityEngine.GameObject obstacle)
		{
		}

		private void RefreshHighScore()
		{
		}

		public void PlayerCollided()
		{
		}

		private void EndGame()
		{
		}

		private void StartGame()
		{
		}

		private void ResetGame()
		{
		}
	}
}
