using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Maxtime = 2000f;
    public Text txttime;
    public float timeset;
    public int jumlahkata;
    public GameObject GameOver;
    public GameObject Win;
    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 1;
        timeset = Maxtime;
    }
    void Update()
    {
        timeset -= Time.deltaTime;
        if(timeset<=0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        txttime.text = "" + timeset.ToString("0.0");
    }
    public float scoreTime()
    {
        return jumlahkata/((Maxtime - timeset)/60);
    }
    public void Winning()
    {
        Win.SetActive(true);
        PlayerPrefs.SetFloat("ScoringTime",scoreTime());
        PlayerPrefs.SetFloat("TimeSize", Maxtime - timeset);

        Time.timeScale = 0;
    }
    

}
