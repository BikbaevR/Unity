using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gantele : MonoBehaviour
{


  public Material white;//ссылка на внешний материал
  public GameObject perviy;//ссылка на объект
  public GameObject vtoroy;//ссылка на объект
  public GameObject tretiy;//ссылка на объект



  public void HowerEnter()
  {
    perviy.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void HowerExit()
  {
    perviy.GetComponent<Renderer>().material = white;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  public void HowerEnterTwo()
  {
    vtoroy.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void HowerExitTwo()
  {
    vtoroy.GetComponent<Renderer>().material = white;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  public void HowerEnterTree()
  {
    tretiy.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void HowerExitTree()
  {
    tretiy.GetComponent<Renderer>().material = white;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }





  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
