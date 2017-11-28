using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Target detected.");
	}
	
	// Update is called once per frame
	void Update () {
        // Changes text component value to current data.
        GetComponent<TextMesh>().text = GetData();
    }

    string GetData()
    {
        System.Random rand = new System.Random();
        string mockData = System.DateTime.Now.Second.ToString();
        // mockData = (rand.Next(70, 95)).ToString();
        // System.Threading.Thread.Sleep(500);

        return mockData;
    }
}
