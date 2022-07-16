using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    private const int SIZE = 10;
    public GameObject[] question=new GameObject[SIZE];
    private int index=0;
    public ScoreCounter SC;
    
    
    public void nextQuestioncorrect()
    {

        question[index].SetActive(false);
        index++;
        SC.IncreaseScore();
        if (index < 10)
        {
            question[index].SetActive(true);
        }
    }
    public void nextQuestionincorrect()
    {
        question[index].SetActive(false);
        index++;
        if(index<10)
        {
            question[index].SetActive(true);
        }
        
    }
    public int GetIndex()
    {
        return index;
    }
    
}
