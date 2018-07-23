using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Noise : MonoBehaviour {

    public Animator Prorogu_Noise;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Prorogu_Noise.SetBool("Noise_Start",true);
    }
}
