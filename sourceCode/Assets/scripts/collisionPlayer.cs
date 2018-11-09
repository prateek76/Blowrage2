using UnityEngine;

public class collisionPlayer : MonoBehaviour {

    public playerMove movement;
    // public GameManager gameManager; //don't do this better is to find

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
