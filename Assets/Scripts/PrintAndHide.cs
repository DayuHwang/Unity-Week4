using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomNum;
    void Start()
    {
        randomNum = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.tag.Equals("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag.Equals("Blue") && i == randomNum)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }
}
