using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelControl : MonoBehaviour
{
  //объявление необходимых переменных и ссылок на объекты
  public GameObject activateMenu;
  public GameObject mainPanel;
  public GameObject oculyar;
  public GameObject podskazki;
  public GameObject tablica;
  public bool oculyarClose = false;


  // Use this for initialization
  void Start()
  {
    //устанавливаем значения для панелей по умолчанию
    activateMenu.gameObject.SetActive(true);
    mainPanel.gameObject.SetActive(false);
    oculyar.gameObject.SetActive(false);
    podskazki.gameObject.SetActive(false);
    tablica.gameObject.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void activateMenuOpen()//функция открытия панели
  {
    activateMenu.gameObject.SetActive(true);

  }

  public void activateMenuClose()//функция закрытия панели
  {
    activateMenu.gameObject.SetActive(false);

  }

  public void mainPanelOpen()//функция открытия панели
  {
    mainPanel.gameObject.SetActive(true);

  }

  public void mainPanelClose()//функция закрытия панели
  {
    mainPanel.gameObject.SetActive(false);

  }

  public void oculyarPanelOpen()//функция открытия панели
  {
    mainPanel.gameObject.SetActive(false);
    oculyar.gameObject.SetActive(true);
    oculyarClose = false;
  }

  public void oculyarPanelClose()//функция закрытия панели
  {
    mainPanel.gameObject.SetActive(true);
    oculyar.gameObject.SetActive(false);
    oculyarClose = true;
  }

  public void podskazkiOpen()//функция открытия панели
  {
    podskazki.gameObject.SetActive(true);
  }

  public void podskazkiClose()//функция закрытия панели
  {
    podskazki.gameObject.SetActive(false);
  }

  public void tablicaOpen()//функция открытия панели
  {
    tablica.gameObject.SetActive(true);
  }
  public void tablicaClose()//функция закрытия панели
  {
    tablica.gameObject.SetActive(false);
  }
}
