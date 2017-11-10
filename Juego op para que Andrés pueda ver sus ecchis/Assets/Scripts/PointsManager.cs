using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour {


    public static int points = 0;

    public Text PointText;


    // Use this for initialization
    void Start() {
        UpdatePoints(points);
    }

    void UpdatePoints(int points)

    {
        PointText.text = " " + points;
    }

	

    public void IncreasePoints()
    {
        points ++;
        UpdatePoints(points);
    }
}
