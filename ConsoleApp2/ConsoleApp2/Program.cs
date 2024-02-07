using System.Buffers;

Console.WriteLine("Задание №1");
double G1, y1, f1, e1;
Console.WriteLine("Введите значение переменной y1");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной f1");
f1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e1");
e1 = Convert.ToDouble(Console.ReadLine());
G1 = Math.Pow(e1, 2 * y1) + Math.Sin(f1) / Math.Log10(3.8 * y1 + f1);
Console.WriteLine($"Результат задания №1 = {G1}");

Console.WriteLine("Задание №2");
double F2, d2, y2;
Console.WriteLine("Введите значение переменной y2");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d2");
d2 = Convert.ToDouble(Console.ReadLine());
F2 = Math.Log10(d2) + 3.5 * Math.Pow(d2, 2) + 1 / Math.Cos(2 * y2);
Console.WriteLine($"Результат задания №2 = {F2}");

Console.WriteLine("Задание №3");
double U3, k3, y3, e3;
Console.WriteLine("Введите значение переменной k3");
k3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y3");
y3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e3");
e3 = Convert.ToDouble(Console.ReadLine());
U3 = Math.Log10(k3 - y3) + Math.Pow(y3, 4) / Math.Pow(e3, y3) + 2 / 355 * Math.Pow(k3, 2);
Console.WriteLine($"Результат задания №3 = {U3}");

Console.WriteLine("Задание №4");
double G4, w4, y4;
Console.WriteLine("Введите значение переменной w4");
w4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y4");
y4 = Convert.ToDouble(Console.ReadLine());
G4 = 9.33 * Math.Pow(w4, 3) + Math.Sqrt(w4) / Math.Log10(y4 + 3.5) + Math.Sqrt(y4);
Console.WriteLine($"Результат задания №4 = {G4}");

Console.WriteLine("Задание №5");
double D5, a5, t5, y5, e5;
Console.WriteLine("Введите значение переменной a5");
a5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y5");
y5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e5");
e5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t5");
t5 = Convert.ToDouble(Console.ReadLine());
D5 = 7.8 * Math.Pow(a5, 2) + 3.52 * t5 / Math.Log10(a5 + 2 * y5) + Math.Pow(e5, y5);
Console.WriteLine($"Результат задания №5 = {D5}");

Console.WriteLine("Задание №6");
double L6, i6, y6;
Console.WriteLine("Введите значение переменной i6");
i6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y6");
y6 = Convert.ToDouble(Console.ReadLine());
L6 = 0.81 * Math.Cos(i6) / Math.Log10(y6 + 2) * Math.Pow(i6, 3);
Console.WriteLine($"Результат задания №6 = {L6}");

Console.WriteLine("Задание №7");
double N7, m7, y7;
Console.WriteLine("Введите значение переменной m7");
m7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y7");
y7 = Convert.ToDouble(Console.ReadLine());
N7 = Math.Pow(m7, 2) + 2.8 * m7 + 0.355 / Math.Cos(2 * y7) + 3.6;
Console.WriteLine($"Результат задания №7 = {N7}");

Console.WriteLine("Задание №8");
double T8, t8, y8;
Console.WriteLine("Введите значение переменной t8");
t8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y8");
y8 = Convert.ToDouble(Console.ReadLine());
T8 = 2.37 * Math.Sin(t8 + 1) / Math.Sqrt(4 * Math.Pow(y8, 2) - 0.1 * y8 + 5);
Console.WriteLine($"Результат задания №8 = {T8}");

Console.WriteLine("Задание №9");
double V9, y9, w9;
Console.WriteLine("Введите значение переменной w9");
w9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y9");
y9 = Convert.ToDouble(Console.ReadLine());
V9 = (y9 + 2 * w9) / Math.Log10(y9 + 0.75);
Console.WriteLine($"Результат задания №9 = {V9}");

Console.WriteLine("Задание №10");
double Z10, t10, y10;
Console.WriteLine("Введите значение переменной t10");
t10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y10");
y10 = Convert.ToDouble(Console.ReadLine());
Z10 = 2 * t10 + y10 * Math.Cos(t10) / Math.Sqrt(y10 + 4.831);
Console.WriteLine($"Результат задания №10 = {Z10}");

