using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ChainCheckZone : MonoBehaviour
{
    [SerializeField] private Chain _chain;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<Ball>(out Ball ball))
            _chain.CheckBallsCount();
    }
}
