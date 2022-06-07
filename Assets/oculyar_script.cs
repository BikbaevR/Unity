using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oculyar_script : MonoBehaviour
{
  //объявление необходимых переменных
  public Text text;
  public Text Podskazka;
  float values = 1f;
  public string ugol = "Угол: ";
  public string textPodskazki = "Предполагаемый угол: ";
  public Image myImage;
  public float transparent = 0;

  public GameObject buttonUp;
  public GameObject buttonDown;
  public GameObject liniya;

  public float variable = 0;

  public water wateristube;

  public bool popal = false;
  int count;



  public void Up()//функция для увелиения угла поворота поляризационной пленки
  {
    if (values <= 359)
    {
      values += 1;
      transparent += 1 / variable;
      liniya.transform.Rotate(0, 0, +1);
      count += 1;
    }
  }

  public void Down()//функция для уменьшению угла поворота поляризационной пленки
  {
    if (values >= 1)
    {
      values -= 1;
      transparent -= 1 / variable;
      liniya.transform.Rotate(0, 0, -1);
      count -= 1;
    }
  }




  // Use this for initialization
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    text.text = "" + ugol + values;//вывод угла поворота на экран
    Podskazka.text = "" + textPodskazki + variable;//вывод текста подсказки с углом предпологаемым углом поворота
    myImage.color = new Color(1, 1, 1, transparent);//динамическое изменение прозрачности фона 
    //Debug.Log(variable);
    //Debug.Log (variable);
    if (values == variable)//проверка угла от пользователя
    {
      popal = true;
    }
    else
    {
      popal = false;
    }
    Debug.Log(count);
  }

  public void reset()//функция сброса углов и значений
  {
    liniya.transform.Rotate(0, 0, -count);
    transparent = 0;
    values = 0;
    count = 0;
  }


}
