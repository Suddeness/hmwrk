using System;
using System.IO;
namespace Lb10
{
    internal class Program
    {
        //task1
        static double TryD(string x)
        {
            if (Double.TryParse(x, out double d))
            {
                return d;
            }
            Console.WriteLine($"value {x} can't parse to double, returning 0");
            return 0;
        }
        static void Formula(string patch)
        {
            if (!File.Exists(patch)) { Console.WriteLine("file not found"); return; }
            double k = 2;
            double xmin, xmax, dx, x, result;
            using (StreamReader sr = new StreamReader(patch))
            {
                xmin = TryD(sr.ReadLine());
                xmax = TryD(sr.ReadLine());
                dx = TryD(sr.ReadLine());
                string newpatch = Path.Combine(Path.GetDirectoryName(patch), Path.GetFileNameWithoutExtension(patch) + "new" + Path.GetExtension(patch));
                using (StreamWriter sw = new StreamWriter(newpatch))
                {
                    for (x = xmin; x <= xmax; x += dx)
                    {
                        if (Math.Sin(k * x) <= 0 || Math.Tan(k * x) == 0)
                        {
                            Console.WriteLine($"Error / by 0 for x = {x}");
                            sw.WriteLine($"Error / by 0 for x = {x}"); continue;
                        }
                        result = (Math.Pow((1 / Math.Tan(k * x)), 1.0 / 3.0)) + ((Math.Cos(k * x) / (Math.Log(Math.Sin(k * x)))));
                        Console.WriteLine($"result={result} for x = {x}");
                        sw.WriteLine($"x({x})-->result({result})");
                    }
                }
            }
        }
        //task2
        static void matrix(string patch)
        {
            int masv_ram = 0;
            int count = 0;
            using (StreamReader sr = new StreamReader(patch))
            {
                while (sr.ReadLine() != null) { count++; }
                string[] lines = File.ReadAllLines(patch);
                int lineCount = lines.Length;
                for (int i = 0; i < lineCount; i++) 
                {
                    if (string.IsNullOrWhiteSpace(lines[i]) && !string.IsNullOrWhiteSpace(lines[i + 1]))
                    {
                        masv_ram = i; break;                 
                    }
                }              
                double[][] matrix1 = new double[masv_ram][];
                double[][] matrix2 = new double[lineCount - masv_ram - 1][];

                void fillMatrix(int start, int end, double[][] matrix)
                {
                    Console.WriteLine("\nprevious matrix");
                    for (int i = start; i < end; i++)
                    {
                        matrix[i - start] = lines[i].Split(',').Select(el => TryD(el)).ToArray();   
                        Console.WriteLine($"{matrix[i - start][0]} {matrix[i - start][1]}");                    
                    }
                }
                fillMatrix(0, masv_ram, matrix1);
                fillMatrix(masv_ram + 1, lineCount, matrix2);
               
                int rows1 = matrix1.Length;
                int cols1 = matrix1[0].Length;
                int rows2 = matrix2.Length;
                int cols2 = matrix2[0].Length;
                if (cols1 == rows2)
                {
                    string newpatch = Path.Combine(Path.GetDirectoryName(patch), Path.GetFileNameWithoutExtension(patch) + "new" + Path.GetExtension(patch));
                    using (StreamWriter sw = new StreamWriter(newpatch))
                    {
                        Console.WriteLine("\nnew matrix:");
                        for (int i = 0; i < rows1; i++)
                        {
                            double[] line = new double[cols2];
                            for (int j = 0; j < cols2; j++)
                            {
                                double sum = 0;
                                for (int k = 0; k < cols1; k++)
                                {                                  
                                    sum += matrix1[i][k] * matrix2[k][j];                                  
                                }                               
                                line[j] = sum;
                            }
                            for (int hg = 0; (hg < line.Length); hg += 2)
                            {
                                sw.WriteLine($"{line[hg]}, {line[hg + 1]}");
                                Console.WriteLine($"{line[hg]}, {line[hg + 1]}");
                            }
                        }
                    }
                }               
            }
        }
        static void Main()
        {
            Formula("G:\\C#projects\\data.txt");
            matrix("G:\\C#projects\\matrix.csv");
        }
    }
}
