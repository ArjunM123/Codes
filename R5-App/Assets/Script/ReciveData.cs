using System;
using System.Net;
using System.IO;
using UnityEngine;

public class ReciveData : MonoBehaviour
{
    const string URL = "https://personalpedometer.tk/api/data";
    string[] data;

    void Update()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
        request.Method = "GET";

        var webResponse = request.GetResponse();
        var webStream = webResponse.GetResponseStream();
        var responseReader = new StreamReader(webStream);
        var response = responseReader.ReadToEnd();
        //print("Response: " + response);
        responseReader.Close();

        for (int i = 0; i < response.Length; i++) 
        {
            
        }
    }
    
    string[] userData()
}

