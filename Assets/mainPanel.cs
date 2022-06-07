using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPanel : MonoBehaviour
{

  public activateMenu activateMenu;//ссылка на Панель

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //проверка логики и включение и отключение панели по необходимости
    if (activateMenu.active)
    {
      gameObject.SetActive(false);
    }
    if (!activateMenu.active)
    {
      gameObject.SetActive(false);
    }
  }
}
