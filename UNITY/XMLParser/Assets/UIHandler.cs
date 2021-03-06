﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Image[] ColorFields;
    [SerializeField] private TMP_Text[] nameFields;

    [SerializeField] private TMP_Text lastRefresh;

    private Color32 Red = new Color32(255,93,93,255);
    private Color32 Green = new Color32(93,255,93,255);

    public void DisplayData(List<string> access, List<string> color, List<string> name)
    {
        //Check access status

        for (int i = 0; i < ColorFields.Length; i++)
        {
            switch (color[i])
            {
                case "red":
                    ColorFields[i].color = Red;
                    break;
                case "green":
                    ColorFields[i].color = Green;
                    break;
            }

            switch (access[i])
            {
                case "ok":
                    nameFields[i].text = name[i];
                    break;

                default:
                    ColorFields[i].color = Color.gray;
                    nameFields[i].text = name[i] + "\n Error: \n" + access[i];
                    break;
            }
            
        }

        //Set current time as last refresh
        lastRefresh.text = "Last Check: " + System.DateTime.Now.ToShortTimeString();

    }

    public void LoadingData()
    {
        for (int i = 0; i < ColorFields.Length; i++)
        {
            ColorFields[i].color = Color.grey;
            nameFields[i].text = "Loading...";
        }
    }
}
