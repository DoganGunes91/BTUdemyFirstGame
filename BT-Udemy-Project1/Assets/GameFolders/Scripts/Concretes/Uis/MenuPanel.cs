using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BTUdemyProject1.Managers;

namespace BTUdemyProject1.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}

