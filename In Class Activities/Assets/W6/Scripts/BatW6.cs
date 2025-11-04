using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Transform _playerTransform;
    public void Stop_Chase()
    {
        enabled = false;
    }

    public void Start_Chase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }
    private void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, _playerTransform.position, speed * Time.deltaTime);
        
    }
}
