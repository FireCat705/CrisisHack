using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class ClickAndPlaceUIImage : MonoBehaviour
{
    public GameObject selectedImg0;
    public GameObject selectedImg1;
    public GameObject selectedImg2;
    public GameObject selectedImg3;
    public GameObject selectedImg4;
    public GameObject selectedImg5;
    public GameObject selectedImg6;
    public GameObject selectedImg7;
    public GameObject selectedImg8;

    public GameObject Chat;
    

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
    public void clickDrop(int index)
    {
        switch (index)
        {
            case 0:
                imgSelected = true;
                selectedImg = selectedImg0; break;
            case 1:
                imgSelected = true;
                selectedImg = selectedImg1;  break;
            case 2:
                imgSelected = true;
                selectedImg = selectedImg2 ; break;
            case 3:
                imgSelected = true;
                selectedImg = selectedImg3; break;
            case 4:
                imgSelected = true;
                selectedImg = selectedImg4; break;
            case 5:
                imgSelected = true;
                selectedImg = selectedImg5; break;
            case 6:
                imgSelected = true;
                selectedImg = selectedImg6; break;
            case 7:
                imgSelected = true;
                selectedImg = selectedImg7; break;
            case 8:
                imgSelected = true;
                selectedImg = selectedImg8; break;
        }

    }

    /*public void clickDrop0()
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
    public void clickDrop5()
    {
        Debug.Log("Hellow");
        imgSelected = true;
        selectedImg = selectedImg0;

    }
    public void clickDrop6()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }
    public void clickDrop7()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }
    public void clickDrop8()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }
    public void clickDrop9()
    {
        Debug.Log("Hellow");
        imgSelected = true;

    }*/


}