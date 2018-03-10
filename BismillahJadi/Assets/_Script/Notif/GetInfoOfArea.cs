using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfoOfArea : MonoBehaviour {

	// Use this for initialization
	public static string getInfo(string name)
    {
        if (name == GameObject.Find("LVL1").name)
        {
            return "ini Level 1";
        }
        else if (name == GameObject.Find("LVL2").name)
        {
            return "INI level 2";
        }
        else if (name == GameObject.Find("LVL3").name)
        {
            return "ini level 3";
        }
        else
            return null;
    }

}