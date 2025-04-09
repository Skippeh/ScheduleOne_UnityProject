using System.Collections.Generic;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	public class RunnerGame : TVApp
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

		public RectTransform Character;

		public Flipboard CharacterFlipboard;

		public SlidingRect Ground;

		public UISpawner CloudSpawner;

		public UISpawner ObstacleSpawner;

		public TextMeshProUGUI ScoreLabel;

		public TextMeshProUGUI HighScoreLabel;

		public GameObject StartScreen;

		public GameObject GameOverScreen;

		public Animation NewHighScoreAnimation;

		public Sprite JumpSprite;

		private bool isJumping;

		private bool isGrounded;

		private bool isReady;

		private float score;

		private float yVelocity;

		private float defaultCharacterY;

		private List<UIMover> clouds;

		private List<UIMover> obstacles;

		public UnityEvent onJump;

		public UnityEvent onHit;

		public UnityEvent onNewHighScore;

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

		private void CloudSpawned(GameObject cloud)
		{
		}

		private void ObstacleSpawned(GameObject obstacle)
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
