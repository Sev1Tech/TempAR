using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

public class UpdateHumidity : MonoBehaviour
{
    public string pressureURL = "http://52.21.6.62:8181/sensorhub/ngfrsos?service=SOS&version=2.0&request=GetResult&offering=urn:osh:sensor:sensehat:2b4693cf-sos&observedProperty=http://sensorml.com/ont/swe/property/Humidity&temporalFilter=phenomenonTime,now&responseFormat=application/json";
    private string myData = "";

    // Use this for initialization
    void Start()
    {
        Debug.Log("Target detected.");

    }

    // Update is called once per frame
    void Update()
    {
        double value = 0.0;

        Coroutine routine = StartCoroutine(GetRESTData());

        if (myData.Length == 0)
        {
            GetComponent<TextMesh>().text = "H: " + "No Data";
        }
        else
        {
            JSONObject json = new JSONObject(myData.Substring(3, myData.Length - 3));   // JSONObject works now

            double humidity = Convert.ToDouble(json[0].ToString());

            GetComponent<TextMesh>().text = "Humidity \n" + humidity.ToString("0.00") + "%";

            // TODO: We would need 3 seperate labels to color code the individual items.

            if (humidity > 37.0)
                GetComponent<TextMesh>().color = Color.red;
            else if (humidity < 37 && value > 30)
                GetComponent<TextMesh>().color = Color.magenta;
            else if (humidity < 30 && value > 25)
                GetComponent<TextMesh>().color = Color.yellow;
            else if (humidity < 25)
                GetComponent<TextMesh>().color = Color.green;
        }
    }

    IEnumerator GetRESTData()
    {
        UnityWebRequest www = UnityWebRequest.Get(pressureURL);
        www.downloadHandler = new DownloadHandlerBuffer();
        yield return www.SendWebRequest();
        while (!www.downloadHandler.isDone)
            yield return new WaitForEndOfFrame();


        myData = www.downloadHandler.text;


        yield break;
    }
}