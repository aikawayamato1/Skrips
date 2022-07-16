using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    [SerializeField] private float scores ;
    private float scored = 0;
    public Text txt;
    public GameObject ScorePop;
    private float total;
    public Quiz quiz;
    private void Awake()
    {
        scores = PlayerPrefs.GetFloat("ScoringTime");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void IncreaseScore()
    {
        scored++;
    }
    // Update is called once per frame
    void Update()
    {
        if(quiz.GetIndex()==10)
        {
            Counting();
            ScorePop.SetActive(true);
        }
        txt.text = "" + total.ToString("0.0");
    }
    void Counting()
    {
        total=scores*(scored / 10) * 100;
    }
}
