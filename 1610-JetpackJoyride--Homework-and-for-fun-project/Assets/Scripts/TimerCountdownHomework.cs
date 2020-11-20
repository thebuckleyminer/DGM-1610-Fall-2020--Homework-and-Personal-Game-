using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdownHomework : MonoBehaviour
{
    private Text timerText;
    public int secondsBetweenShowing = 1;
    IEnumerator Start()
    {
        timerText = GetComponent<Text>();
        timerText.text = "Get Ready!";
        yield return new WaitForSeconds(secondsBetweenShowing);
        yield return new WaitForSeconds(secondsBetweenShowing);
        timerText.text = "10";
        var counterNumber = 10;
        while (counterNumber>0)
        {
            timerText.text = counterNumber.ToString();
            yield return new WaitForSeconds(secondsBetweenShowing);
            counterNumber--;
        }
        timerText.text = "Blast Off!";

    }
}
