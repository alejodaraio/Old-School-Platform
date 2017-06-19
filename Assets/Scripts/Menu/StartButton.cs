using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamesvsalex
{

  public class StartButton : MonoBehaviour, IButton {

        public GameObject menuButton;
        public GameObject playerSelectionMenu;
        public GameObject greenImage;
        public GameObject pinkImage;

        public void Awake() {
        }
        public void OnClick()
        {
            menuButton.SetActive(false);
            greenImage.SetActive(false);
            pinkImage.SetActive(false);
            playerSelectionMenu.SetActive(true);
        }
  }
}   