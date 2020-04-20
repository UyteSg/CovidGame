using System;
using classes_game;
using vars;
namespace end_of_day
{
    public class script
    {
        public static int dead; //число мертвых, в итоге берем из программы
        public static int all; //число людей
        public static int ill;
        public static bool is_ill; //Есть ли зараза в городе
        public static int count = 10; //Дней до события
        public static events ev; //Текущее событие
        public static int[] used = new int[7]; //Прошедшие события
        public static int ev_used = 0; //Счетчик пройденных событий
        public static int end_of_day()
        {
            Random rnd = new Random();
            int k;
            variables.oil.num += variables.oil_factory.speed * variables.oil_factory.num;
            variables.food.num += variables.foodprom.speed * variables.foodprom.num;
            variables.material.num += variables.factory.speed * variables.factory.num;
            variables.power.num += variables.tec.speed * variables.tec.num;
            variables.oil.num -= variables.tec.uses * variables.tec.num;
            variables.power.num -= variables.oil_factory.uses * variables.oil_factory.num;
            variables.power.num -= variables.foodprom.uses * variables.foodprom.num;
            variables.power.num -= variables.factory.uses * variables.factory.num;
            if (variables.oil.num < 0)
            {
                variables.masks.num -= Math.Abs(variables.oil.num);
                variables.oil.num = 0;
            }
            if (variables.material.num < 0)
            {
                variables.masks.num -= Math.Abs(variables.material.num);
                variables.material.num = 0;
            }
            if (variables.power.num < 0)
            {
                variables.masks.num -= Math.Abs(variables.power.num);
                variables.power.num = 0;
            }
            if (variables.food.num < 0)
            {
                variables.masks.num -= Math.Abs(variables.food.num);
                variables.food.num = 0;
            }
            variables.reputation.num -= all / dead * 400;
            if (is_ill)
            {
                ill += ill / 4;
            }
            dead += ill / 100;
            ill -= ill / 100;
            if (variables.masks.num < 0 || variables.reputation.num <= 0)
            {
                return 2; //Поражение(((
            }
            count -= 1;
            if(count == 0)
            {
                count = 10;
                if (ev_used <= 6)
                {
                    bool found = false;
                    do
                    {
                        found = false;
                        k = rnd.Next(1, 7);
                        for (int i = 0; i < 7; i++)
                        {
                            if (k == used[i])
                            {
                                found = true;
                                break;
                            }
                        }
                    } while (found);
                    used[ev_used] = k;
                    ev_used++;
                    switch (k)
                    {
                        case 1:
                            ev = variables.ev1;
                            break;
                        case 2:
                            ev = variables.ev2;
                            break;
                        case 3:
                            ev = variables.ev3;
                            break;
                        case 4:
                            ev = variables.ev4;
                            break;
                        case 5:
                            ev = variables.ev5;
                            break;
                        case 6:
                            ev = variables.ev6;
                            break;
                        case 7:
                            ev = variables.ev7;
                            break;
                    }
                } else if (ev_used == 7)
                {
                    ev_used++;
                    ev = variables.ev8;
                } else
                {
                    return 1; //Победа!!!!!!!!!!!!!111!
                }
            }
            return 0;
        }
    }
}
