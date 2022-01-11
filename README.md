#Elementary Tasks

### Общие требования

1.  При передаче некорректных параметров на исполнение приложение не должно завершать работу сбоем.
    
2.  Запуск без параметров выводит инструкции по использованию программы.
    
3.  Параметры передаются в порядке, приведённом в описании задания.
    

## Задания

1. **Шахматная доска**
    

Вывести шахматную доску с заданными размерами высоты и ширины, по принципу:
■□■□■□■□
□■□■□■□■
■□■□■□■□
□■□■□■□■
( где □ - ' ', а ■ - '*' )

Программа запускается через вызов главного класса с параметрами.

=========================================================================
2.   **Анализ конвертов**
    

Есть два конверта со сторонами (a,b) и (c,d) определить, можно ли один конверт вложить в другой. Программа должна обрабатывать ввод чисел с плавающей точкой. Программа спрашивает у пользователя размеры конвертов по одному параметру за раз. После каждого подсчёта программа спрашивает у пользователя хочет ли он продолжить. Если пользователь ответит *“y”* или *“yes”* (без учёта регистра), программа продолжает работу сначала, в противном случае – завершает выполнение.

=========================================================================
3.  **Сортировка треугольников**
    

Разработать консольную программу, выполняющую вывод треугольников в порядке убывания их площади. После добавления каждого нового треугольника программа спрашивает, хочет ли пользователь добавить ещё один. Если пользователь ответит “y” или “yes” (без учёта регистра), программа попросит ввести данные для ещё одного треугольника, в противном случае – выводит результат в консоль.

  

* Расчёт площади треугольника должен производится по формуле Герона.

* Каждый треугольник определяется именем и длинами его сторон.

* Формат ввода (разделитель - запятая):

	*<имя>, <длина стороны>, <длина стороны>, <длина стороны>*

* Приложение должно обрабатывать ввод чисел с плавающей точкой.

* Ввод должен быть нечувствителен к регистру, пробелам, табам.

* Вывод данных должен быть следующем примере:

============= Triangles list: ===============

1. [Triangle first]: 17.23 сm

2. [Triangle 22]: 13 cm

3. [Triangle 1]: 1.5 cm

=========================================================================
4. **Файловый парсер**
    

Нужно написать программу, которая будет иметь два режима:

1.  Считать количество вхождений строки в текстовом файле.
    
2.  Делать замену строки на другую в указанном файле
    

Программа должна принимать аргументы на вход при запуске:

1.  *<путь к файлу> <строка для подсчёта>*
    
2.  *<путь к файлу> <строка для поиска> <строка для замены>*
    
=========================================================================
5.  **Число в пропись**
    

Нужно преобразовать целое число в прописной вариант (русский или украинский): 12 – двенадцать. Программа запускается через вызов главного класса с параметрами.

=========================================================================
6.   **Счастливые билеты**
    

Есть 2 способа подсчёта счастливых билетов:

1. Простой — если на билете напечатано шестизначное число, и сумма первых

трёх цифр равна сумме последних трёх, то этот билет считается счастливым.

2. Сложный — если сумма чётных цифр билета равна сумме нечётных цифр билета, то билет считается счастливым.

Определить программно какой вариант подсчёта счастливых билетов даст их большее количество на заданном интервале.

Входные параметры: min и max номер билета

Выход: информация о победившем методе и количестве счастливых билетов для каждого способа подсчёта.

=========================================================================
7.   **Числовая последовательность**
    

 Вывести через запятую ряд длиной n, состоящий из натуральных чисел, квадрат которых не меньше заданного m.

Входные параметры: длина и значение минимального квадрата

Выход: строка с рядом чисел

=========================================================================
8.   **Ряд Фибоначчи**
    

Вывести все числа Фибоначчи, которые удовлетворяют переданному в функцию ограничению: находятся в указанном диапазоне, либо имеют указанную длину.

Пример: если указан диапазон [20;100] - полученный ряд Фибоначчи - 21, 34, 55, 89;
указана длина = 3, полученный ряд Фибоначчи - 144, 233, 377, 610, 987

