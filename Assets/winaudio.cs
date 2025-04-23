using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winaudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.musicSource.Stop();
        SoundManager.Instance.PlayMusic("Acceptance");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
