using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimizer : MonoBehaviour
{
	public GameObject objek;
    // Start is called before the first frame update
    

    void OnBecameVisible()
    {
    	objek.SetActive(true);
    }

    void OnBecameInvisible()
    {
    	objek.SetActive(false);
    }
}
