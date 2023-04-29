// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task 1
//int num, uzunluq;
//int result = 0;
//l1:
//    Console.Write("4 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 4)
//    {
//        goto l1;
//    }

//    else
//    {
//        while (num > 0)
//        {
//            int qaliq = num % 10;
//            num /= 10;
//            result += qaliq;

//        }
//        Console.WriteLine(result);
//    }

#endregion

#region Task 2
//    int num, uzunluq;
//    int result = 0;
//l1:
//    Console.Write("6 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 6)
//    {
//        goto l1;
//    }

//    else
//    {
//        num /= 1000;
//        while (num > 0)
//        {
//            int qaliq = num % 10;
//            num /= 10;
//            result += qaliq;
//        }
//        Console.WriteLine(result);
//    }

#endregion

#region Task 3
//    int num, uzunluq;
//    int result = 0;
//l1:
//    Console.Write("4 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 9)
//    {
//        goto l1;
//    }

//    else
//    {
//        num /= 1000;
//        while (num>999)
//        {
//            int qaliq = num % 10;
//            num /= 10;
//            result += qaliq;
//        }
//        Console.WriteLine(result);
//    }


#endregion

#region Task 4
//    int num, uzunluq;
//    int result = 0;
//l1:
//    Console.Write("5 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 5)
//    {
//        goto l1;
//    }

//    else
//    {
//        while (num > 0)
//        {
//            int qaliq = num % 10;
//            num /= 10000;
//            result += qaliq;
//        }
//        Console.WriteLine(result * result);
//    }

#endregion

#region Task 5
//    int num, uzunluq, qaliq;
//    int result = 0;
//    int pow = 0;
//l1:
//    Console.Write("6 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 6)
//    {
//        goto l1;
//    }

//    else
//    {
//        while (num > 10)
//        {
//            qaliq = num % 10;
//            num /= 10;
//            result += qaliq * (int)Math.Pow(10, pow);
//            pow++;
//        }
//        int firstDigit = num % 10;
//        Console.WriteLine(result * 10 + firstDigit);
//        //Console.WriteLine(firstDigit);

//    }
#endregion

#region Task 6
//    int num, uzunluq, qaliq;
//    int result = 0;
//    int pow = 0;
//l1:
//    Console.Write("8 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 8)
//    {
//        goto l1;
//    }

//    else
//    {
//        num /= 10;
//        while (num > 10)
//        {
//            qaliq = num % 10;
//            num /= 10;
//            result += qaliq * (int)Math.Pow(10, pow);
//            pow++;
//        }
//        Console.WriteLine(result);

//    }

#endregion

#region Task 7
//    int newNumber = 0;
//    int start8 = 1;
//l1:
//    Console.Write("4 reqemli ededi daxil edin:");//1234
//    int.TryParse(Console.ReadLine(), out int num1);
//    int uzunluq1 = (int)Math.Log10(num1) + 1;
//    if (uzunluq1 != 4)
//    {
//        goto l1;
//    }


//    else
//    {
//        while (num1 > 0)
//        {
//            int qaliq = num1 % 10;
//            newNumber = newNumber * 10 + qaliq;
//            num1 /= 10;
//        }
//        start8 = 8 * (int)Math.Pow(10, uzunluq1) + newNumber;
//        Console.WriteLine(start8 * 10 + 8);
//    }


#endregion

#region Task 8
//    int num;
//    int result = 0;
//    int a = 2;
//l1:
//    Console.Write("reqemi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    if (num > 99)
//    {
//        while (a > 0) 
//        {
//            int qaliq = num % 10;
//            num /= 100;
//            result += qaliq;
//            a--;
//        }
//        Console.WriteLine(result);
//    }

//    else
//    {
//        goto l1;
//    }

#endregion

#region Task 9
//    int num, uzunluq, qaliq;
//    int tek = 0;
//    int pow = 0;
//l1:
//    Console.Write("9 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 9)
//    {
//        goto l1;
//    }

//    else
//    {
//        while (num > 0)
//        {
//            qaliq = num % 10;
//            num /= 100;
//            tek += qaliq * (int)Math.Pow(10, pow);
//            pow++;
//        }
//        Console.WriteLine(tek);
//    }

