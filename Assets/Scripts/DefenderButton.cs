﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderButton : MonoBehaviour
{

	[SerializeField] Defender defenderPrefab;

	private void Start() {
		LabelButtonWithCost();
	}

	private void LabelButtonWithCost() {
		TextMeshProUGUI costText = GetComponentInChildren<TextMeshProUGUI>();
		if (!costText) {
			Debug.LogError(name + "has no cost text!");
		} else {
			costText.text = defenderPrefab.GetStarCost().ToString();  
		}
	}

	private void OnMouseDown() {
		var buttons = FindObjectsOfType<DefenderButton>();
		foreach(var button in buttons) {
			button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
		}
		GetComponent<SpriteRenderer>().color = Color.white;
		FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
	}
}
