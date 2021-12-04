using UnityEngine;
using System.Collections;
 
public class FlashLight : MonoBehaviour {
    private Light myLight;
    public AudioSource clickSound;
     
     
    void Start ()
    {
        myLight = GetComponent<Light>();
    }
     
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.X))
        {
            myLight.enabled = !myLight.enabled;
            clickSound.Play();
        }
    }
}