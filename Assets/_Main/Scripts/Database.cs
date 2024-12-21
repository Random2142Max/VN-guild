using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    // Нужен string объект для вкладки "Подготовка"
    public string StartingText { get; private set; }
    public string PreparationText { get; private set; }
    public List<ListQuestions> AllListQuestions { get; private set; }
    public List<Quest> AllQuests { get; private set; }
    public bool IsNewGame { get; set; }
    public bool IsInterview { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        // Объявление
        AllListQuestions = new List<ListQuestions>();
        AllQuests = new List<Quest>();
        IsNewGame = false;
        IsInterview = false;

        // Функции заполнения данных
        AddListQuestions();
        AddQuests();

        // Заполняем окна подготовки
        StartingText = "Добро пожаловать, стажёр!;" +
            "Здесь вас ждут захватывающие квесты, загадки и возможность погрузиться в атмосферу старых времён.\n\n" +
            "Приготовьтесь к незабываемым приключениям и не забывайте задавать вопросы - ведь именно так вы откроете для себя тайны этого увлекательного мира!";

        PreparationText = "Подготовка к интервью...;" +
            "Выберите вопросы, которые спросите у заказчика, чтобы узнать подробности квеста.\n\n" +
            "Перетащите выбранные вопросы из левой области, где представлены все доступные вопросы, в правую область.\n\n" +
            "Будьте внимательны! Выбирайте с умом.";
    }

    void AddQuests()
    {
        // Квест фермера
        AllQuests.Add(new Quest(
            AllQuests.Count,
            "Сбор урожая для фермера",
            "Фермер",
            "Фермер получил от предсказателя погоды предупреждение о том, что сезон дождей начнётся раньше на несколько недель.\n\n" +
            "Сам он не успеет собрать весь свой урожай до этого времени, а сын должен уехать на ярмарку с урожаем, часть из которого до сих пор не собрана.\n\n" +
            "Нужная ваша помощь.",
            "предсказателя погоды предупреждение;не успеет собрать;этого времени;часть;не собрана",
            1
            ));
    }
    void AddListQuestions()
    {
        // Списки вопросов и ответов
        // Разделители:
        // ';' - разделение вопросов и ответов
        // '|' - разделяет все ответы на 1 вопрос, чтобы ответы выходили попорядку
        
        AllListQuestions.Add(new ListQuestions(
            AllListQuestions.Count,
            "Какие культуры необходимо собрать?;" +
            "Есть ли какие-то особенности сбора культур?;" +
            "К какому сроку нужно успеть собрать урожай?;" +
            "Сколько нужно собрать урожая?;" +
            "Что прорицатель сказал вам о погоде в ближайшие дни?;" +
            "Что может случится во время сбора урожая?;" +
            "Как вы обычно одеваетесь на сбор урожая?;" +
            "Кто обычно помогает вам на ферме?",
            "Нужно собрать: Картофель, Томаты, Кукурузу, Тыкву и Сафлор.;" +
            "Сафлор нужно собирать с помощником-магом, хранить в тканевых мешках.|" +
            "Тыкву нельзя собирать в дождь, надо оставлять длинный хвостик, срезая ножом.|" +
            "Листья у початков кукурузы обрывать нельзя.|" +
            "Томаты срезать ножом.|" +
            "Картофель надо очистить от земли.;" +
            "Урожай надо собрать за 4 дня.|" +
            "Картофель надо собрать в первый день, сын повезёт его на ярмарку.;" +
            "Нужно собрать 100-120 вёдер картошки.|" +
            "Нужно собрать 90-100 ящиков кукурузы.|" +
            "Нужно собрать 70-80 ящиков томатов.|" +
            "Нужно собрать 30-40 мешков сафлора.|" +
            "Нужно собрать 120 тыкв.;" +
            "В какой-то день будет дождь, можно собрать томаты в теплицах.;" +
            "Можно получить солнечный удар при сборе кукурузы.|" +
            "Можно простудиться, если собирать томаты в дождливый день.|" +
            "Если уронить тыкву на ногу, можно получить ушиб.|" +
            "Также я обычно надеваю массивные ботинки во время сбора тыкв.;" +
            "Я надевая шляпу в солнечные дни и ботинки, когла собираю тыкву.;" +
            "Сын сможет помочь в первый день.|" +
            "Помощники придут на четвёртый день."
            ));
    }
    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
}