using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {


    public Image health;

    float healthpoints = 0f;
    float maxHealt = 100f;

	// Use this for initialization
	void Start () {

        healthpoints = maxHealt;
		
	}
    public void TakeDamage(float cantidad)
    {
        healthpoints = Mathf.Clamp(healthpoints - cantidad, 0f, maxHealt);//no puede ser menor 0 y mayor del maximo
        health.transform.localScale = new Vector2(healthpoints / maxHealt, 1);// x e y pero no tira me cago en to



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
