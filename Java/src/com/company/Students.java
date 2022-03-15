package com.company;

public class Students {
    String name;
    estimates math;
    estimates history;
    // Сохранение имени с помощью оператора this
    public void input_name(String name){
        this.name = name;
    }
    // Вывод данных на экран
    public void print_info(){
        System.out.print(name + "\nMath: ");
        for(int i = 0; i < 10; i++){
            System.out.print(math.est[i] + " ");
        }
        System.out.print("\nHistory: ");
        for(int i = 0; i < 10; i++){
            System.out.print(history.est[i] + " ");
        }
    }
}
