using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelSelect : MonoBehaviour
{
    public GameObject levelItemPrefab;
    public Transform contentHolder;

    private List<Level> levels = new List<Level>
    {
        new Level("Level1", "Sprites/Level1"),
        new Level("Level2", "Sprites/Level2"),
        new Level("Level3", "Sprites/Level3"),
    };

    void Start()
    {
        foreach (var level in levels)
        {

            GameObject item = Instantiate(levelItemPrefab, contentHolder);
            item.transform.Find("Image").GetComponent<Image>().sprite = Resources.Load<Sprite>(level.ImagePath);
            item.transform.Find("Text").GetComponent<Text>().text = level.LevelToLoad;

            Button btn = item.transform.Find("PlayButton").GetComponent<Button>();
            string levelToLoad = level.LevelToLoad;
            btn.onClick.AddListener(() => SceneManager.LoadScene(levelToLoad));
        }
    }

    public class Level
    {
        public string LevelToLoad;
        public string ImagePath;

        public Level(string level, string imagePath)
        {
            LevelToLoad = level;
            ImagePath = imagePath;
        }
    }
}
