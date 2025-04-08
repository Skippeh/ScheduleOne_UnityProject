public class FlockScare : global::UnityEngine.MonoBehaviour
{
	public LandingSpotController[] landingSpotControllers;

	public float scareInterval;

	public float distanceToScare;

	public int checkEveryNthLandingSpot;

	public int InvokeAmounts;

	private int lsc;

	private int ls;

	private LandingSpotController currentController;

	private void CheckProximityToLandingSpots()
	{
	}

	private void IterateLandingSpots()
	{
	}

	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		return false;
	}

	private void Invoker()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
