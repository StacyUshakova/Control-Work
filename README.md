# Contral Work

**Для написания программы были созданы методы, описанные ниже:**

1. Метод считает сколько элементов у нас будет в новом массиве, чтобы задать размер:
* указываем возвращаемое значение *int*
* указываем название функции *NewArrayElements*
* на вход принимаем массив строк *string[] array*
* ставим счетчик *count = 0*
* запускаем цикл *for*
* далее делаем проверку, если длина элемента массива меньше или равно 3, то увеличиваем *count* на 1
* после прохождения цикла возвращаем значение *count*


2. Метод присваивает и записывает туда элементы, которые подходят по условиям первого метода:
* указываем возвращаемое значение *string*
* указываем название функции *NewArray* 
* на вход принимаем массив строк *string[] array*
* вводим новую переменнную *j*
* присваиваем новому массиву элементы
* запускаем цикл *for*
* делаем проверку, если длина элемента массива меньше или равно 3, то записываем этот элемент в новый массив
* возвращаем новый массив

3. Метод для печати на консоль получившегося массива строк
* указываем значение *void*
* запускаем цикл, при которм будут выводиться на экран значения

4. Вывод
* присваиваем массиву строк размер этого массива и его элементы
* присваиваем новому массиву элементы, которые были выбраны во втором методе
* печатаем новый массив *newarray*