Console.WriteLine("Задание №11");
double D11, n11, y11;
Console.WriteLine("Введите значение переменной n11");
n11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y11");
y11 = Convert.ToDouble(Console.ReadLine());
D11 = Math.Pow(y11, 2) + 0.5 * n11 + 4.8 / Math.Sin(y11);
Console.WriteLine($"Результат задания №11 = {D11}");

Console.WriteLine("Задание №12");
double R12, t12, y12;
Console.WriteLine("Введите значение переменной t12");
t12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y12");
y12 = Convert.ToDouble(Console.ReadLine());
R12 = Math.Sin(2 * t12) + 0.3 / Math.Log10(t12 + y12);
Console.WriteLine($"Результат задания №12 = {R12}");

Console.WriteLine("Задание №13");
double A13, y13, h13, e13;
Console.WriteLine("Введите значение переменной y13");
y13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h13");
h13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e13");
e13 = Convert.ToDouble(Console.ReadLine());
A13 = Math.Sin(2 * y13 + h13) + Math.Pow(h13, 3) / Math.Pow(e13, h13) + y13;
Console.WriteLine($"Результат задания №13 = {A13}");

Console.WriteLine("Задание №14");
double P14, y14, h14, e14;
Console.WriteLine("Введите значение переменной y14");
y14 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h14");
h14 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e14");
e14 = Convert.ToDouble(Console.ReadLine());
P14 = Math.Pow(e14, y14 + 2.5) + 7.1 * Math.Pow(h14, 2) / Math.Pow(e14, h14) + y14;
Console.WriteLine($"Результат задания №14 = {P14}");

Console.WriteLine("Задание №15");
double F15, j15, y15;
Console.WriteLine("Введите значение переменной y15");
y15 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной j15");
j15 = Convert.ToDouble(Console.ReadLine());
F15 = 2 * Math.Sin(0.354 * y15 - 1) / Math.Log10(y15 + 2 * j15);
Console.WriteLine($"Результат задания №15 = {F15}");

Console.WriteLine("Задание №16");
double W16, t16, e16, y16, r16;
Console.WriteLine("Введите значение переменной t16");
t16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e16");
e16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y16");
y16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной r16");
r16 = Convert.ToDouble(Console.ReadLine());
W16 = 4 * Math.Pow(t16, 3) + Math.Log(r16) / Math.Pow(e16, y16 + r16) + 7.2 * Math.Sin(r16);
Console.WriteLine($"Результат задания №16 = {W16}");

Console.WriteLine("Задание №17");
double H17, n17, y17;
Console.WriteLine("Введите значение переменной y17");
y17 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной n17");
n17 = Convert.ToDouble(Console.ReadLine());
H17 = Math.Pow(y17, 2) - 0.8 * y17 + Math.Sqrt(y17) / 23.1 * Math.Pow(n17, 2) + Math.Cos(n17);
Console.WriteLine($"Результат задания №17 = {H17}");

Console.WriteLine("Задание №18");
double R18, k18, y18;
Console.WriteLine("Введите значение переменной y18");
y18 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k18");
k18 = Convert.ToDouble(Console.ReadLine());
R18 = Math.Sqrt(Math.Sin(y18) * y18 + 6.835) / Math.Log10(y18 + k18) + 3 * Math.Pow(y18, 2);
Console.WriteLine($"Результат задания №18 = {R18}");

Console.WriteLine("Задание №19");
double E19, q19, y19;
Console.WriteLine("Введите значение переменной y19");
y19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной q19");
q19 = Convert.ToDouble(Console.ReadLine());
E19 = Math.Log10(0.7 * y19 + 2 * q19) / Math.Sqrt(3 * Math.Pow(y19, 2) + 0.5 * y19 + 4);
Console.WriteLine($"Результат задания №19 = {E19}");

Console.WriteLine("Задание №20");
double K20, t20, y20, e20, l20;
Console.WriteLine("Введите значение переменной t20");
t20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e20");
e20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y20");
y20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной l20");
l20 = Convert.ToDouble(Console.ReadLine());
K20 = 2 * Math.Pow(t20, 2) + 3 * l20 + 7.2 / Math.Log10(y20 + Math.Pow(e20, 2 * t20));
Console.WriteLine($"Результат задания №20 = {K20}");

