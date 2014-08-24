using UnityEngine;
using System.Collections;

public class Passenger : MonoBehaviour {

	public int Id { get; set; }
	public Airport AirportFrom { get; set; }
	public Airport AirportTo { get; set; }

	public Passenger(int id, Airport from, Airport to)
	{
		Id = id;
		AirportFrom = from;
		AirportTo = to;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
