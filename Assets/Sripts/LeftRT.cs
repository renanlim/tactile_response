using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class LeftRT : MonoBehaviour
{
    public AudioSource alarme;
    public Rigidbody rb;
    private bool isColliding=false;
    //private float vibrationDuration = 0.2f; // Duração da vibração em segundos

    void Update()
    {
        if (isColliding){
            //StartVibration(XRNode.LeftHand);
            //OVRInput.SetControllerVibration(1.0f, 1.0f, OVRInput.Controller.RTouch);
            print("Esta tocando");
            
        } else
        {
            
            print("Parou de tocar");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("parede"))
        {   
            isColliding=true;
            alarme.Play();
            //StartVibration(XRNode.LeftHand);
            //OVRInput.SetControllerVibration(1.0f, 1.0f, OVRInput.Controller.RTouch);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("parede"))
        {
            isColliding=false;
            alarme.Stop();
            //StopVibration(XRNode.LeftHand);
            //OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
        }
    }

    /*  private void StartVibration(XRNode controllerNode)
    {
        OVRHapticsClip clip = new OVRHapticsClip();
        clip.WriteSample(new byte[8], 8); // Gerar uma amostra de vibração
        OVRHaptics.Channels[controllerNode].Preempt(clip);
        OVRHaptics.Channels[controllerNode].Mix(clip);
        OVRHaptics.Channels[controllerNode].EnableVibration();
        Invoke("StopVibration", vibrationDuration); // Parar a vibração após a duração definida
    }

    private void StopVibration(XRNode controllerNode)
    {
        OVRHaptics.Channels[controllerNode].Clear();
        OVRHaptics.Channels[controllerNode].DisableVibration();
    } */
}
