using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BTUdemyProject1.Managers;
using System;

namespace BTUdemyProject1.Uis
{
    public class WinObject : MonoBehaviour
    {
        [SerializeField] GameObject _winPanel;

        private void Awake()
        {
            if (_winPanel.activeSelf)
            {
                _winPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }

        private void HandleOnMissionSucced()
        {
            if (!_winPanel.activeSelf)
            {
                _winPanel.SetActive(true);
            }
        }
    }
}