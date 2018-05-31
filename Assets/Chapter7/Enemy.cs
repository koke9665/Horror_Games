using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

	public Transform target;
	static Vector3 pos;
	private Animator animator;

	float agentToPatroldistance;
	float agentToTargetdistance;

	UnityEngine.AI.NavMeshAgent agent;

	void Awake ()
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		animator = GetComponent<Animator> ();
	}

	void Update ()
	{
		agentToPatroldistance = Vector3.Distance (this.agent.transform.position, pos);
		agentToTargetdistance = Vector3.Distance (this.agent.transform.position, target.transform.position);
		DoTracking ();
	}

	public void  DoTracking ()
	{
		pos = target.position; 
		agent.SetDestination (pos);
	}
}
