using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Reel : MonoBehaviour {
  private List<GameObject> symbols = new List<GameObject>();

	void Start () {
    for (int i = 0; i < 20; ++i) {
      GameObject symbol1r = Resources.Load("symbol1") as GameObject;
      GameObject symbol1 = Instantiate(symbol1r, new Vector3(0, i * 1, 0), Quaternion.identity) as GameObject;
      symbols.Add(symbol1);

      symbol1.transform.parent = transform;
    }
	}
	
	void Update () {
	}
}
