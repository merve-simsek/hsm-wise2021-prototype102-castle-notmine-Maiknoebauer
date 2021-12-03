using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int Damage = 1 ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other) 
    { 
        Destroy(gameObject);
        Destroy(other.gameObject); 

    if (other.CompareTag("GoodGuy"))
        {
            var goodguyController = other.GetComponent<GoodGuyController>();
            goodguyController.TakeDamage(Damage);
            Destroy(gameObject);
            ScoreScript.scoreValue = 0;
        }
        
        if (other.CompareTag("BadGuy"))
        {
            ScoreScript.scoreValue += 1;
            var badguyController = other.GetComponent<BadGuyController>();
            badguyController.TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
