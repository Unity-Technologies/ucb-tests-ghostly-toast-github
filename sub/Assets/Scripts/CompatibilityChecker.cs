using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompatibilityChecker : MonoBehaviour {

    public Canvas AddressablesTestMenu;
    public GameObject IncompatibleMessage;

    // Use this for initialization
    void Start ()
    {

#if UNITY_2018_3_OR_NEWER
        Debug.Log("Addressables is compatible with this version of the editor.");
        AddressablesTestMenu.enabled = true;
#else
    Debug.Log("Addressables is not compatible with this version of the editor.");
        AddressablesTestMenu.enabled = false;
        IncompatibleMessage.SetActive(true);

#endif
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
