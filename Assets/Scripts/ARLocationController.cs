using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ARLocationController : MonoBehaviour
{
    public TextMeshProUGUI status;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTrackingStarted()
    {
        status.text = "Tracking started...";
    }

    public void OnTrackingLost()
    {
        status.text = "Tracking lost...";
    }
}
