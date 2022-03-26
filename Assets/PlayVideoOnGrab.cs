using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideoOnGrab : MonoBehaviour
{
    public GameObject videoObject;
    bool videoActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Book" && videoActive == false)
        {
            videoObject.SetActive(true);
            videoActive = true;
        }
    }

    public void PlayVideo()
    {
        videoObject.SetActive(true);
    }
}
