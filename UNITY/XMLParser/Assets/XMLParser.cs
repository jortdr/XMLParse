using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class XMLParser : MonoBehaviour
{
    private XmlTextReader reader = new XmlTextReader("http://lodewijk.edgetech.nl:3343/monitor");
    private UIHandler UI;


    public List<string> accessesValue = new List<string>();

    public List<string> colorsValue = new List<string>();

    public List<string> nameValue = new List<string>();

    private void Start()
    {
        UI = GetComponent<UIHandler>();
        LoadFromURL();

    }
    void LoadFromURL()
    {
        Debug.Log(System.DateTime.Now);


        //Inspect nodes
        while (reader.Read())
        {
            while (reader.MoveToNextAttribute())
            {
                // Read the attributes.
                Debug.Log("NAME: " + reader.Name + " | VALUE: " + reader.Value);

                switch (reader.Name)
                {
                    case "access":
                        accessesValue.Add(reader.Value);
                        break;

                    case "color":
                        colorsValue.Add(reader.Value);
                        break;

                    case "name":
                        nameValue.Add(reader.Value);
                        break;
                }
            }
        }

        UI.DisplayData(accessesValue, colorsValue, nameValue);

    }


    public void RefreshButton()
    {
        UI.LoadingData();
        LoadFromURL();


    }
}




