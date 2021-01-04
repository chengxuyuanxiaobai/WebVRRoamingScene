using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebXR;

public class WebVRUnityButonEvent : MonoBehaviour
{
    Button enterVR;
    AudioSource audioSource;
     void Start()
    {
        enterVR = transform.Find("EnterVR").GetComponent<Button>();
            enterVR.onClick.AddListener(OnClickEnterVR);
        audioSource = transform.Find("AudioPlayer").GetComponent<AudioSource>();
    }
    private void OnClickEnterVR()
    {
        Debug.Log("Unity OnClickEnterVR");
#if UNITY_EDITOR
        // Nothing to do
#elif UNITY_WEBGL
        WebXRUI.ClickButtonXRElementEvent("ChangeVR");           
#endif
        enterVR.enabled = false;  

    }
    public void OnClickToggle(bool isOn)
    {
        if (isOn)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }       
    }
}