#endregion

#region Task 10
//    int num, uzunluq, qaliq1, qaliq2;
//    int tek = 0;
//    int cut = 0;
//    int pow = 0;
//l1:
//    Console.Write("9 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 9)
//    {
//        goto l1;
//    }

//    else
//    {
//        while (num > 0)
//        {
//            qaliq1 = num % 10;
//            num /= 10;
//            qaliq2 = num % 10;
//            num /= 10;
//            tek += qaliq1 * (int)Math.Pow(10, pow);
//            cut += qaliq2 * (int)Math.Pow(10, pow);
//            pow++;
//        }
//        Console.WriteLine(tek);
//        Console.WriteLine(cut);
//        Console.WriteLine(tek + cut);

//    }
#endregion

#region Task 11
//    int num, uzunluq, qaliq1, qaliq2, qaliq3, qaliq4;
//    int group1 = 0;
//    int group2 = 0;
//    int group3 = 0;
//    int group4 = 0;
//    int pow = 0;
//l1:
//    Console.Write("8 reqemli eded daxil edin:");

//    int.TryParse(Console.ReadLine(), out num);
//    uzunluq = (int)Math.Log10(num) + 1;
//    if (uzunluq != 8)
//    {
//        goto l1;
//    }

//    else
//    {
//        while (num > 0)
//        {
//            qaliq1 = num % 10;
//            num /= 10;
//            qaliq2 = num % 10;
//            num /= 10;
//            qaliq3 = num % 10;
//            num /= 10;
//            qaliq4 = num % 10;
//            num /= 10;
//            group1 += qaliq1 * (int)Math.Pow(10, pow);
//            group2 += qaliq2 * (int)Math.Pow(10, pow);
//            group3 += qaliq3 * (int)Math.Pow(10, pow);
//            group4 += qaliq4 * (int)Math.Pow(10, pow);
//            pow++;
//        }
//        int sum = group1 + group2 + group3 + group4;
//        double add_99 = sum * 100 + 99;
//        double percent_18 = add_99 * 18 / 100; ////// double result = add_99 * 82 /100;
//        double result = add_99 - percent_18;
//        Console.WriteLine(result);

//    }

#endregion

#region Task 12
//    int num1, num2, uzunluq1, uzunluq2;
//    int result1 = 0;
//    int result2 = 1;
//l1:
//    Console.Write("1ci 5 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num1);
//    uzunluq1 = (int)Math.Log10(num1) + 1;
//    if (uzunluq1 != 5)
//    {
//        goto l1;
//    }


//l2:
//      Console.Write("2ci 5 reqemli ededi daxil edin:");
//    int.TryParse(Console.ReadLine(), out num2);
//    uzunluq2 = (int)Math.Log10(num2) + 1;
//    int temp1 = num1;
//    int temp2 = num2;
//    if (uzunluq2 != 5)
//    {
//        goto l2;
//    }


//    else
//    {
//        while (temp1 > 0 && temp2 > 0)  
//        {
//            int qaliq1 = temp1 % 10;
//            temp1 /= 10;
//            result1 += qaliq1;
//            int qaliq2 = temp2 % 10;
//            temp2 /= 10;
//            result2*= qaliq2;
//        }
//        int sum_result = result1 + result2;
//        int sonNetice = sum_result * 10 + num1 % 10;
//        Console.WriteLine(sonNetice);
//    }

#endregion

#region Task 13
//    int num1, num2, uzunluq1, uzunluq2, num3, uzunluq3;
//    int sum1 = 0;
//    int sum2 = 0;
//    int sum3 = 0;
//    int pow = 0;
//l1:
//    Console.Write("1ci 5 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num1);
//    uzunluq1 = (int)Math.Log10(num1) + 1;
//    if (uzunluq1 != 5)
//    {
//        goto l1;
//    }


//l2:
//    Console.Write("2ci 5 reqemli ededi daxil edin:");
//    int.TryParse(Console.ReadLine(), out num2);
//    uzunluq2 = (int)Math.Log10(num2) + 1;
//    if (uzunluq2 != 5)
//    {
//        goto l2;
//    }


