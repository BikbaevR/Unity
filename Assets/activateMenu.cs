using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMenu : MonoBehaviour
{


  public bool active = true; //объявление буленовской переменной

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }


  public void Open()//функция открытия Панели
  {
    active = true;
    gameObject.SetActive(true);

  }
  public void Close()
  {
    active = false;
    gameObject.SetActive(false);//функция закрытия Панели

  }

}
