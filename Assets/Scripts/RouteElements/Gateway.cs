using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Gateway : MonoBehaviour
{
    private Animator _animator;
    private int _open = Animator.StringToHash("Open");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.Play(_open);
    }
}
