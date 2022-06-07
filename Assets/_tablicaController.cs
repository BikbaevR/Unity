using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _tablicaController : MonoBehaviour
{

  public InputField inputUser;//ссылка на объект ввода текста
  public Button btnClick;//ссылка на кнопку

  //объявление необходимых переменных
  public Text ugol1;
  public Text ugol2;
  public Text ugol3;
  public Text procent1;
  public Text procent2;
  public Text procent3;
  string d;


  // Use this for initialization
  void Start()
  {
    btnClick.onClick.AddListener(ReadStringInput);//обработчик для кнопки, который прослушивает нажатия кнопки
    //Поумолчанию данных в таблице нет, вместо них выставляем прочерки
    ugol1.text = "-";
    ugol2.text = "-";
    ugol3.text = "-";
    /////////////////
    procent1.text = "-";
    procent2.text = "-";
    procent3.text = "-";
  }

  // Update is called once per frame
  void Update()
  {
    //Debug.Log(d);


    if (ugol2.text != "-")//если в поле ugol2 введено значение
    {
      float d = (float.Parse(ugol2.text) / float.Parse(ugol1.text) * float.Parse(procent1.text));//вычисляем значение
      procent2.text = d.ToString();//присваиваем значение в поле procent2
    }
    if (ugol3.text != "-")//если в поле ugol3 введено значение
    {
      float c = (float.Parse(ugol3.text) / float.Parse(ugol1.text) * float.Parse(procent1.text));//вычисляем значение
      procent3.text = c.ToString();//присваиваем значение в поле procent3
    }



  }

  public void ReadStringInput()//функция для заполнения таблицы
  {
    //Debug.Log(inputUser.text);

    if (procent1.text == "-")//если поле пустое
    {
      procent1.text = inputUser.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (ugol1.text == "-")//если поле пустое
    {
      ugol1.text = inputUser.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (ugol2.text == "-")//если поле пустое
    {
      ugol2.text = inputUser.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (ugol3.text == "-")//если поле пустое
    {
      ugol3.text = inputUser.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }



  }

  public void Clear()//функция очистки таблицы
  {
    ugol1.text = "-";
    ugol2.text = "-";
    ugol3.text = "-";
    /////////////////
    procent1.text = "-";
    procent2.text = "-";
    procent3.text = "-";
  }
}



