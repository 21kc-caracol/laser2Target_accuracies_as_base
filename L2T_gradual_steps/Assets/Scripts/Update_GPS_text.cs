﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_GPS_text : MonoBehaviour
{
    public Text latitude_text;
    public Text longitude_text;
    public Text alt_text;
    public Text horizontal_accuracy_text;
    public Text vertical_accuracy_text;


    void Update()
    {       
        latitude_text.text = "my Lat: " + GPS.Instance.latitude.ToString();
        longitude_text.text = "my Longi: " + GPS.Instance.longitude.ToString();
        alt_text.text = "my Alt: " + GPS.Instance.altitude.ToString();
        horizontal_accuracy_text.text = "my Horizon acc: " + (String.Format("{0:0.00}", GPS.Instance.horizontal_accuracy)).ToString();
        vertical_accuracy_text.text = "my Vertical acc: " + (String.Format("{0:0.00}", GPS.Instance.vertical_accuracy)).ToString();
    }



}
