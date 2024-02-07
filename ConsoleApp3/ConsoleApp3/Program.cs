﻿using System;
using System.Buffers;
using System.Data.SqlTypes;

Console.WriteLine("Задание №1");
double L1, e1, a1, x1, c1;
Console.WriteLine("Введите значение переменной e1");
e1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a1");
a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x1");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c1");
c1 = Convert.ToDouble(Console.ReadLine());
L1 = Math.Sqrt(Math.Pow(e1, x1) - Math.Cos(Math.Pow(x1, 2) * Math.Pow(a1, 5))) + Math.Tanh(a1 + Math.Pow(x1, 3)) / Math.Sqrt(Math.Abs(a1 + x1 * Math.Pow(c1, 4)));
Console.WriteLine($"Результат задания №1 = {L1}");

Console.WriteLine("Задание №2");
double L2, c2, x2, t2;
Console.WriteLine("Введите значение переменной c2");
c2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x2");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t2");
t2 = Convert.ToDouble(Console.ReadLine());
L2 = Math.Pow(Math.Atan(c2), 2) + 2 * Math.Pow(x2, 2) + 5 / Math.Sqrt(c2 + t2);
Console.WriteLine($"Результат задания №2 = {L2}");

Console.WriteLine("Задание №3");
double A3, y3, h3;
Console.WriteLine("Введите значение переменной y3");
y3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h3");
h3 = Convert.ToDouble(Console.ReadLine());
A3 = Math.Tan(Math.Pow(y3, 3) + Math.Pow(h3, 2)) / Math.Sin(h3 + y3);
Console.WriteLine($"Результат задания №3 = {A3}");

Console.WriteLine("Задание №4");
double F4, y4, x4;
Console.WriteLine("Введите значение переменной y4");
y4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x4");
x4 = Convert.ToDouble(Console.ReadLine());
F4 = Math.Sqrt((2 + y4) + Math.Sqrt(Math.Sin(y4 + 5)));
Console.WriteLine($"Результат задания №4 = {F4}");

Console.WriteLine("Задание №5");
double G5, y5, z5, x5, c5;
Console.WriteLine("Введите значение переменной y5");
y5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x5");
z5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x5");
x5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c5");
c5 = Convert.ToDouble(Console.ReadLine());
G5 = Math.Tan(Math.Pow(x5, 4) - 6) - Math.Cos(z5 + x5 * y5) / Math.Cos(Math.Pow(x5, 3) * Math.Pow(c5, 2));
Console.WriteLine($"Результат задания №5 = {G5}");

Console.WriteLine("Задание №6");
double K6, x6, b6, a6, y6;
Console.WriteLine("Введите значение переменной x6");
x6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b6");
b6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a6");
a6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y6");
y6 = Convert.ToDouble(Console.ReadLine());
K6 = Math.Sqrt(x6 + b6 - a6) + Math.Log10(y6) / Math.Tanh(b6 - a6);
Console.WriteLine($"Результат задания №6 = {K6}");

Console.WriteLine("Задание №7");
double D7, x7, a7, y7;
Console.WriteLine("Введите значение переменной x7");
x7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a7");
a7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y7");
y7 = Convert.ToDouble(Console.ReadLine());
D7 = Math.Cos(Math.Pow(x7, 3) + 6) - Math.Sin(y7 - a7) / Math.Log10(Math.Pow(x7, 4) - 2 * Math.Sin(x7));
Console.WriteLine($"Результат задания №7 = {D7}");

Console.WriteLine("Задание №8");
double P8, a8, y8, c8, x8;
Console.WriteLine("Введите значение переменной x8");
x8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c8");
c8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a8");
a8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y8");
y8 = Convert.ToDouble(Console.ReadLine());
P8 = Math.Pow(a8, 5) + Math.Sin(y8 - c8) / Math.Sin(x8 + y8) + Math.Abs(x8 - y8);
Console.WriteLine($"Результат задания №8 = {P8}");

Console.WriteLine("Задание №9");
double R9, y9, x9, d9, e9;
Console.WriteLine("Введите значение переменной y9");
y9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x9");
x9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d9");
d9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e9");
e9 = Convert.ToDouble(Console.ReadLine());
R9 = Math.Cos(y9 + Math.Pow(2, x9)) / Math.Pow(e9, y9) + Math.Log10(Math.Sin(x9 + 7.4));
Console.WriteLine($"Результат задания №9 = {R9}");

Console.WriteLine("Задание №10");
double U10, e10, x10, y10;
Console.WriteLine("Введите значение переменной y10");
y10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x10");
x10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e10");
e10 = Convert.ToDouble(Console.ReadLine());
U10 = Math.Pow(e10, Math.Pow(x10, 7)) + Math.Cos(x10 - 4) / Math.Tanh(x10) + 5.2 * y10;
Console.WriteLine($"Результат задания №10 = {U10}");

