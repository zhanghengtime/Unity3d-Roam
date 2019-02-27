using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class plane : MonoBehaviour
{
    private Rigidbody rigidbody;
    private VideoPlayer video;
    public VideoClip clips;
    // Start is called before the first frame update
    void Start()
    {
    
        video = GetComponent<VideoPlayer>();
        rigidbody = GetComponent<Rigidbody>();
        video.playOnAwake = false;
        video.clip = clips;
        video.Stop();
        video.isLooping = false;
      
    }
    void Prepared(VideoPlayer video)
    {
    }
    void OnTriggerEnter(Collider other)
    {
        video.Play();
    }
}
