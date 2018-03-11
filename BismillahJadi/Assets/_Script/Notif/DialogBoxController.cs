using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBoxController : MonoBehaviour
{

    GameObject dialogBox;
    public Text dialogtext;
    // Use this for initialization
    void Start()
    {
        dialogBox = GameObject.FindGameObjectWithTag("dialogBox");
        dialogBox.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showDialogBox(string Tulisane)
    {
        dialogBox.SetActive(true);
        dialogtext.text = Tulisane;
    }
    public void closeDialogBox()
    {
        dialogBox.SetActive(false);
    }
    public void openDialogBox()
    {
        dialogBox.SetActive(true);
    }

}
