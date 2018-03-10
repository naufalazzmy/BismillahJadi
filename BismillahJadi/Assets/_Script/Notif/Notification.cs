using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
    GameObject notif;
    bool notifON = false;

    // Use this for initialization
    void Start()
    {
        notif = GameObject.Find("Notif");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("GetInpo")&& notifON==true)
        {
            Debug.LogWarning(GetInfoOfArea.getInfo(transform.name));
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            notif.GetComponent<NotifController>().OnNotifBaloon();
            notifON = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        {
            Debug.LogError("Berhasil, " + transform.name);
            notif.GetComponent<NotifController>().OffNotifBaloon();
            notifON = false;
        }
    }
}