Console.WriteLine("Задание №11");
double I11, e11, x11, y11;
Console.WriteLine("Введите значение переменной y11");
y11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x11");
x11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e11");
e11 = Convert.ToDouble(Console.ReadLine());
I11 = 2.33 * Math.Log10(Math.Sqrt(1 + Math.Cos(y11)));
Console.WriteLine($"Результат задания №11 = {I11}");

Console.WriteLine("Задание №12");
double G12, a12, x12, y12;
Console.WriteLine("Введите значение переменной y12");
y12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x12");
x12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a12");
a12 = Convert.ToDouble(Console.ReadLine());
G12 = Math.Cos(Math.Abs(y12 + x12)) - (x12 + y12) / Math.Tanh(x12 + a12) * Math.Pow(x12, 3);
Console.WriteLine($"Результат задания №12 = {G12}");

Console.WriteLine("Задание №13");
double R13, a13, x13, b13;
Console.WriteLine("Введите значение переменной b13");
b13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x13");
x13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a13");
a13 = Convert.ToDouble(Console.ReadLine());
R13 = a13 / x13 - a13 + Math.Pow(b13, x13) + Math.Cos(x13) / Math.Log10(a13 + 4.5);
Console.WriteLine($"Результат задания №13 = {R13}");

Console.WriteLine("Задание №14");
double R14, x14;
Console.WriteLine("Введите значение переменной x14");
x14 = Convert.ToDouble(Console.ReadLine());
R14 = Math.Sin(Math.Pow(x14, 2) + 4) + 4.3 / Math.Sin(Math.Pow(x14, 4));
Console.WriteLine($"Результат задания №14 = {R14}");


Console.WriteLine("Задание №15");
double N15, m15, y15;
Console.WriteLine("Введите значение переменной m15");
m15 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y15");
y15 = Convert.ToDouble(Console.ReadLine());
N15 = Math.Pow(m15, 2) + 2.8 * m15 + 0.355 / Math.Cos(2 * y15) + 3.6;
Console.WriteLine($"Результат задания №15 = {N15}");

Console.WriteLine("Задание №16");
double P16, x16, t16, y16, e16;
Console.WriteLine("Введите значение переменной x16");
x16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t16");
t16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y16");
y16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e16");
e16 = Convert.ToDouble(Console.ReadLine());
P16 = Math.Sin(x16) + Math.Log10(2 * y16 + 3 * y16) / Math.Pow(t16, e16) + Math.Sqrt(x16);
Console.WriteLine($"Результат задания №16 = {P16}");

Console.WriteLine("Задание №17");
double T17, x17, b17, a17, y17;
Console.WriteLine("Введите значение переменной x17");
x17 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b17");
b17 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y17");
y17 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a17");
a17 = Convert.ToDouble(Console.ReadLine());
T17 = Math.Sqrt(x17 + b17 - a17) + Math.Log(y17) / Math.Tanh(b17 / a17);
Console.WriteLine($"Результат задания №17 = {T17}");

Console.WriteLine("Задание №18");
double S18, y18, t18;
Console.WriteLine("Введите значение переменной y18");
y18 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t18");
t18 = Convert.ToDouble(Console.ReadLine());
S18 = 4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log10(t18) / Math.Sqrt(Math.Cos(2 * y18) + 4.351);
Console.WriteLine($"Результат задания №18 = {S18}");

Console.WriteLine("Задание №19");
double D19, x19, b19, a19, y19;
Console.WriteLine("Введите значение переменной x19");
x19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b19");
b19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y19");
y19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a19");
a19 = Convert.ToDouble(Console.ReadLine());
D19 = a19 * Math.Sqrt(6) - Math.Cos(3 * a19 * b19) / Math.Sin(a19 * Math.Asin(x19) + Math.Log10(y19));
Console.WriteLine($"Результат задания №19 = {D19}");

Console.WriteLine("Задание №20");
double U20, x20, b20, a20, y20, c20;
Console.WriteLine("Введите значение переменной x20");
x20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c20");
c20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b20");
b20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y20");
y20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a20");
a20 = Convert.ToDouble(Console.ReadLine());
U20 = Math.Tan(y20) + Math.Sin(x20 * Math.Sqrt(b20 - c20)) / Math.Sqrt(a20 + c20 - b20);
Console.WriteLine($"Результат задания №20 = {U20}");

Console.WriteLine("Задание №21");
double N21, z21, x21, a21, e21;
Console.WriteLine("Введите значение переменной z21");
z21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x21");
x21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a21");
a21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e21");
e21 = Convert.ToDouble(Console.ReadLine());
N21 = Math.Sqrt(z21 + Math.Sqrt(z21 * x21)) / Math.Pow(e21, x21) + Math.Pow(a21, 3) * Math.Tanh(x21);
Console.WriteLine($"Результат задания №21 = {N21}");


