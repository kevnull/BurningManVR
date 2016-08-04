using UnityEngine;
using System.Collections;

public class createBurner : MonoBehaviour {

    public Transform burner;
	// Use this for initialization
 	void Start () {
        for (int i = 0; i < 100; i++)
        {
          //  Instantiate(burner, new Vector3(Random.value*500 -300, 0, Random.value * 500 -300), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
