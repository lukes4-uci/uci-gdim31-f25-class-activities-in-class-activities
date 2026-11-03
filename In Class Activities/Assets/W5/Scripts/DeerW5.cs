using UnityEditor.UI;
using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    private NavMeshAgent _deerMover;

    private void Start()
    {
        _deerMover = this.gameObject.GetComponent<NavMeshAgent>();
        _deerMover.SetDestination(_targetTransform.position);
    }
}