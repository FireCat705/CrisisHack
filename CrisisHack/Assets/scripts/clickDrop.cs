using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using Unity.VisualScripting;

public class ClickAndPlaceUIImage : MonoBehaviour
{
    public GameObject selectedImg0;
    //public GameObject selectedImg1;
    //public GameObject selectedImg2;
    //public GameObject selectedImg3;
    //public GameObject selectedImg4;

    bool imgSelected = false;
    GameObject selectedImg;
    Vector3 mousePos;
    Vector3 objectPos;
    
    

    public void Update()
    {
        bool click = Input.GetMouseButtonDown(0);
        if (click == true && imgSelected == true) // Left mouse button clicked
        {
            
            Vector3 mouseScreenPos = Input.mousePosition;
            
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
            
            mouseWorldPos.z = 0f;
            
            Instantiate(selectedImg, mouseWorldPos, Quaternion.identity);
            imgSelected = false;
        }
    }
    public void clickDrop0()
    {
        Debug.Log("Hellow");
        imgSelected = true;
        selectedImg = selectedImg0;
        
    }
    public void clickDrop1()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }
    public void clickDrop2()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }
    public void clickDrop3()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }
    public void clickDrop4()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }


}