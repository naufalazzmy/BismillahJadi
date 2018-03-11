using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifController : MonoBehaviour {

    public void Start()
    {
        transform.GetComponent<MeshRenderer>().enabled = false;
    }
    public void OffNotifBaloon()
    {
        transform.GetComponent<MeshRenderer>().enabled = false;
    }
    public void OnNotifBaloon()
    {
        transform.GetComponent<MeshRenderer>().enabled = true;
    }

}
