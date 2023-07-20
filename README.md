# Homework
1.1. Дано вещественное число. Вывести на экран его абсолютную величину (условно принимая,
что соответствующей стандартной функции нет). Полный условный оператор не использовать.
1.2. Составить программу, которая уменьшает первое введенное число в два раза, если оно
больше второго введенного числа по абсолютной величине.
1.3. Лягушка с широким ртом
Лягушку с широким ртом особенно интересуют пищевые привычки других существ.
Она просто не может перестать спрашивать встреченных ею существ, что им нравится есть. Но
затем она встречает аллигатора, который просто ОБОЖАЕТ полакомиться лягушками с широким
ртом!
Когда она встречает аллигатора, она делает крошечный рот.
Ваша цель: написать программу, которая считывает с клавиатуры название животного, который
соответствует животному, с которым столкнулась лягушка.
Если это аллигатор (без учета регистра), верните mouthSize = small, иначе верните wide.
1.4. Бармен, напитки!
Напишите программу, которая принимает на входе строку и производит выходные данные в
соответствии со следующей таблицей:

Примечание. По умолчанию используется “все остальное”: если входные данные функции не
соответствуют ни одному из значений в таблице, то возвращаемое значение должно быть
«Beer».
Убедитесь, что вы охватили случаи, когда некоторые слова не отображаются с правильным
написанием заглавных букв. Например, ввод «pOLitiCIaN» должен по-прежнему возвращать
«Your tax dollars».
1.5. Вы говорите по-английски?
Дана строка произвольной длины с любыми символами ascii. Напишите функцию, чтобы
определить, содержит ли строка все слово «English».
Порядок символов важен - строка «abcEnglishdef» верна, а «abcnEglishsef» неверна.
Прописные или строчные буквы не имеют значения - "eNglisH" тоже правильно.
Возвращаемое значение в виде логических значений: true для строки, содержащей
"английский", и false, если нет.

2.1. Вычислить сумму 1 + 1/3 + 1/32 + ... + 1/38

. Операцию возведения в степень не использовать.
2.2. «Странный муж». Некий мужчина отправляется на работу, которая находится на расстоянии 1
км от дома. Дойдя до места работы, он вдруг вспоминает, что перед уходом забыл поцеловать
жену, и поворачивает назад. Пройдя полпути, он меняет решение, посчитав, что правильнее
вернуться на работу. Пройдя 1/3 км по направлению к работе, он вдруг осознает, что будет
настоящим подлецом, если так и не поцелует жену. На этот раз, прежде чем изменить мнение, он
проходит 1/4 км. Так он продолжает метаться, и после N-этапа, пройдя 1/N км, снова меняет
решение. Определить:
а) на каком расстоянии от дома будет находиться мужчина после 100-го этапа (если допустить, что
такое возможно);
б) какой общий путь он при этом пройдет.
2.3. Известно количество осадков, выпавших за каждый день января и марта. Определить
среднедневное количество осадков за каждый месяц.

3.1. Рассмотрим последовательность, образованную дробями: 1/1, 2/1, 3/2, ..., в которой
числитель (знаменатель) следующего члена последовательности получается сложением
числителей (знаменателей) двух предыдущих членов. Числители двух первых дробей равны 1 и 2,
знаменатели — 1 и 1. Найти первый член такой последовательности, который отличается от
предыдущего члена не более чем на 0,001.
3.2. Среди чисел 1, 4, 9, 16, 25, ... найти первое число, большее n.
3.3. Имеется фрагмент программы в виде оператора цикла с параметром, обеспечивающий вывод
на экран «столбиком» всех целых чисел от 100 до 80. Оформить этот фрагмент в виде:
а) оператора цикла с предусловием;
б) оператора цикла с постусловием.
3.4. Найти максимальное из натуральных чисел, не превышающих 5000, которое нацело делится
на 39.
3.5. Напечатать числа в виде следующей таблицы:
а) 5
5 5
5 5 5
5 5 5 5
5 5 5 5 5

б) 1 1 1 1 1
1 1 1 1
1 1 1
1 1
1
#Lab4
Упражнение 4.1 Написать программу, которая читает с экрана число от 1
до 365 (номер дня в году), переводит этот число в месяц и день месяца.
Например, число 40 соответствует 9 февраля (високосный год не учитывать).

Упражнение 4.2 Добавить к задаче из предыдущего упражнения
проверку числа введенного пользователем. Если число меньше 1 или больше
365, программа должна вырабатывать исключение, и выдавать на экран
сообщение.

Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так,
чтобы она учитывала год (високосный или нет). Год вводится с экрана. (Год
високосный, если он делится на четыре без остатка, но если он делится на 100
без остатка, это не високосный год. Однако, если он делится без остатка на 400,
это високосный год.)

#lesson 25.09.2021
1. Дано трехзначное число. Выяснить, является ли оно палиндромом («перевертышем»), т. е.
таким числом, десятичная запись которого читается одинаково слева направо и справа налево.
2. Вася пытается высунуть голову в форточку размерами a и b см. Приняв условно, что его голова
— круглая диаметром d см, определить, сможет ли Вася сделать это. Для прохождения головы в
форточку необходим зазор в 1 см с каждой стороны.

3. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7)
выводит на экран его название (понедельник, вторник, ..., воскресенье).
4. Игральным картам условно присвоены следующие порядковые номера в зависимости от их
достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера
остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.). По заданному номеру
карты k (6 <=k <= 14) определить достоинство соответствующей карты.

5. Считая, что Земля — идеальная сфера с радиусом R = 6370 км, определить расстояние до линии
горизонта от точки с высотой над Землей, равной 1, 2, ... 10 км.
6. Напечатать таблицу умножения на число n (значение n вводится с клавиатуры; 1 <= n <= 9).

7. Дана непустая последовательность неотрицательных целых чисел, оканчивающаяся
отрицательным числом. Найти среднее арифметическое всех чисел последовательности (без
учета отрицательного числа).

8. Break
Дана последовательность из 10 чисел. Определить, есть ли эта последовательность
упорядоченной по возрастанию. В случае отрицательного ответа определить порядковый номер
первого числа, которое нарушает данную последовательность.

10. Continue
Дана последовательность целых чисел, которая завершается числом 0. Вычислить сумму
элементов последовательности, номера позиций которых кратны 3 (элементы на позициях 3, 6, 9
...). Считать, что нумерация позиций элементов начинается с 1.
   
11. Goto
Организовать циклический процесс вычисления суммы элементов последовательности с
помощью оператора goto. Конец последовательности – число 0.
