using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject score_object ;
    public Text ScoreText;
    private int score ;

    // Use this for initialization
    void Start()
    {   //シーン中のScoreTextオブジェクトを取得
        this.score_object = GameObject.Find("ScoreText");

        // オブジェクトからTextコンポーネントを取得
        ScoreText= score_object.GetComponent<Text>();

    }



    // Update is called once per frame
    void Update()
    {
    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        // タグによって点数を変える
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 1;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 10;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 50;
        }

        // テキストの表示を入れ替える
        ScoreText.text = string.Format("Score:{0}", this.score);
          //ScoreText.text = this.score.ToString();
    }


}
