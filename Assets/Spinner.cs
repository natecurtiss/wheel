using UnityEngine;
using UnityEngine.Events;

class Spinner : MonoBehaviour
{
    [SerializeField] UnityEvent _onSpin;
    [SerializeField] KeyCode _spinKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(_spinKey))
            _onSpin?.Invoke();
    }
}
