using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingame : MonoBehaviour
{
    private int pointsTowin;
    private int currentPoints;
    public GameObject Win;
    // Start is called before the first frame update
    void Start()
    {
        pointsTowin = Win.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsTowin)
        {
            transform.GetChild(0).gameObject.SetActive(true);

        }
    }

    public void Addpoints()
    {
        currentPoints++;
    }

}
