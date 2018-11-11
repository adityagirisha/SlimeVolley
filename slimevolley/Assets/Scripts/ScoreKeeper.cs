using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper S;

    
    
    public Text r;
    public Text b;
    public int redScore =0;
    public int blueScore =0;

    void Awake()
    {
        S = this;
    }

    public void IncrementVisualScoreRed()
    {
        if (redScore == 5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }

    public void IncrementVisualScoreBlue()
    {
        if (blueScore == 5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        r.text = redScore.ToString();
        b.text = blueScore.ToString();
    }
}
