using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollController : MonoBehaviour
{
    public float SpeedBoll = 1.0F;
    public float DamageBoll = 2.0F;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        //MoveBoll();

        DirectionBoll();
    }



    private void MoveBoll()
    {
        transform.position += new Vector3(SpeedBoll, 0, 0) * Time.deltaTime;
    }

    private void DirectionBoll()
    {
        transform.Translate(SpeedBoll * Time.deltaTime * Vector3.right);

    }
        

}

