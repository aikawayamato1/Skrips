using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    [SerializeField] private float scores ;
    private float scored = 0;
    private float TimeSize;
    public Text txt;
    public Text txt1;
    public Text txt2;
    public GameObject ScorePop;
    private float total;
    public Quiz quiz;
    private void Awake()
    {
        scores = PlayerPrefs.GetFloat("ScoringTime");
        TimeSize = PlayerPrefs.GetFloat("TimeSize");
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
            PlayerPrefs.SetFloat("QuizAnswer",scored);
            ScorePop.SetActive(true);
        }
        txt.text = "" + total.ToString("0.0");
        txt1.text = "" + TimeSize.ToString("0.0");
        txt2.text = "" + scored.ToString("0.0");
    }
    void Counting()
    {
        total=scores*(scored / 10) * 100;
    }
}
