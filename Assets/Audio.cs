using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource, audioSource1, audioSource2, audioSource3, audioSource4,audioSource5;
    public Slider slider;
    public int kaisu;
    public void Awake()
    {

    }

     void Start()
    {
        audioSource.volume = 0f;
        audioSource3.volume = 0f;
        audioSource4.volume = 0f;
        audioSource5.volume = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&kaisu!=0)
        {
            audioSource2.Play();
            StartCoroutine(Load());
            kaisu--;
        }
        else if(audioSource1.isPlaying)
        {
            audioSource.volume = slider.value;
            audioSource3.volume = slider.value;
            audioSource4.volume = slider.value*0.2f;
            audioSource5.volume= slider.value*0.2f;

            float i = 1 - slider.value * 4;
            audioSource1.volume = i;
        }
     
    }
    IEnumerator Load()
    {
         yield return new WaitForSeconds(0.8f);
        audioSource1.Play();
    }
}