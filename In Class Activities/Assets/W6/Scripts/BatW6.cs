using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    public GameObject player;
    // public float distance;

    private bool isChasing = false;
    void Start()
    {
        // StartPlayerChase();
    }

    void Update()
    {
        // distance = (transform.position - player.transform.position).magnitude;
        if(isChasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    public void StartPlayerChase()
    {
        isChasing = true;
    }
    public void StopPlayerChase()
    {
        isChasing = false;
    }
}
