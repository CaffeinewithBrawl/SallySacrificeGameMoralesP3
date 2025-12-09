using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject MenuPanel;
    private bool menuActivated;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && menuActivated)
        {
            Time.timeScale = 1;
            MenuPanel.SetActive(false);
            menuActivated = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && !menuActivated)
        {
            Time.timeScale = 0;
            MenuPanel.SetActive(true);
            menuActivated = true;
        }
    }
}
