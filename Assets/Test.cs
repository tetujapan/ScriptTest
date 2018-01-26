using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{

	//int型の変数mpを宣言し、53で初期化してください
	private int mp = 53;

	//mpを消費して魔法攻撃をするMagic関数を作ってください
	public void Magic(){

		//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
		if(mp >= 5){
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp +"。");

		}else{
			Debug.Log ("MPが足りないため魔法が使えない。");
		}

	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//■課題：配列を宣言して出力しましょう

		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] five = { 10, 20, 30, 40, 50 };

		//配列の各要素の値を順番に表示してください
		Debug.Log (five[0]);
		Debug.Log (five[1]);
		Debug.Log (five[2]);
		Debug.Log (five[3]);
		Debug.Log (five[4]);

		int count = 4;

		//for文を使い、配列の各要素の値を逆順に表示してください
		for (int i = 0; i < five.Length; i++) {
			
			Debug.Log (five [count]);
			count--;

		}

		//■発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう

		Boss lastboss = new Boss ();

		//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
		for(int x = 0; x <= 10; x++){
		
			lastboss.Magic ();
		}

	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
