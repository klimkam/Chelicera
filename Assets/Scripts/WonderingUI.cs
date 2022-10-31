using UnityEngine;
using UnityEngine.AI;

public class WonderingUI : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _wonderColdown;
    [SerializeField] private float _wonderRadius;

    private float _coldown = 0f;
    private NavMeshAgent _navMeshAgent;

    private void Awake()
    {
        RegeneratePosition();
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        WalkToPosition();

        if (_coldown <= 0)
            RegeneratePosition();

        if (_coldown > 0)
            _coldown -= Time.deltaTime;
    }

    private void RegeneratePosition() {
        _coldown = _wonderRadius;

        Vector3 newWardingTarget = transform.position + new Vector3(Random.Range(0, _wonderRadius),0, Random.Range(0, _wonderRadius));
        _target.position = newWardingTarget;
    }

    private void WalkToPosition() {
        _navMeshAgent.destination = _target.position;
    }
}