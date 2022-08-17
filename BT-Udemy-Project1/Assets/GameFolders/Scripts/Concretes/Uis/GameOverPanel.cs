using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BTUdemyProject1.Managers;

namespace BTUdemyProject1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClicked()
        {
            GameManager.Instance.LoadManu();
        }
    }
}