using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfoOfArea : MonoBehaviour
{
    public static string getInfo(string name)
    {
        if (name == "LVL1")
        {
            return "ini Level 1";
        }
        else if (name == "LVL2")
        {
            return "INI level 2";
        }
        else if (name == "LVL3")
        {
            return "ini level 3";
        }
        else
        {
            return null;
        }

    }
}