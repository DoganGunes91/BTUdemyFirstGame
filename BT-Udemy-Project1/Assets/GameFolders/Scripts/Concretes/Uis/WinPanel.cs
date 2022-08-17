using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BTUdemyProject1.Managers;

namespace BTUdemyProject1.Uis
{
    public class WinPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);

        }
    }
}