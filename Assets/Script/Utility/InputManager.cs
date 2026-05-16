using UnityEngine;

namespace Script
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager Instance;
    
        public PlayerInput Controls { get; private set; }
    
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
    
                Controls = new PlayerInput();
                Controls.Enable();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
