using System;

namespace Assignments
{
    public class Assignment5
    {
        public static void checkAge()
        {
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine()!);
            }
            for (int i = 0; i < ages.Length; i++)
            {
            if (ages[i] < 0)
            {
                Console.WriteLine("Invalid age entered.");
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine($"Student with age {ages[i]} is eligible to vote.");
            }
            else
            {
                Console.WriteLine($"Student with age {ages[i]} is not eligible to vote.");
            }
            }
        }



        public static void numAnalysis()
        {
            int[] arr=new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write($"Enter n {i+1}: ");
                arr[i]=int.Parse(Console.ReadLine()!);
            }

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine("Number is 0");
                }
                else if (arr[i] < 0)
                {
                    Console.WriteLine("It is a negative n");
                }
                else
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.WriteLine("Its an even n");
                    }
                    else
                    {
                        Console.WriteLine("Its an odd n");
                    }
                }
            }
            if (arr[0] == arr[arr.Length - 1])
            {
                Console.WriteLine("Equal");
            }
            else if(arr[0]>arr[arr.Length-1])
            {
                Console.WriteLine("First Element is equal");
            }
            else
            {
                Console.WriteLine("Last element is greater");
            }
        }
        

        public static void mult()
        {
            Console.WriteLine("Enter the n you want multiplication table of: ");
            int n=int.Parse(Console.ReadLine()!);
            int[] arr=new int[10];
            for(int i=0; i<10; i++)
            {
                arr[i]=n*(i+1);
                Console.WriteLine($"{n}*{i+1} = {n*(i+1)}");
            }
        }




        public static void enterNum()
        {
            int[] num = new int[10];
            int idx = 0;
            int sum = 0;
            while (idx < num.Length)
            {
                Console.Write("Enter a n: ");
                num[idx] = int.Parse(Console.ReadLine()!);

                if (num[idx] <= 0)
                {
                    break;
                }
                sum += num[idx];
                idx++;
            }
            Console.WriteLine("\nNumbers entered are:");
            int i = 0;
            while (i < idx)
            {
                Console.Write(num[i] + " ");
                i++;
            }
            Console.WriteLine("\nSum = " + sum);
        }

        public static void multi6To9()
        {
            int n;
            int mult = 6;

            Console.Write("Enter a n: ");
            n = int.Parse(Console.ReadLine()!);
            while (mult <= 9)
            {
                Console.WriteLine(n + " x " + mult + " = " + (n * mult));
                mult++;
            }
        }


        public static void height()
        {
            int[] h = new int[11];
            int sum = 0;
            for (int i = 0; i < h.Length; i++)
            {
                Console.Write("Enter height of player " + (i + 1) + ": ");
                h[i] = int.Parse(Console.ReadLine()!);

                sum += h[i];
            }
            double mean = (double)sum / h.Length;
            Console.WriteLine("Mean height of players = " + mean);
        }


        public static void saveArray()
        {
            Console.Write("Enter a n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] odd = new int[n];
            int[] even = new int[n];

            int oddIdx = 0;
            int evenIdx = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenIdx] = i;
                    evenIdx++;
                }
                else
                {
                    odd[oddIdx] = i;
                    oddIdx++;
                }
            }
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIdx; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.WriteLine("\nEven Numbers:");
            for (int i = 0; i < evenIdx; i++)
            {
                Console.Write(even[i] + " ");
            }
        }


        public static void fact()
        {
            Console.Write("Enter a n: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] facts = new int[n];
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n% i == 0)
                {
                    facts[c] = i;
                    c++;
                }
            }
            Console.WriteLine("Factors are:");
            for (int i = 0; i < c; i++)
            {
                Console.Write(facts[i] + " ");
            }
        }

        public static void d2arr()
        {
            int[,] arr2D = new int[2, 3];
            int[] arr = new int[6];
            int index = 0;
            Console.WriteLine("Enter the elements of the 2D Array:");
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int column = 0; column < arr2D.GetLength(1); column++)
                {
                    Console.Write("Enter element [" + row + "," + column + "]: ");
                    arr2D[row, column] = int.Parse(Console.ReadLine()!);
                }
            }
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int column = 0; column < arr2D.GetLength(1); column++)
                {
                    arr[index] = arr2D[row, column];
                    index++;
                }
            }
            Console.WriteLine("\n2D Array:");
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int column = 0; column < arr2D.GetLength(1); column++)
                {
                    Console.Write(arr2D[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n1D Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


        public static void fizz()
        {
            Console.Write("Enter a positive n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer.");
                return;
            }
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                int value = i + 1;

                if (value % 3 == 0 && value % 5 == 0)
                {
                    arr[i] = "FizzBuzz";
                }
                else if (value % 3 == 0)
                {
                    arr[i] = "Fizz";
                }
                else if (value % 5 == 0)
                {
                    arr[i] = "Buzz";
                }
                else
                {
                    arr[i] = value.ToString();
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Position " + (i + 1) + " = " + arr[i]);
            }
        }



// ---------------------level 2 -----------------------------


        public static void Zara()
        {
            double[] sal = new double[10];
            double[] yrs = new double[10];

            double[] bonus = new double[10];
            double[] newSal = new double[10];
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            for (int i = 0; i < sal.Length; i++)
            {
                Console.WriteLine("Employee " + (i + 1));
                Console.Write("Enter salary: ");
                sal[i] = double.Parse(Console.ReadLine()!);

                Console.Write("Enter years of service: ");
                yrs[i] = double.Parse(Console.ReadLine()!);
                if (sal[i] <= 0||yrs[i] < 0)
                {
                    Console.WriteLine("Invalid input.Enter again.");
                    i--;
                    continue;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < sal.Length; i++)
            {
                if (yrs[i] > 5)
                {
                    bonus[i] = sal[i]*0.05;
                }
                else
                {
                    bonus[i] = sal[i]*0.02;
                }
                newSal[i] = sal[i] + bonus[i];
                totalBonus += bonus[i];
                totalOldSalary += sal[i];
                totalNewSalary += newSal[i];
            }
            Console.WriteLine("Total Bonus Paid: " + totalBonus);
            Console.WriteLine("Total Old Salary: " + totalOldSalary);
            Console.WriteLine("Total New Salary: " + totalNewSalary);
        }    

        public static void ages()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] h = new double[3];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter age of " + names[i] + ": ");
                ages[i] = int.Parse(Console.ReadLine()!);
                Console.Write("Enter height of " + names[i] + ": ");
                h[i] = double.Parse(Console.ReadLine()!);
            }
            int yIdx = 0;
            int tIdx = 0;
            for (int i = 1; i < names.Length; i++)
            {
                if (ages[i] < ages[yIdx])
                {
                    yIdx = i;
                }

                if (h[i] > h[tIdx])
                {
                    tIdx = i;
                }
            }
            Console.WriteLine("\nYoungest friend is: " + names[yIdx]);
            Console.WriteLine("Age: " + ages[yIdx]);

            Console.WriteLine("\nTallest friend is: " + names[tIdx]);
            Console.WriteLine("Height: " + h[tIdx]);   
        }

        public static void Proragram2()
        {
            Console.Write("Enter a n: ");
            long n= long.Parse(Console.ReadLine()!);
            int max = 10;
            int[] digits =new int[max];
            int idx = 0;
            while (n> 0)
            {
                if (idx==max)
                {
                    max =max + 10;

                    int[] newArray=new int[max];
                    for (int i = 0; i < digits.Length; i++)
                    {
                        newArray[i] = digits[i];
                    }
                    digits = newArray;
                }
                digits[idx] = (int)(n % 10);
                idx++;

                n= n/10;
            }
            int largest = -1;
            int secondLargest = -1;
            for (int i = 0; i < idx; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            Console.WriteLine("Digits are:");
            for (int i = idx-1; i >= 0; i--)
            {
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Largest digit = " + largest);
            Console.WriteLine("Second largest digit = " + secondLargest);
            
        }
        public static void revnum()
        {
            Console.Write("Enter a n: ");
            int n = int.Parse(Console.ReadLine()!);
            string numString = n.ToString();
            int[] digit = new int[numString.Length];
            for (int i = 0; i < numString.Length; i++)
            {
                digit[i] = numString[i] - '0';
            }
            Console.WriteLine("Digits are:");
            for (int i = 0; i < digit.Length; i++)
            {
                Console.Write(digit[i] + " ");
            }
            Console.WriteLine("\nReverse n is:");
            for (int i = digit.Length - 1; i >= 0; i--)
            {
                Console.Write(digit[i]);
            }
        }


        public static void bmi()
        {
            Console.Write("Enter n of persons: ");
            int n = int.Parse(Console.ReadLine()!);
            double[] h = new double[n];
            double[] w = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));
                Console.Write("Enter height in meters: ");
                h[i] = double.Parse(Console.ReadLine()!);

                Console.Write("Enter weight in kg: ");
                w[i] = double.Parse(Console.ReadLine()!);
                bmi[i] = w[i]/(h[i] * h[i]);
                if (bmi[i] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] < 25)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] < 30)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }
            Console.WriteLine("Height Weight BMI Status");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    h[i] + "\t" +
                    w[i] + "\t" +
                    bmi[i].ToString("0.00") + "\t" +
                    status[i]
                );
            }
        }


        public static void bmi2()
        {
            Console.Write("Enter n of persons: ");
            int n = int.Parse(Console.ReadLine()!);
            double[,] personData = new double[n, 3];

            string[] status = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));
                Console.Write("Enter height in meters: ");
                personData[i, 0] = double.Parse(Console.ReadLine()!);
                Console.Write("Enter weight in kg: ");
                personData[i, 1] = double.Parse(Console.ReadLine()!);

                personData[i,2] = personData[i,1] / 
                                   (personData[i,0] * personData[i,0]);

                if (personData[i,2]<18.5)
                {
                    status[i] = "Underweight";
                }
                else if (personData[i,2] < 25)
                {
                    status[i] = "Normal";
                }
                else if (personData[i,2]<30)
                {
                    status[i]="Overweight";
                }
                else
                {
                    status[i]="Obese";
                }
            }
            Console.WriteLine("\nHeight\tWeight\tBMI\tStatus");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    personData[i, 0] + "\t" +
                    personData[i, 1] + "\t" +
                    personData[i, 2].ToString("0.00") + "\t" +
                    status[i]
                );
            }
        }


        public static void stumarks()
        {
             Console.Write("Enter n of students: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] phy = new int[n];
            int[] chem = new int[n];
            int[] math = new int[n];

            double[] per = new double[n];
            string[] grade = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1));

                Console.Write("Enter Physics marks: ");
                phy[i] = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Chemistry marks: ");
                chem[i] = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Maths marks: ");
                math[i] = int.Parse(Console.ReadLine()!);
                if (phy[i] <0||chem[i]< 0||math[i] < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Enter again.");
                    i--;
                    continue;
                }
                int total = phy[i] + chem[i] + math[i];
                per[i] = total / 3.0;
                if (per[i] >= 90)
                {
                    grade[i] = "A";
                }
                else if (per[i] >= 80)
                {
                    grade[i] = "B";
                }
                else if (per[i] >= 70)
                {
                    grade[i] = "C";
                }
                else if (per[i] >= 60)
                {
                    grade[i] = "D";
                }
                else
                {
                    grade[i] = "F";
                }
            }
            Console.WriteLine("Physics Chemistry Maths Percentage Grade");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    phy[i] + " " +
                    chem[i] + " " +
                    math[i] + " " +
                    per[i] + " " +
                    grade[i]
                );
            }
        }


        public static void storemarks()
        {
            Console.Write("Enter n of students: ");
            int numOfStudents = int.Parse(Console.ReadLine()!);
            int[,] marks = new int[numOfStudents, 3];
            double[] perc = new double[numOfStudents];
            string[] g= new string[numOfStudents];

            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine("Student " + (i + 1));
                Console.Write("Enter Phys marks: ");
                marks[i,0] = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Chem marks: ");
                marks[i,1] =int.Parse(Console.ReadLine()!);

                Console.Write("Enter Maths marks: ");
                marks[i,2] = int.Parse(Console.ReadLine()!);
                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    Console.WriteLine("Invalid marks. Enter again.");
                    i--;
                    continue;
                }
                int total = marks[i,0] + marks[i, 1] + marks[i, 2];
                perc[i] = total / 3.0;
                if (perc[i] >= 90)
                {
                    g[i] = "A";
                }
                else if (perc[i] >= 80)
                {
                    g[i] = "B";
                }
                else if (perc[i] >= 70)
                {
                    g[i] = "C";
                }
                else if (perc[i] >= 60)
                {
                    g[i] = "D";
                }
                else
                {
                    g[i] = "F";
                }
            }
            Console.WriteLine("Physics Chemistry Maths Percentage Grade");
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine(
                    marks[i, 0] + " " +
                    marks[i, 1] + " " +
                    marks[i, 2] + " " +
                    perc[i] + " " +
                    g[i]
                );
            }
            
        }


        public static void freq()
        {
            Console.Write("Enter a n: ");
            int num=int.Parse(Console.ReadLine()!);
            int temp=num;
            int c=0;

            while (temp > 0)
            {
                c++;
                temp = temp/ 10;
            }
            int[] digits = new int[c];
            for (int i = 0; i < c; i++)
            {
                digits[i] = num % 10;
                num=num/10;
            }
            int[] freq = new int[10];
            for (int i = 0; i < digits.Length; i++)
            {
                freq[digits[i]]++;
            }
            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine(i + " = " + freq[i]);
                }
            }
        }

    }
}