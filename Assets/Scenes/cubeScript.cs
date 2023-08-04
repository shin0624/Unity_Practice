using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bigsize()
    {
        //x,y,z모든 방향에 대해서 크기를 3배
        this.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
    }
}
