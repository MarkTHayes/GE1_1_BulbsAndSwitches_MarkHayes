using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour {

    public Animator bulbAnimator;

    public SwitchController manualSwitch;
    public SwitchController autoSwitch;

    

	// Use this for initialization
	void Start () {

        bulbAnimator = gameObject.GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {


        if (autoSwitch.switchOff == false || manualSwitch.switchOff == false)
        {

            bulbAnimator.SetBool("BulbOn", true);
            
        }
        else if (autoSwitch.switchOff && manualSwitch.switchOff)
        {

            bulbAnimator.SetBool("BulbOn", false);

        }



    }
}
