using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MouseGetItem : MonoBehaviour
{
    private Vector3 mousePos;
    public bool barat=false;
    public bool timur=false;
    public bool utara=false;
    public bool selatan=false;
    public GameObject Gerbang;
    public GameObject Notification;
    public GameObject[] gameobjects;
    public GameManager game;
    public BookMenu BM;
    public GameObject Rustedkey;
    public GameObject Keys;
    public int key = 1;
    public int key2 = 1;
    public int totalkeyGet=0;
    public GateCon GC;
    public GameObject go;
    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject map;
    private CanvasGroup CG;
    private const int SIZE = 10;
    public GameObject[] gm = new GameObject[SIZE];
    public ItemList il;
    private int index = 0;
    // Start is called before the first frame update
    void OnValidate()
    {
        if (gm.Length != SIZE)
        {
            Array.Resize(ref gm, SIZE);
        }
    }
    void Start()
    {
        gameobjects = new GameObject[10];
        CG = Notification.GetComponent<CanvasGroup>();
        il = GameObject.Find("ItemList").GetComponent<ItemList>();
    }

    // Update is called once per frame
    void Update()
    {
        if(totalkeyGet==4)
        {
            BM.changeBoolean(3);
        }
        
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

                if (hit.transform.gameObject.tag == "Item")
                {
                    if (hit.transform.gameObject.name == "KunciAlpha")
                    {
                        gameobjects[index] = il.gameobjects[0];
                        gm[0].SetActive(true);
                        totalkeyGet++;
                        index++;
                    }
                    if (hit.transform.gameObject.name == "KunciBeta")
                    {
                        gameobjects[index] = il.gameobjects[1];
                        gm[1].SetActive(true);
                        totalkeyGet++;
                        index++;
                    }
                    if (hit.transform.gameObject.name == "KunciGamma")
                    {
                        gameobjects[index] = il.gameobjects[2];
                        gm[2].SetActive(true);
                        totalkeyGet++;
                        index++;
                    }
                    if (hit.transform.gameObject.name == "KunciDelta")
                    {
                        gameobjects[index] = il.gameobjects[3];
                        gm[3].SetActive(true);
                        totalkeyGet++;
                        index++;
                    }
                    if (hit.transform.gameObject.name == "RustedKey" || hit.transform.gameObject.name == "RustedKey(Clone)")
                    {
                        gameobjects[index] = il.gameobjects[0];
                        gm[0].SetActive(true);
                        index++;
                    }
                    if (hit.transform.gameObject.name == "Keys" || hit.transform.gameObject.name == "Keys(Clone)")
                    {
                        gameobjects[index] = il.gameobjects[1];
                        gm[1].SetActive(true);
                        index++;
                    }
                    Destroy(hit.transform.gameObject);
                }
                else
                {

                }
                if (hit.transform.gameObject.tag == "Interact")
                {
                    if (hit.transform.gameObject.name == "PohonKertas")
                    {
                        BM.changeBoolean(0);
                        go.SetActive(true);
                        
                    }
                    if (hit.transform.gameObject.name == "PohonKunci")
                    {

                        if (key2 > 0)
                        {
                            Instantiate(Keys, ray.origin, Quaternion.identity);
                            key2--;
                        }

                    }
                    if (hit.transform.gameObject.name == "Tuas")
                    {
                        if (GC.Gates() == true)
                        {
                            game.Winning();
                        }
                    }
                    if (hit.transform.gameObject.name == "bed")
                    {
                        if (key > 0)
                        {
                            Instantiate(Rustedkey, ray.origin, Quaternion.identity);
                            key--;
                        }

                    }
                    if (hit.transform.gameObject.name == "coretan1")
                    {
                        note1.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "coretan2")
                    {
                        note2.SetActive(true);
                        Debug.Log("Coretan");
                    }
                    if (hit.transform.gameObject.name == "Paper1")
                    {
                        note3.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "Paper2")
                    {
                        note4.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "kertas3")
                    {
                        note4.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "kertas4")
                    {
                        note3.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "Batu")
                    {
                        map.SetActive(true);
                        BM.changeBoolean(1);
                    }

                    if (hit.transform.gameObject.name == "BatuBarat")
                    {
                        
                        barat = true;
                        
                        Debug.Log("Pressed");
                        CG.alpha = 1;
                        


                    }
                    if (hit.transform.gameObject.name == "BatuUtara")
                    {
                        if (barat == true)
                        {
                            utara = true;
                            Debug.Log("Pressed");
                            CG.alpha = 1;
                            
                        }
                    }
                    if (hit.transform.gameObject.name == "BatuSelatan")
                    {
                        if (utara == true)
                        {
                            selatan = true;
                            Debug.Log("Pressed");
                            CG.alpha = 1;
                            
                        }
                    }
                    if (hit.transform.gameObject.name == "BatuTimur")
                    {
                        if (selatan == true)
                        {
                            timur = true;
                            Debug.Log("Pressed");
                            CG.alpha = 1;
                            
                            Gerbang.SetActive(true);
                        }
                    }
                }
                else
                {

                }
            }
        }
        Fade();
    }
    private void Fade()
    {
        CG.alpha -= Time.deltaTime;
    }
}
