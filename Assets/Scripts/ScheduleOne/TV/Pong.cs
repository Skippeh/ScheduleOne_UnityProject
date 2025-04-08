namespace ScheduleOne.TV
{
	public class Pong : global::ScheduleOne.TV.TVApp
	{
		public enum EGameMode
		{
			SinglePlayer = 0,
			MultiPlayer = 1
		}

		public enum ESide
		{
			Left = 0,
			Right = 1
		}

		public enum EState
		{
			Ready = 0,
			Playing = 1,
			GameOver = 2
		}

		public global::UnityEngine.RectTransform Rect;

		public global::ScheduleOne.TV.PongPaddle LeftPaddle;

		public global::ScheduleOne.TV.PongPaddle RightPaddle;

		public global::ScheduleOne.TV.PongBall Ball;

		public global::TMPro.TextMeshProUGUI LeftScoreLabel;

		public global::TMPro.TextMeshProUGUI RightScoreLabel;

		public global::TMPro.TextMeshProUGUI WinnerLabel;

		[global::UnityEngine.Header("Settings")]
		public float InitialVelocity;

		public float VelocityGainPerSecond;

		public float MaxVelocity;

		public int GoalsToWin;

		[global::UnityEngine.Header("AI")]
		public float ReactionTime;

		public float TargetRandomization;

		public float SpeedMultiplier;

		public global::UnityEngine.Events.UnityEvent onServe;

		public global::UnityEngine.Events.UnityEvent onLeftScore;

		public global::UnityEngine.Events.UnityEvent onRightScore;

		public global::UnityEngine.Events.UnityEvent onGameOver;

		public global::UnityEngine.Events.UnityEvent onLocalPlayerWin;

		public global::UnityEngine.Events.UnityEvent onReset;

		private global::ScheduleOne.TV.Pong.ESide nextBallSide;

		private global::UnityEngine.Vector3 ballVelocity;

		private float reactionTimer;

		public global::ScheduleOne.TV.Pong.EGameMode GameMode { get; set; }

		public global::ScheduleOne.TV.Pong.EState State { get; set; }

		public int LeftScore { get; set; }

		public int RightScore { get; set; }

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void TryPause()
		{
		}

		public void UpdateInputs()
		{
		}

		private void UpdateAI()
		{
		}

		public void GoalHit(global::ScheduleOne.TV.Pong.ESide side)
		{
		}

		private void Win(global::ScheduleOne.TV.Pong.ESide winner)
		{
		}

		private void ResetBall()
		{
		}

		private void ServeBall()
		{
		}

		private void ResetGame()
		{
		}

		public void SetPaddleTargetY(global::ScheduleOne.TV.Pong.ESide player, float y)
		{
		}

		public override void Resume()
		{
		}
	}
}
