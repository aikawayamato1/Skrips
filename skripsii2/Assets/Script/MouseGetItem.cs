using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MouseGetItem : MonoBehaviour
{
    Vector3 mousePos;
    public GameObject[] gameobjects;
    public GameObject Rustedkey;
    public int key = 1;
    public GateCon GC;
    public GameObject go;
    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject map;
    private const int SIZE = 10;
    public GameObject[] gm = new GameObject[SIZE];
    public ItemList il;
    int index = 0;
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

        il = GameObject.Find("ItemList").GetComponent<ItemList>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

                if (hit.transform.gameObject.tag == "Item")
                {
                    if (hit.transform.gameObject.name == "KunciAlpha")
                    {
                        gameobjects[index] = il.gameobjects[0];
                        gm[0].SetActive(true);
                        index++;
                    }
                    if (hit.transform.gameObject.name == "KunciBeta")
                    {
                        gameobjects[index] = il.gameobjects[1];
                        gm[1].SetActive(true);
                        index++;
                    }
                    if (hit.transform.gameObject.name == "KunciGamma")
                    {
                        gameobjects[index] = il.gameobjects[2];
                        gm[2].SetActive(true);
                        index++;
                    }
                    if (hit.transform.gameObject.name == "KunciDelta")
                    {
                        gameobjects[index] = il.gameobjects[3];
                        gm[3].SetActive(true);
                        index++;
                    }
                    if (hit.transform.gameObject.name == "RustedKey" || hit.transform.gameObject.name == "RustedKey(Clone)")
                    {
                        gameobjects[index] = il.gameobjects[0];
                        gm[0].SetActive(true);
                        index++;
                    }

                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.gameObject.tag == "Interact")
                {
                    if (hit.transform.gameObject.name == "PohonKertas")
                    {
                        go.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "Tuas")
                    {
                        if (GC.Gates() == true)
                        {
                            Debug.Log("GameEnd");
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

                    }
                    if (hit.transform.gameObject.name == "Paper1")
                    {
                        note3.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "Paper2")
                    {
                        note4.SetActive(true);

                    }
                    if (hit.transform.gameObject.name == "Batu")
                    {
                        map.SetActive(true);
                    }
                }
            }
        }
    }
}