Console.WriteLine("Задание №22");
double F22, x22, y22;
Console.WriteLine("Введите значение переменной x22");
x22 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y22");
y22 = Convert.ToDouble(Console.ReadLine());
F22 = Math.Cos(Math.Pow(x22, 2)) + 3.5 * Math.Pow(x22, 2) + 1 / Math.Cos(y22);
Console.WriteLine($"Результат задания №22 = {F22}");


Console.WriteLine("Задание №23");
double F23, x23, z23, b23, a23;
Console.WriteLine("Введите значение переменной x23");
x23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z23");
z23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b23");
b23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a23");
a23 = Convert.ToDouble(Console.ReadLine());
F23 = Math.Sqrt(Math.Abs(x23)) + Math.Cos(x23 + Math.Pow(z23, 4)) / Math.Log10(x23) - Math.Asin(b23 * x23 - a23);
Console.WriteLine($"Результат задания №23 = {F23}");

Console.WriteLine("Задание №24");
double F24, b24, x24, a24, z24;
Console.WriteLine("Введите значение переменной b24");
b24 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x24");
x24 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a24");
a24 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z24");
z24 = Convert.ToDouble(Console.ReadLine());
F24 = Math.Cos(b24 * Math.Pow(x24, 3)) - (Math.Sin(Math.Pow(a24, 2))) + Math.Cos((Math.Pow(x24, 3) + Math.Pow(z24, 3)) - Math.Pow(a24, 2)) / Math.Asin(Math.Pow(a24, 2)) + Math.Acos((Math.Pow(x24, 7)) - Math.Pow(a24, 2));
Console.WriteLine($"Результат задания №24 = {F23}");


Console.WriteLine("Задание №25");
double J25, a25, x25, y25;
Console.WriteLine("Введите значение переменной a25");
a25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x25");
x25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y25");
y25 = Convert.ToDouble(Console.ReadLine());
J25 = Math.Atan(Math.Pow(a25, 3)) + Math.Tanh(a25) / Math.Sqrt(Math.Pow(y25, (Math.Cos(x25))));
Console.WriteLine($"Результат задания №25 = {J25}");

Console.WriteLine("Задание №26");
double U26, x26, y26, e26, k26;
Console.WriteLine("Введите значение переменной x26");
x26 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y26");
y26 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e26");
e26 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k26");
k26 = Convert.ToDouble(Console.ReadLine());
U26 = Math.Log10(Math.Pow(x26, 3) + y26) - Math.Pow(y26, 4) / Math.Pow(e26, y26) + 5.4 * Math.Pow(k26, 3);
Console.WriteLine($"Результат задания №26 = {U26}");

Console.WriteLine("Задание №27");
double P27, a27, x27, y27, c27;
Console.WriteLine("Введите значение переменной a27");
a27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x27");
x27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y27");
y27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c27");
c27 = Convert.ToDouble(Console.ReadLine());
P27 = Math.Pow(a27, 5) + Math.Acos(a27 + Math.Pow(x27, 3)) - Math.Sin(y27 - c27) / Math.Sin(x27 + y27) + Math.Abs(x27 - y27);
Console.WriteLine($"Результат задания №27 = {P27}");

Console.WriteLine("Задание №28");
double G28, x28, z28, y28, c28;
Console.WriteLine("Введите значение переменной x28");
x28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z28");
z28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y28");
y28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c28");
c28 = Convert.ToDouble(Console.ReadLine());
G28 = Math.Tan(Math.Pow(x28, 4) - 6) - Math.Cos(z28 + Math.Pow(x28, 3) * y28) / Math.Cos(Math.Pow(x28, 3) * Math.Pow(c28, 2));
Console.WriteLine($"Результат задания №28 = {G28}");

Console.WriteLine("Задание №29");
double R29, y29, d29, e29, x29;
Console.WriteLine("Введите значение переменной y29");
y29 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d29");
d29 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e29");
e29 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x29");
x29 = Convert.ToDouble(Console.ReadLine());
R29 = Math.Cos(y29) + 2.4 * d29 / Math.Pow(e29, y29) + Math.Log10(Math.Sin(x29 + 6));
Console.WriteLine($"Результат задания №29 = {R29}");

Console.WriteLine("Задание №30");
double K30,x30, e30;
Console.WriteLine("Введите значение переменной x30");
x30 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e30");
e30 = Convert.ToDouble(Console.ReadLine());
K30 = Math.Sqrt(Math.Pow(3 + x30, 6)) - Math.Log10(x30) / Math.Pow(e30, 0) + Math.Asin(6 * Math.Pow(x30, 2));
Console.WriteLine($"Результат задания №30 = {K30}");