//l3:
//    Console.Write("3cu 5 reqemli ededi daxil edin:");
//    int.TryParse(Console.ReadLine(), out num3);
//    uzunluq3 = (int)Math.Log10(num3) + 1;
//    int temp1 = num1;
//    int temp2 = num2;
//    int temp3 = num3;
//    if (uzunluq3 != 5)
//    {
//        goto l3;
//    }


//    else
//    {
//        while (temp1 > 0 && temp2 > 0 && temp3 > 0)
//        {
//            int qaliq1 = temp1 % 10;
//            int qaliq2 = temp2 % 10;
//            int qaliq3 = temp3 % 10;
//            temp1 /= 1000;
//            temp2 /= 1000;
//            temp3 /= 1000;
//            sum1 += qaliq1 * (int)Math.Pow(10, pow);
//            sum2 += qaliq2 * (int)Math.Pow(10, pow);
//            sum3 += qaliq3 * (int)Math.Pow(10, pow);
//            pow++;
//        }
//        double allSum = sum1 + sum2 + sum3;
//        double percent_50 = allSum * 50 / 100;
//        double result = allSum + percent_50;
//        Console.WriteLine(result);
//    }

#endregion

#region Task 14
//    int num1, num2, uzunluq1, uzunluq2, num3, uzunluq3, num4, uzunluq4;
//    int sum1 = 0;
//    int sum2 = 0;
//    int sum3 = 0;
//    int sum4 = 0;
//    int pow1 = 0;
//    int pow2 = 0;
//    int num4Vurma = 1;
//l1:
//    Console.Write("1ci 6 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num1);
//    uzunluq1 = (int)Math.Log10(num1) + 1;
//    if (uzunluq1 != 6)
//    {
//        goto l1;
//    }


//l2:
//    Console.Write("2ci 6 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num2);
//    uzunluq2 = (int)Math.Log10(num2) + 1;
//    if (uzunluq2 != 6)
//    {
//        goto l2;
//    }


//l3:
//    Console.Write("3cu 6 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num3);
//    uzunluq3 = (int)Math.Log10(num3) + 1;
//    if (uzunluq3 != 6)
//    {
//        goto l3;
//    }


//l4:
//    Console.Write("7 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num4);
//    uzunluq4 = (int)Math.Log10(num4) + 1;
//    int temp1 = num1;
//    int temp2 = num2;
//    int temp3 = num3;
//    int temp4 = num4;
//    if (uzunluq4 != 7)
//    {
//        goto l4;
//    }


//    else
//    {
//        temp1 /= 1000;
//        temp2 /= 1000;
//        temp3 /= 1000;
//        num4 /= 10000;
//        while (temp1 > 0 && temp2 > 0 && temp3 > 0 && num4 > 0)
//        {
//            int qaliq1 = temp1 % 10;
//            int qaliq2 = temp2 % 10;
//            int qaliq3 = temp3 % 10;
//            temp1 /= 10;
//            temp2 /= 10;
//            temp3 /= 10;
//            sum1 += qaliq1 * (int)Math.Pow(10, pow1);
//            sum2 += qaliq2 * (int)Math.Pow(10, pow1);
//            sum3 += qaliq3 * (int)Math.Pow(10, pow1);

//            int num4Qaliq = num4 % 10;
//            num4 /= 10;
//            num4Vurma *= num4Qaliq;
//            pow1++;
//        }

//        while (temp4 > 1000) 
//        {
//            int qaliq4 = temp4 % 10;
//            temp4 /= 10;
//            sum4 += qaliq4 * (int)Math.Pow(10, pow2);
//            pow2++;
//        }
//        int allSum = sum1 + sum2 + sum3 + sum4;
//        int cixma = allSum - num4Vurma;
//        int percent_60 = cixma * 60 / 100;
//        int add_60 = percent_60 * 100 + 60;
//        int percent_18 = add_60 * 18 / 100;
//        int result = add_60 - percent_18;

//        Console.WriteLine(result);
//    }

#endregion

