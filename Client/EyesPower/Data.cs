﻿using System;
using System.Net.Sockets;

namespace EyesPower
{
    public static class Data
    {
        public static Socket client;//для подключение к серверу

        //От быстрой настройки

        public static bool yesHelp = false;//помощь есть? (то есть отсылать данные мне :) )
        public static bool Program = false;//Используваете вы специальные программы (фотошоп и дургие)
        public static bool Training = false;//Тренировки
        public static bool Update = false;//Автомочитеская проверка обновлений

        //разные подтверждения

        public static bool UpdateCustomizationing = false;//Проверка настройки
        public static bool ExitMain = false;//Это нужно чтобы закрыть Main

        //Для регистрации

        public static string email = "";//email
        public static string passworld = "";//пароль

        //Разные данные

        public static string version = "1.0";//версия программы
        public static TimeSpan time;//Для контроля
        public static bool ExitLogin = false;//исправление бага
        private static Time.tamer tamer = new Time.tamer();//Это сам таймер
        public static bool ExitNewAccount = false;//После регистрации
    }
}
