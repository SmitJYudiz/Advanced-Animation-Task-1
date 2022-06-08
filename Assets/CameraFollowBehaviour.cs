using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour : MonoBehaviour
{
    public GameObject playerObject;
    Vector3 offset = new Vector3(0.3f,5f,-7f);
    Vector3 differenceVector;  //= new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //differenceVector = playerObject.transform.position - transform.position;
       // transform.position += differenceVector;
        //transform.position = playerObject.transform.position - transform.position + offset;
        transform.position = playerObject.transform.position+ offset;

    }
}
