using UnityEngine;

public class followPlayer : MonoBehaviour {

    public Transform player;
	public Vector3 offset;//stores 3 floats
	// Update is called once per frame
	void Update () {
        //Debug.Log(player.position);
        transform.position = player.position + offset; //this is transform of current object //camera
	}
}