#region Task 15
//    int num1, num2, uzunluq1, uzunluq2, num3, uzunluq3, num4, uzunluq4, num5, uzunluq5;
//    //int sum1 = 0;
//    //int sum2 = 0;
//    int sum3 = 0;
//    //int sum4 = 0;
//    int pow3 = 0;
//    int pow7 = 0;
//    int pow7_2 = 0;
//    int pow6 = 0;
//    int son2_3 = 0;
//    int son5_7 = 0;
//    int son3_6 = 0;
//    int sum_n7 = 0;
//    int tersSum7 = 0;
//    int a = 2;
//    int b = 3;
//    int tekyer7 = 0;
//l1:
//    Console.Write("1ci 3 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num1);
//    uzunluq1 = (int)Math.Log10(num1) + 1;
//    if (uzunluq1 != 3)
//    {
//        goto l1;
//    }


//l2:
//    Console.Write("2ci 3 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num2);
//    uzunluq2 = (int)Math.Log10(num2) + 1;
//    if (uzunluq2 != 3)
//    {
//        goto l2;
//    }


//l3:
//    Console.Write("1ci 6 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num3);
//    uzunluq3 = (int)Math.Log10(num3) + 1;
//    if (uzunluq3 != 6)
//    {
//        goto l3;
//    }


//l4:
//    Console.Write("2ci 6 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num4);
//    uzunluq4 = (int)Math.Log10(num4) + 1;
//    if (uzunluq4 != 6)
//    {
//        goto l4;
//    }
//l5:
//    Console.Write("7 reqemli ededi daxil edin:");

//    int.TryParse(Console.ReadLine(), out num5);
//    uzunluq5 = (int)Math.Log10(num5) + 1;
//    int temp3_1 = num1;
//    int temp3_2 = num2;
//    int temp6_1 = num3;
//    int temp6_2 = num4;
//    int temp7 = num5;
//    int n7 = num5;
//    int n7_2 = num5;
//    if (uzunluq5 != 7)
//    {
//        goto l5;
//    }


//    else
//    {
//        sum3 = num1 + num2;
//        while (a > 0)
//        {
//            int qaliq3 = sum3 % 10;
//            sum3 /= 10;
//            son2_3 += qaliq3 * (int)Math.Pow(10, pow3);
//            a--;
//            pow3++;
//        }
//        int son2_3kv = (int)Math.Pow(10, 2);
//        int yapis_4 = num1 * (int)Math.Pow(10, uzunluq2) + num2;
//        int topla1 = son2_3 + yapis_4;

//        while (temp7 > 100)
//        {
//            int qaliq7 = temp7 % 10;
//            temp7 /= 10;
//            son5_7 += qaliq7 * (int)Math.Pow(10, pow7);
//            pow7++;
//        }

//        int cixma1 = topla1 - son5_7;
//        int sum6 = temp6_1 + temp6_2;
//        while (b > 0)
//        {
//            int qaliq6 = sum6 % 10;
//            sum6 /= 10;
//            son3_6 += qaliq6 * (int)Math.Pow(10, pow6);
//            b--;
//            pow6++;
//        }

//        int topla2 = cixma1 + son3_6;
//        while (n7 > 0)
//        {
//            int qaliqn7 = n7 % 10;
//            n7 /= 10;
//            sum_n7 += qaliqn7;
//        }

//        int t = sum_n7;
//        while (t > 0)
//        {
//            int qaliqSum7 = t % 10;
//            tersSum7 = tersSum7 * 10 + qaliqSum7;
//            t /= 10;
//        }
//        int topla3 = topla2 + tersSum7;
//        int add_11 = topla3 * 100 + 11;

//        while (n7_2 > 0)
//        {
//            int qaliqn7_2 = n7_2 % 10;
//            n7_2 /= 100;
//            tekyer7 += qaliqn7_2 * (int)Math.Pow(10, pow7_2);
//            pow7_2++;
//        }

//        long cixma2 = add_11 - tekyer7;
//        long resultQaliq = cixma2 % 10;
//        long qqq = cixma2 / 10;
//        long add_88 = qqq * 100 + 88;
//        long result = add_88 * 10 + resultQaliq;
//        //string result = convertToString(add_88 + 1);

//        Console.WriteLine(sum_n7);
//        Console.WriteLine(tersSum7);
//        Console.WriteLine(result);
//}

#endregion