using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
    static public bool notifON = false;
    GameObject notif, dialogBox;
    void Start()
    {
        dialogBox = GameObject.FindGameObjectWithTag("dialogBox");
        notif = GameObject.Find("Notif");
    }
    void Update()
    {
        if (Input.GetButtonDown("GetInpo") && notifON == true)
        {
            dialogBox.GetComponent<DialogBoxController>().openDialogBox();
            dialogBox.GetComponent<DialogBoxController>().showDialogBox(GetInfoOfArea.getInfo(transform.name));
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
            notif.GetComponent<NotifController>().OffNotifBaloon();
            notifON = false;
            dialogBox.GetComponent<DialogBoxController>().closeDialogBox();
            Debug.LogWarning(transform.name);
        }
    }
}
