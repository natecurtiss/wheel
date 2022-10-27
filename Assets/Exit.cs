using UnityEngine;

    class Exit : MonoBehaviour
    {
        [SerializeField] KeyCode _key = KeyCode.Escape;
        
        void Update()
        {
            if (Input.GetKeyDown(_key))
                Application.Quit();
        }
    }
