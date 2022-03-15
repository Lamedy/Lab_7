package com.company;

public class Main {

    public static void main(String[] args)
    {
        // Инициализация переменной типа Students
        Students first = new Students();
        first.math = new estimates();
        first.history = new estimates();
        // Заполнение данных
        first.input_name("Kiril" + " Kachanov");
        first.math.input();
        first.history.input();
        // Вывод данных
        first.print_info();
    }
}
