using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{

  public bool active = true;//объявление буленовской переменной
  public Material green;//ссылка на внешний материал


  public void Open()//функция открытия крышки аппарата
  {
    if (active)
      transform.Rotate(100f, 0, 0);//поворачиваем крышку на 100f по х
    active = false;
  }

  public void Close()//функция зыкрытия крышки аппарата
  {
    if (!active)
      transform.Rotate(-100f, 0, 0);//поворачиваем крышку на -100f по х
    active = true;
  }


  public void HowerEnter()
  {
    GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void HowerExit()
  {
    GetComponent<Renderer>().material = green;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }


  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.Escape))
    {
      Application.Quit();
    }
  }
}
