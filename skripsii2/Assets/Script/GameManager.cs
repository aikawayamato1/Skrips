using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeset = 2000f;
    public GameObject GameOver;
    public GameObject Win;
    // Update is called once per frame
    void Update()
    {
        timeset -= Time.deltaTime;
        if(timeset<=0)
        {
            GameOver.SetActive(true);
        }
    }
    public void Winning()
    {
        Win.SetActive(true);
    }
}
