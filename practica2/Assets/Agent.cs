using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;
	public Transform Originpoint;
	

	void Start()
	{
		maxSpeed = 5f;
		maxSteer = 5f;
		
	}

	void Update()
	{		
		if(Vector3.Distance(Originpoint.position , transform.position) > 2){
			velocity += SteeringBehaviours.Seek(this, Originpoint, 100);
			transform.position += velocity* Time.deltaTime;	
		}

	    velocity += SteeringBehaviours.Seek(this, target, 100);
		transform.position += velocity* Time.deltaTime;		
	}
}
