using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;
    
     public void Update()
    {
            transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed*Time.deltaTime);
    }
    
    public void Notchase()
    {
        enabled = false;
    }

    public void Chase()
    {
        enabled = true;
    }
    
   
}

