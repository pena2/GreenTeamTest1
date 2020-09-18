using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<GameObject> MyGameObjects;

    public int _MyNumber = 0;

    public void SetMyObject(int rindex) {
        GameObject tt = Instantiate(MyGameObjects[rindex], this.transform );
        // tt.transform.position = this.transform.position;
        // tt.transform.parent = this.transform;
        // MyGameObjects[rindex].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
