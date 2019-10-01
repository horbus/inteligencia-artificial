using UnityEngine;

public class Agent2 : SBAgent
{
	public Transform target;
	public Transform Originpoint;
	public float areaCubo;
	

	void Start()
	{
		maxSpeed = 5f;
		maxSteer = 10f;
		areaCubo = 2f;
		
	}

	void Update()
	{		
		if(transform.position.x > areaCubo || transform.position.x < -areaCubo || transform.position.y > areaCubo || transform.position.y < -areaCubo){
			velocity += SteeringBehaviours.Seek(this, Originpoint, 100);
			transform.position += velocity* Time.deltaTime;	
		}
	    velocity += SteeringBehaviours.Seek(this, target, 100);
		transform.position += velocity* Time.deltaTime;		
	}
}
