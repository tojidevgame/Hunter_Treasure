using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ListExplorerScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Explorer Manager")]
    [SerializeField] private ExplorerManager explorerManager;
    [Header("Explorer Display Data")]
    [SerializeField] private TMP_Text explorerName;
    [SerializeField] private Image explorerImage;

    [Header("Explorer Sidebar List")]
    [SerializeField] private GameObject explorerItem;
    [SerializeField] private GameObject listExplorerContainer;



    ExplorerBaseInfo[] explorerBaseInfos;
    private int currentExplorerIndex = 0;

    private void Awake()
    {
        // Get all explorer base info
        explorerBaseInfos = explorerManager.GetAllExplorerBaseInfo();
        // Display all explorer base info
        //foreach (ExplorerBaseInfo explorerBaseInfo in explorerBaseInfos)
        //{
        //    DisplayExplorer(explorerBaseInfo);
        //}
        Debug.Log(explorerBaseInfos.Length);
        DisplayExplorer(explorerBaseInfos[0]);

        for (int i = 0; i < explorerBaseInfos.Length; i++)
        {
            GameObject explorerItemInstance = Instantiate(explorerItem, listExplorerContainer.transform);
            Image characterImage = explorerItemInstance.GetComponentInChildren<Image>();
            TMP_Text characterTitle = explorerItemInstance.GetComponentInChildren<TMP_Text>();
            int index = i;
            explorerItemInstance.GetComponent<Button>()?.onClick.AddListener(() => {
                currentExplorerIndex = index;
                Debug.Log("Current explorer index: " + currentExplorerIndex);
                DisplayExplorer(explorerBaseInfos[currentExplorerIndex]);
                });
            characterImage.sprite = explorerBaseInfos[i].ImageThumbnail;
            characterTitle.text = explorerBaseInfos[i].Name;
        }

    }

    public void DisplayExplorer(ExplorerBaseInfo _explorer)
    {
        explorerName.text = _explorer.Name;
        explorerImage.sprite = _explorer.ImageThumbnail;
    }
    public void ChangeExplorer(int _change)
    {
        ConsoleLog.Log("Change explorer: " + _change);
        currentExplorerIndex += _change;
        if (currentExplorerIndex < 0)
        {
            currentExplorerIndex = explorerBaseInfos.Length - 1;
        }
        else if (currentExplorerIndex > explorerBaseInfos.Length - 1)
        {
            currentExplorerIndex = 0;
        }
        if (explorerBaseInfos != null)
        {
            DisplayExplorer(explorerBaseInfos[currentExplorerIndex]);
        }
    }

    public ExplorerBaseInfo GetCurrentExplorerBaseInfo()
    {
        return explorerBaseInfos[currentExplorerIndex];
    }

}
