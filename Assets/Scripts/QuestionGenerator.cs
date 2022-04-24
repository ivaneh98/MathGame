using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static Question GetQuestion()
    {
        int level = PlayerPrefs.GetInt("level", 0);
        int sign = Random.Range(0, 6);
        int x = 0;
        int y = 0;
        List<string> answers = new List<string>();
        int correctAnswer;
        switch (level)
        {
            case 0://lvl1
                switch (sign)
                {
                    case 0://+
                        x = Random.Range(0, 10);
                        y = Random.Range(0, 10);

                        correctAnswer = x + y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(0, 20);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " + " + y + " = ", answers, correctAnswer.ToString());
                    case 1://-
                        x = Random.Range(0, 10);
                        y = Random.Range(0, 10);
                        correctAnswer = x - y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(0, 20);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " - " + y + " = ", answers, correctAnswer.ToString());
                    case 2://*
                        x = Random.Range(2, 10);
                        y = Random.Range(2, 10);
                        correctAnswer = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(4, 100);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " * " + y + " = ", answers, correctAnswer.ToString());
                    default:// "/"
                        x = Random.Range(2, 10);
                        y = Random.Range(2, 10);
                        correctAnswer = x;
                        x = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(2, 10);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);
                        return new Question(x + " / " + y + " = ", answers, correctAnswer.ToString());
                }
            case 1://lvl2
                switch (sign)
                {
                    case 0://+
                        x = Random.Range(10, 100);
                        y = Random.Range(10, 100);

                        correctAnswer = x + y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(20, 200);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " + " + y + " = ", answers, correctAnswer.ToString());
                    case 1://-
                        x = Random.Range(10, 100);
                        y = Random.Range(10, 100);
                        correctAnswer = x - y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(20, 200);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " - " + y + " = ", answers, correctAnswer.ToString());
                    case 2://*
                        x = Random.Range(10, 100);
                        y = Random.Range(2, 10);
                        correctAnswer = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(x, x * y);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " * " + y + " = ", answers, correctAnswer.ToString());
                    default:// "/"
                        x = Random.Range(10, 100);
                        y = Random.Range(2, 10);
                        correctAnswer = x;
                        x = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(correctAnswer, x);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);
                        return new Question(x + " / " + y + " = ", answers, correctAnswer.ToString());
                }
            case 2://lvl3
                switch (sign)
                {
                    case 0://+
                        x = Random.Range(100, 1000);
                        y = Random.Range(100, 1000);

                        correctAnswer = x + y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(200, 2000);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " + " + y + " = ", answers, correctAnswer.ToString());
                    case 1://-
                        x = Random.Range(100, 1000);
                        y = Random.Range(100, 1000);
                        correctAnswer = x - y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(200, 2000);

                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " - " + y + " = ", answers, correctAnswer.ToString());
                    case 2://*
                        x = Random.Range(50, 111);
                        y = Random.Range(2, 10);
                        correctAnswer = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(x, x * y);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " * " + y + " = ", answers, correctAnswer.ToString());
                    default:// "/"
                        x = Random.Range(50, 111);
                        y = Random.Range(2, 10);
                        correctAnswer = x;
                        x = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(correctAnswer, x);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);
                        return new Question(x + " / " + y + " = ", answers, correctAnswer.ToString());
                }
            case 3://lvl4
                switch (sign)
                {
                    case 0://+
                        x = Random.Range(1000, 10000);
                        y = Random.Range(1000, 10000);

                        correctAnswer = x + y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(2000, 20000);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " + " + y + " = ", answers, correctAnswer.ToString());
                    case 1://-
                        x = Random.Range(1000, 10000);
                        y = Random.Range(1000, 10000);
                        correctAnswer = x - y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(2000, 20000);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " - " + y + " = ", answers, correctAnswer.ToString());
                    case 2://*
                        x = Random.Range(500, 1111);
                        y = Random.Range(2, 10);
                        correctAnswer = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(x, x * y);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " * " + y + " = ", answers, correctAnswer.ToString());
                    default:// "/"
                        x = Random.Range(500, 1111);
                        y = Random.Range(2, 10);
                        correctAnswer = x;
                        x = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(correctAnswer, x);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);
                        return new Question(x + " / " + y + " = ", answers, correctAnswer.ToString());
                }
            default://lvl5
                switch (sign)
                {
                    case 0://+
                        x = Random.Range(10000, 100000);
                        y = Random.Range(10000, 100000);

                        correctAnswer = x + y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(20000, 200000);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " + " + y + " = ", answers, correctAnswer.ToString());
                    case 1://-
                        x = Random.Range(10000, 100000);
                        y = Random.Range(10000, 100000);
                        correctAnswer = x - y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(20000, 200000);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " - " + y + " = ", answers, correctAnswer.ToString());
                    case 2://*
                        x = Random.Range(5000, 11111);
                        y = Random.Range(2, 10);
                        correctAnswer = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(x, x * y);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);

                        return new Question(x + " * " + y + " = ", answers, correctAnswer.ToString());
                    default:// "/"
                        x = Random.Range(5000, 11111);
                        y = Random.Range(2, 10);
                        correctAnswer = x;
                        x = x * y;
                        answers.Add(correctAnswer.ToString());
                        for (int i = 0; i < 3; i++)
                        {
                            int num;
                            do
                            {
                                num = Random.Range(correctAnswer, x);
                            }
                            while (num == correctAnswer || answers.Contains(num.ToString()));
                            answers.Add(num.ToString());

                        }
                        Shuffle(answers);
                        return new Question(x + " / " + y + " = ", answers, correctAnswer.ToString());
                }
        }

    }
    public static void Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i >= 1; i--)
        {
            int j = Random.Range(0, i + 1);

            T tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }
    }
}
