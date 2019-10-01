using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    //Agent 
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;
    Vector3 steer = Vector3.zero;

    public float maxSpeed = 10;
    public float maxSteer = 10;


    //..
    Transform target;
    Transform Area;

    void Update()
    {
        target = GameObject.Find("Target").transform;
        Area = GameObject.Find("Area").transform;

        float dist = Vector3.Distance(Area.position , transform.position);

        //desired
        desired = -(target.position - transform.position).normalized * maxSpeed;
        //steer
        steer = Vector3.ClampMagnitude(desired - velocity , maxSteer);
        //velocity
        velocity += steer * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if(transform.position.x  <= -12.00 || transform.position.x  >= 12.00 || transform.position.y  <= -5.00 || transform.position.y  >= 5.00 ){
           Debug.Log("PERDISTE");
           Destroy(gameObject);
        }

        //print(Vector3.Distance(Area.position , transform.position));

        if(dist <=1.5 ){
            Debug.Log("GANASTE");
            Destroy(gameObject);
        }

        
    }
}
