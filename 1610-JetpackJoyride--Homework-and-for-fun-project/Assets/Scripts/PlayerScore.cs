using UnityEngine;
public class PlayerScore : MonoBehaviour
{
    public int coinCounter = 0;
    public float distanceTraveled = 0;
    private float gameStartingTime;
    private float distanceScaler = 10.0f;
    

    void Start()
    {
        gameStartingTime = Time.time;
    }
    void Update()
    {
        distanceTraveled = Mathf.RoundToInt((Time.time - gameStartingTime) * distanceScaler);
        
        //print(distanceTraveled); //THIS PRINT IS FOR DEBUGGING PURPOSES ONLY
    }

    public void CoinCollision()
    {
        coinCounter++;
    }
}