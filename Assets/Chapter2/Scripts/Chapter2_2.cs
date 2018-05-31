using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2_2 : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		Player p = new Player ();
		p.Attack ();
		p.Damage (p.GetPower ());
		p.Damage (p.GetPower ());
	}
}

public class Player
{
	private int hp = 100;
	private int power = 50;

	public void Attack ()
	{
		Debug.Log ("敵の攻撃力は" + this.power);
	}

	public void Damage (int damage)
	{
		this.hp -= damage;
		Debug.Log (damage + "を受けた");
		if (this.hp <= 0) {
			Debug.Log ("今のHPは" + this.hp + "。死んでしまった");
		} else {
			Debug.Log ("今のHPは" + this.hp);
		}
	}

	public int GetPower ()
	{
		return this.power;

	}
}
