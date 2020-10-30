using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{
    public bool gameOverBool = false;

    public int totalUpdateRunScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (!gameOverBool)
        {
            totalUpdateRunScore++;
        }
    }

    //public IEnumerator gameRunningLoop(bool gameOverBool)
    //{
    //    while (!gameOverBool)
    //    {
    //        yield return new WaitForSeconds(10);
    //        print("Ten seconds have passed");
    //    }
    //}
}
