using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCheker : MonoBehaviour
{
  public GameObject pointer;
  public GameObject pointer1;
  public GameObject pointer2;

  public GameObject cong;

   public GameObject backpack;
   public GameObject diary;
   public GameObject report;

  void Pointer()
  {
      // This returns the GameObject named Hand.
      pointer = GameObject.Find("marker1/pointer");

      // This returns the GameObject named Hand.
      // Hand must not have a parent in the Hierarchy view.
      pointer1 = GameObject.Find("marker1/pointer1");

      // This returns the GameObject named Hand,
      // which is a child of Arm > Monster.
      // Monster must not have a parent in the Hierarchy view.
      pointer2 = GameObject.Find("marker1/pointer2");

      backpack = GameObject.Find("marker1/Noti/bkpk");

      diary = GameObject.Find("marker1/Noti/diary");

      report = GameObject.Find("marker1/Noti/rpt");

  }
  void Update(){
    if (pointer.activeSelf == false && pointer1.activeSelf == false && pointer2.activeSelf == false){

      if(backpack.activeSelf == false && diary.activeSelf == false && report.activeSelf == false){
        Debug.Log("All items were completed!");
        cong.SetActive(true);
      }



    }
  }

/*  void Update(){


    if(pointer.activeSelf && pointer1.activeSelf && pointer2.activeSelf ){
      Debug.Log("You still need to find the items! ");
    }

    else{
      Debug.Log("All items were completed!");
      cong.SetActive(true);
    }

  } */

}