Console.WriteLine("Задание №21");
double Q21, k21, p21, x21, d21;
Console.WriteLine("Введите значение переменной k21");
k21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p21");
p21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x21");
x21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d21");
d21= Convert.ToDouble(Console.ReadLine());
Q21 = Math.Sqrt(k21 + 2.6 * p21 * Math.Sin(k21)) / x21 - Math.Pow(d21, 3);
Console.WriteLine($"Результат задания №21 = {Q21}");

Console.WriteLine("Задание №22");
double S22, y22, t22;
Console.WriteLine("Введите значение переменной y22");
y22 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t22");
t22 = Convert.ToDouble(Console.ReadLine());
S22 = 4.351 * Math.Pow(y22, 3) + 2 * t22 * Math.Log10(t22) / Math.Sqrt(Math.Cos(2 * y22) + 4.351);
Console.WriteLine($"Результат задания №22 = {S22}");

Console.WriteLine("Задание №23");
double R23, y23, e23, d23;
Console.WriteLine("Введите значение переменной e23");
e23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y23");
y23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d23");
d23 = Convert.ToDouble(Console.ReadLine());
R23 = Math.Sin(y22 + 0.3 * d23) / Math.Pow(e23, y23) + Math.Log10(d23);
Console.WriteLine($"Результат задания №23 = {R23}");

Console.WriteLine("Задание №24");
double U24, k24, e24, y24;
Console.WriteLine("Введите значение переменной e24");
e24 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y24");
y24 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k24");
k24 = Convert.ToDouble(Console.ReadLine());
U24 = Math.Log10(2 * k24 + 4.3) / Math.Pow(e24, k24 + y24) + Math.Sqrt(y24);
Console.WriteLine($"Результат задания №24 = {U24}");

Console.WriteLine("Задание №25");
double L25, c25, t25;
Console.WriteLine("Введите значение переменной c25");
c25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t25");
t25 = Convert.ToDouble(Console.ReadLine());
L25 = Math.Cos(c25) + 3 * Math.Pow(t25, 2) + 4 / Math.Sqrt(c25 + t25);
Console.WriteLine($"Результат задания №25 = {L25}");

Console.WriteLine("Задание №26");
double T26, u26, y26;
Console.WriteLine("Введите значение переменной u26");
u26 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y26");
y26 = Convert.ToDouble(Console.ReadLine());
T26 = Math.Sin(2 * u26) / Math.Log10(2 * y26 + u26);
Console.WriteLine($"Результат задания №26 = {T26}");

Console.WriteLine("Задание №27");
double Z27, p27, y27;
Console.WriteLine("Введите значение переменной p27");
p27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y27");
y27 = Convert.ToDouble(Console.ReadLine());
Z27 = Math.Sin(p27 + 0.4) / Math.Pow(y27, 2) + 7/325 * p27;
Console.WriteLine($"Результат задания №27 = {Z27}");


Console.WriteLine("Задание №28");
double W28, v28, e28, y28;
Console.WriteLine("Введите значение переменной e28");
e28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y28");
y28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной v28");
v28 = Convert.ToDouble(Console.ReadLine());
W28 = 0.004 * v28 + Math.Pow(e28, 2 * y28) / Math.Pow(e28, y28 / 2);
Console.WriteLine($"Результат задания №28 = {W28}");

Console.WriteLine("Задание №29");
double T29, h29, e29, y29;
Console.WriteLine("Введите значение переменной e29");
e29 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y29");
y29 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h29");
h29 = Convert.ToDouble(Console.ReadLine());
T29 = 0 / 355 * Math.Pow(h29, 2) - 4.355 / Math.Pow(e29, y29 + h29) + Math.Sqrt(2.7 * y29);
Console.WriteLine($"Результат задания №29 = {T29}");

Console.WriteLine("Задание №30");
double N30, p30, e30, y30;
Console.WriteLine("Введите значение переменной e30");
e30 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y30");
y30 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p30");
p30 = Convert.ToDouble(Console.ReadLine());
N30 = 3 * Math.Pow(y30, 2) + Math.Sqrt(2.7 * y30) / Math.Log10(p30 + y30) + Math.Pow(e30, p30);
Console.WriteLine($"Результат задания №30 = {N30}");
