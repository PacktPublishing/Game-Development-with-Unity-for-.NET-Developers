using UnityEngine;

public class AnimationParametersTest : MonoBehaviour
{
    [SerializeField] 
    private Animator _animator;
    [SerializeField] 
    private float _speedMultiplier;

    private void Start()
    {
        if (_animator == null)
        {
            _animator = GetComponent<Animator>();
        }

        _animator.SetFloat("SpeedMultiplier", _speedMultiplier);
    }

    private void Update()
    {
        bool canRun = Input.GetKey(KeyCode.R);
        _animator.SetBool("Run", canRun);
    }
}
