//using UnityEngine;
//using CloudOnce;
//using System.Collections;


//public class CloudOnceServices : MonoBehaviour
//{
//    // Start is called before the first frame update
//    public static CloudOnceServices instance;
//    private void Awake()
//    {
//        TestSingelton();
//    }
//    private void TestSingelton()
//    {
//        if(instance != null) { Destroy(gameObject); return; }
//        instance = this;
//        DontDestroyOnLoad(gameObject);
//    }

//    // Update is called once per frame
//    public void SubmitScoreToLeaderboard(int score)
//    {
//       // Leaderboards.highScore.SubmitScore(score);
//    }
//}
