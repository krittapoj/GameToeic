using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject currentForm;
    private bool moving;
    private bool finish;
    private float StarPosX;
    private float StarPosY;

    private Vector3 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(finish == false)
        {
             if(moving)
            {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3 (mousePos.x - StarPosX, mousePos.y - StarPosY, gameObject.transform.localPosition.z);
            }
        }
       
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown (0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            StarPosX = mousePos.x - this.transform.localPosition.x;
            StarPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }
    private void OnMouseUp()
    {
        moving = false;

        if(Mathf.Abs(this.transform.localPosition.x - currentForm.transform.localPosition.x) <= 0.5f && 
            Mathf.Abs(this.transform.localPosition.y - currentForm.transform.localPosition.y) <= 0.5f)

        {
            this.transform.position = new Vector3 (currentForm.transform.position.x, currentForm.transform.position.y, currentForm.transform.position.z);
            finish = true;
            
            
            GameObject.Find("PointsHendler").GetComponent<Wingame>().Addpoints();
        }
        else
        {
            this.transform.localPosition = new Vector3 (resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
