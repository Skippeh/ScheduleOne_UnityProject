namespace ScheduleOne.Casino
{
	public class PlayingCard : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class CardSprite
		{
			public global::ScheduleOne.Casino.PlayingCard.ECardSuit Suit;

			public global::ScheduleOne.Casino.PlayingCard.ECardValue Value;

			public global::UnityEngine.Sprite Sprite;
		}

		public struct CardData
		{
			public global::ScheduleOne.Casino.PlayingCard.ECardSuit Suit;

			public global::ScheduleOne.Casino.PlayingCard.ECardValue Value;

			public CardData(global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value)
			{
				Suit = default(global::ScheduleOne.Casino.PlayingCard.ECardSuit);
				Value = default(global::ScheduleOne.Casino.PlayingCard.ECardValue);
			}
		}

		public enum ECardSuit
		{
			Spades = 0,
			Hearts = 1,
			Diamonds = 2,
			Clubs = 3
		}

		public enum ECardValue
		{
			Blank = 0,
			Ace = 1,
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			Six = 6,
			Seven = 7,
			Eight = 8,
			Nine = 9,
			Ten = 10,
			Jack = 11,
			Queen = 12,
			King = 13
		}

		public string CardID;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.SpriteRenderer CardSpriteRenderer;

		public global::ScheduleOne.Casino.PlayingCard.CardSprite[] CardSprites;

		public global::UnityEngine.Animation FlipAnimation;

		public global::UnityEngine.AnimationClip FlipFaceUpClip;

		public global::UnityEngine.AnimationClip FlipFaceDownClip;

		[global::UnityEngine.Header("Sound")]
		public global::ScheduleOne.Audio.AudioSourceController FlipSound;

		public global::ScheduleOne.Audio.AudioSourceController LandSound;

		private global::UnityEngine.Coroutine moveRoutine;

		private global::System.Tuple<global::UnityEngine.Vector3, global::UnityEngine.Quaternion> lastGlideTarget;

		public bool IsFaceUp { get; private set; }

		public global::ScheduleOne.Casino.PlayingCard.ECardSuit Suit { get; private set; }

		public global::ScheduleOne.Casino.PlayingCard.ECardValue Value { get; private set; }

		public global::ScheduleOne.Casino.CardController CardController { get; private set; }

		private void OnValidate()
		{
		}

		public void SetCardController(global::ScheduleOne.Casino.CardController cardController)
		{
		}

		public void SetCard(global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue value, bool network = true)
		{
		}

		public void ClearCard()
		{
		}

		public void SetFaceUp(bool faceUp, bool network = true)
		{
		}

		public void GlideTo(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, float duration = 0.5f, bool network = true)
		{
		}

		private global::ScheduleOne.Casino.PlayingCard.CardSprite GetCardSprite(global::ScheduleOne.Casino.PlayingCard.ECardSuit suit, global::ScheduleOne.Casino.PlayingCard.ECardValue val)
		{
			return null;
		}

		[global::EasyButtons.Button]
		public void VerifyCardSprites()
		{
		}
	}
}
