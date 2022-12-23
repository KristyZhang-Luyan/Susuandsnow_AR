using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI_noti;

    string UIObject_name;
    void Start()
    {
      UI_noti = GameObject.Find("diary");
      Debug.Log(UI_noti.name);


    }

    // Update is called once per frame
    void Update()
    {
      UI_noti.SetActive(true);

    }
}
