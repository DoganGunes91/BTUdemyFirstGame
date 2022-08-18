using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BTUdemyProject1.Abstracts.Utilities;
using BTUdemyProject1.Managers;

namespace BTUdemyProject1.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;

        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameObject(this);
        }        

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }

        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }

        public void LoadLevelScene(int LevelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(LevelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadManu()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}