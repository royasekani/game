using UnityEngine;
using System.Collections;

public class toliddoshman : MonoBehaviour {
    public float zaman;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        zaman += 1 * Time.deltaTime;
        if (zaman >= 3)
        {
            Instantiate(prefab, transform.position = new Vector3(Random.Range(-2.5f, +2.5f), transform.position.y, 0), Quaternion.identity);
            zaman = 0;
        }
	}
}
