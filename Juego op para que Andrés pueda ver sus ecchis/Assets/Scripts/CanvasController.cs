using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {


    [Range(0f,0.20f)]
    public float parallaxSpeed = 0.20f;
    public RawImage background;
    public RawImage platform;
    //public Text pointsText;

    //private int points = 0;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        background.uvRect = new Rect(background.uvRect.x + finalSpeed,0f,1f,1f);
        platform.uvRect = new Rect(platform.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);

    }

    /*public void IncreasePoints()
    {
         points += 10;
         pointsText.text = points.ToString();
    }
    */
}
