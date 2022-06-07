using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _podskazkiContriller : MonoBehaviour
{
  public oculyar_script oculyar_Script;//ссылка на внешний скрипт
  public panelControl panelControl;//ссылка на внешний скрипт

  //объявляем необходимые переменные
  bool start = false;
  bool krishkaOpen = false;
  bool waterInsert = false;
  bool krishkaClose = false;
  bool oculyar = false;
  bool close = false;
  bool ubrat = false;
  bool popall = false;

  public Text textPanel; //ссылка на текстовый объект


  // Use this for initialization
  void Start()
  {

    //"Для начала опыта необходимо нажать на кнопку '1. Открыть крышку'"
    //"Далее необходимо выбрать емкость с жидкостью, нажав на одну из кнопок под номерами '2, 2.1, 2.2'"
    //"Теперь необходимо закрыть крышку нажатием одноименной кнопки под номером '3'"
    //"Теперь необходимо нажать на кнопку '4. Посмотреть в окуляр'"
    //"Выполните действия описанные в правом верхнем углу"
    //"Отлично! Запомните получившийся угол и закройте данное меню нажав 'Закрыть'" oculyar_Script.popal
    //"Запишите полученный результат в таблицу, нажмите '1. Открыть крышку' и '5. Убрать трубки' для того что бы начать сначала"

    textPanel.text = ""; //поумолчанию текстовый обхект пустой
  }

  // Update is called once per frame
  void Update()
  {
    //Debug.Log (start + "|" + krishkaOpen + "|" + waterInsert + "|" + krishkaClose + "|" + oculyar + "|" + close + "|" + ubrat);

    if (start)
    {
      textPanel.text = "Для начала опыта необходимо нажать на кнопку '1. Открыть крышку'";
    }
    if (start && krishkaOpen)
    {
      textPanel.text = "Далее необходимо выбрать емкость с жидкостью, нажав на одну из кнопок под номерами '2, 2.1, 2.2', если вы выбрали '2.Поставить воду' вам необходимо записать в тоблицу значени '15.1', это равняется массовой долей содержания сахара";
    }
    if (start && krishkaOpen && waterInsert)
    {
      textPanel.text = "Теперь необходимо закрыть крышку нажатием одноименной кнопки под номером '3'";
      //krishkaOpen = false;

    }
    if (start && waterInsert && krishkaClose)
    {
      textPanel.text = "Теперь необходимо нажать на кнопку '4. Посмотреть в окуляр'";
    }
    if (start && waterInsert && krishkaClose && oculyar)
    {
      textPanel.text = "Выполните действия описанные в правом верхнем углу";
    }
    if (start && waterInsert && krishkaClose && oculyar && popall)
    {
      textPanel.text = "Отлично! Запомните получившийся угол и закройте данное меню нажав 'Закрыть'";
    }
    if (start && waterInsert && krishkaClose && oculyar && close)
    {
      textPanel.text = "Запишите полученный результат в таблицу, нажмите '1. Открыть крышку' и '5. Убрать трубки' для того что бы начать сначала";
    }
    if (ubrat)
    {
      start = false;
      krishkaOpen = true;
      waterInsert = false;
      krishkaClose = false;
      oculyar = false;
      close = false;
      ubrat = false;
      popall = false;
      textPanel.text = "";

    }

    if (oculyar_Script.popal)
    {
      popall = true;
    }
    else
    {
      popall = false;
    }
    //Debug.Log(popall);
  }


  public void startSelect() //функция начала подсказок
  {
    start = true;
  }
  public void krishkaSelect()//функция открытия крышки
  {
    krishkaOpen = true;
  }
  public void waterSelect()//функция установки сосуда с жидкостью
  {
    waterInsert = true;
  }
  public void krishkaCloseSelect()//функция закрытия крышки
  {
    krishkaClose = true;
  }
  public void oculyarSelect()//функция открытия окна Окуляр
  {
    oculyar = true;
  }
  public void closeOculyar()//функция закрытия окна Окуляр
  {
    close = true;
  }
  public void ubratTrubki()//функция убирания сосудов
  {
    ubrat = true;
  }
}


