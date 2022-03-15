#include <iostream>
using namespace std;
// Класс, хранящий координаты x и y
class point {
private:
	int x;
	int y;
public:
	point() {
		x = 0;
		y = 0;
	}
	point(int a, int b) {
		x = a;
		y = b;
	}
	// Передача параметров через указатель
	void input_x(int* x) {
		this->x = *x;
	}
	// Передача параметров через ссылку
	void input_y(int& y) {
		this->y = y;
	}
	// Перегрузка оператора '+'
	point operator +(const point & other)
	{
		point temp;
		temp.x = this->x + other.x;
		temp.y = this->y + other.y;
		return temp;
	}
	// Перегрузка префексного инкремента
	point & operator ++()
	{
		++this->x;
		++this->y;
		return *this;
	}
	// Перегрузка постфиксного инкремента
	point& operator ++(int value)
	{
		point temp(*this);
		this->x++;
		this->y++;
		return temp;
	}

	friend void print(point c);
};




// Дружественная функция вывода x и y
void print(point c) {
	cout << "X = " << c.x << "\tY = " << c.y << "\n";
}

int main() {
	setlocale(LC_ALL, "RUS");
	point one; 
	// Вывод x и y
	print(one); 
	// значения будущих x и y 
	int a = 11;	 
	int b = 22;
	// Переменной типа указатель на int присваевается адресс a
	int* px = &a;
	// Переменной типа ссылка на int присваевается адресс b
	int& py = b;
	// Замена x и y
	one.input_x(px);
	one.input_y(py);
	// Вывод x и y
	print(one);

	point f(13, 12);
	point z(23,25);
	point c = f + z;
	
	cout << "Точка f: ";
	print(f);
	cout << "Точка z: ";
	print(z);
	cout << "Точка c: ";
	print(c);
	// Перегрузка префексного инкремента
	++c;
	print(c);
	// Перегрузка постфиксного инкремента
	c++;
	print(c);
}