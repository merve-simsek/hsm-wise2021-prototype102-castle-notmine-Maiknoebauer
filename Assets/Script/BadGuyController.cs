using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyController : MonoBehaviour
{
    public int Damage = 1;
    public int CurrentHealth=1;
    
    public AudioSource _pain;
    
    public Rigidbody _rigidBody;

    private void Start()
    {
        _pain = GetComponent<AudioSource>();
        Destroy(gameObject, 10f);
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        _pain.Play();
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
