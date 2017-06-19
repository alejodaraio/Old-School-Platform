using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamesvsalex
{
  public class ChoosePlayerButton : SceneButton {

    public GameObject character = null;
    [HideInInspector]
    private GameScenes.SCENES scene = GameScenes.SCENES.LEVEL_1;

    public void OnClick()
    {
      if (character != null)
        GameManager.Instance.player = character;
  	   base.OnClick();	
  	}
  	
  }
}