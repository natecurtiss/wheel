using UnityEngine;

    class Wheel : MonoBehaviour
    {
        [SerializeField] Rigidbody2D _wheel;
        [SerializeField] float _spin = 100f;
        bool IsSpinning => _wheel.angularVelocity >= 1f;

        public void Spin()
        {
            if (IsSpinning)
                return;
            _wheel.AddTorque(_spin * _wheel.mass);
        }
    }
