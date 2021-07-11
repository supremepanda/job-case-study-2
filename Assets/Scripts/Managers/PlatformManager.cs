using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class PlatformManager : MonoBehaviour
    {
        public static PlatformManager Instance;
    
        public Platform platform;
    
        private void Start()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            Instance = this;
            InitializePlatformManager();
        }

        private void Update()
        {
#if UNITY_EDITOR
            if (EditorApplication.isRemoteConnected)
            {
                platform = Platform.Mobile;
            }                
#endif
        }

        private void InitializePlatformManager()
        {
#if UNITY_EDITOR
            platform = Platform.Editor;
#else
            platform = Platfor.Mobile;
#endif
        }
    }
}
