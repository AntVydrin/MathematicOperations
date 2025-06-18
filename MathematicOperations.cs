using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

//using Math;

//Взятие интеграла, анализ по Фурье, работа с матрицами, решение линейной системы уравнений.
namespace Mathematic
{
    

   public class MathematicOperations
    {

       /// <summary>
       /// Взять интеграл методом симпсона
       /// </summary>
       /// <param name="values"></param>
       /// <param name="x1"></param>
       /// <param name="x2"></param>
       /// <returns></returns>
        static public double IntegraL(List<WorkWithFunct.ValuePoint> values, double x1, double x2)
        {
            double h = (x2 - x1) / (values.Count);   //h = (x2 - x1) / (2 * values.Count * 2);

            #region Добавка от 14янв 2020            
            for(int j=1;j<values.Count;j++)
            {
                if (Math.Abs(values[j].x - values[j - 1].x) < h)
                    h = Math.Abs(values[j].x - values[j - 1].x);
            }
            #endregion Добавка от 14янв 2020

            if ((x2 - x1) / (5) < 0.01)
                h = (x2 - x1) / (5);

           
           /* if (h < 0.001)
            {
                for (int nh = 500; nh >= 5; nh = nh / 2)
                {
                    if (((x2 - x1) / (2 * nh)) >= 0.001)
                    {
                        h = (x2 - x1) / (2 * nh);
                        break;
                    }
                }
            }*/

          //  h = 0.001;

            double integraL1 = 0.0, integraL2 = 0.0;
            //int iN = (int)((x2 - x1) / h);
            int i = 1;
            for (double hi = x1 + h; hi < x2; hi += h)
            {
                {
                    if ((i % 2) == 0)
                    {
                        integraL2 += WorkWithFunct.WorkWithFunction.GivePoint(hi, values);
                    }
                    else
                        integraL1 += WorkWithFunct.WorkWithFunction.GivePoint(hi, values);
                }
                i++;
            }
            return ((h / 3.0) * (WorkWithFunct.WorkWithFunction.GivePoint(x1, values) + 4.0 * integraL1 + 2.0 * integraL2 + WorkWithFunct.WorkWithFunction.GivePoint(x2, values)));

            
        }

        /// <summary>
        /// Взять интеграл методом симпсона
        /// </summary>
        /// <param name="values"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        static public double IntegraL(List<WorkWithFunct.ValuePoint> values, double x1, double x2, double step)
        {
            double h = step;           

            double integraL1 = 0.0, integraL2 = 0.0;
            //int iN = (int)((x2 - x1) / h);
            int i = 1;
            for (double hi = x1 + h; hi < x2; hi += h)
            {
                {
                    if ((i % 2) == 0)
                    {
                        integraL2 += WorkWithFunct.WorkWithFunction.GivePoint(hi, values);
                    }
                    else
                        integraL1 += WorkWithFunct.WorkWithFunction.GivePoint(hi, values);
                }
                i++;
            }
            return ((h / 3.0) * (WorkWithFunct.WorkWithFunction.GivePoint(x1, values) + 4.0 * integraL1 + 2.0 * integraL2 + WorkWithFunct.WorkWithFunction.GivePoint(x2, values)));
        }

       /// <summary>
       /// Посчитать интеграл методом трапеций
       /// </summary>
       /// <param name="values"></param>
       /// <param name="x1"></param>
       /// <param name="x2"></param>
       /// <returns></returns>
        static public double IntegraL_trap(List<WorkWithFunct.ValuePoint> values, double x1, double x2)
        {
            double Ibegin = 0, Iend = 0, sum = 0, h;

            h = (x2 - x1) / (values.Count-1);
            if( ((x2 - x1)*3)<=0.01)
                h = 0.01;

            for (int i = 1; i < values.Count - 1; i++)
            {
                sum += values[i].y;
            }

            Ibegin = values[0].y;
            Iend = values[values.Count - 1].y;

            return ((0.5 * (Ibegin + Iend) + sum) * h);
        }

       


       /*
        * /// <summary>
       /// Взять интеграл методом симпсона
       /// </summary>
       /// <param name="values"></param>
       /// <param name="x1"></param>
       /// <param name="x2"></param>
       /// <returns></returns>
        static public double IntegraL(List<WorkWithFunct.ValuePoint> values, double x1, double x2)
        {
            double h = (x2 - x1) / (2 * values.Count*2);   //h = (x2 - x1) / (2 * values.Count * 2);
            
            if ((x2 - x1) / (5) < 0.01)
                h = (x2 - x1) / (5);
            if (h < 0.001)
            {
                for (int nh = 500; nh >= 5; nh = nh / 2)
                {
                    if (((x2 - x1) / (2 * nh)) >= 0.001)
                    {
                        h = (x2 - x1) / (2 * nh);
                        break;
                    }
                }
            }
            
            double integraL1 = 0.0, integraL2 = 0.0;
            //int iN = (int)((x2 - x1) / h);
            int i = 1;
            for (double hi = x1 + h; hi < x2; hi += h)
            {
                {
                    if ((i % 2) == 0)
                    {
                        integraL2 += WorkWithFunct.WorkWithFunction.GivePoint(hi, values);
                    }
                    else
                        integraL1 += WorkWithFunct.WorkWithFunction.GivePoint(hi, values);
                }
                i++;
            }
            return ((h / 3.0) * (WorkWithFunct.WorkWithFunction.GivePoint(x1, values) + 4.0 * integraL1 + 2.0 * integraL2 + WorkWithFunct.WorkWithFunction.GivePoint(x2, values)));

                  
            //double integraL2 = 0.0;
            //for (int i = 0; i < values.Count-1; i++)
            //{
            //    if (values[i].x >= x1 && values[i].x <= x2)
            //        integraL2 += 0.5 * (values[i+1].y + values[i].y) * (values[i + 1].x - values[i].x);
            //}
            //    return integraL2;
            
        }


       */
       

        /// <summary>
        /// Простые числа
        /// </summary>
       static public int[] simpleNumber = { 1,3,5,7,11,13,17,19,23,29,31,37,
                                            41,43,47,53,59,61,67,71,73,79,83,89,97,101,
                                            103,107,109,113,127,131,137,139,149,151,157,
                                            163,167,169,173,179,181,191,193,197,199 };
    }

    /// <summary>
    /// Класс работы с матрицей
    /// </summary>
   public class Matrix
    {
       double determinant;
        double[][] a;
        public double[][] A
        {
            get 
            {                
                return a; 
            }
            set { a = value; }
        }

        double[][] algAdditional;

        double[][] inverse;
        /// <summary>
        /// Обратная матрица
        /// </summary>
        public double[][] Inverse
        { 
            get
            {                
                inverse = InverseMatrix();
                return inverse;
            }            
        }

        /// <summary>
        /// Размер матрицы
        /// </summary>
        int n;

        /// <summary>
        /// Создать матрицу, размером N
        /// </summary>
        /// <param name="matrixN"></param>
        public Matrix(int N)
        { 
            n=N;
            a = new double[n][];
            for (int i = 0; i < n; i++)
                a[i] = new double[n];
        }

        public Matrix(double[][] m)
        {
            n = m.Length;
            //if(m[0].Length)
            a = new double[n][];
            for (int i = 0; i < n; i++)
                a[i] = new double[n];

            algAdditional = new double[n][];
            for (int i = 0; i < n; i++)
                algAdditional[i] = new double[n];


            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i][j] = m[i][j];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    algAdditional[i][j] = AlgAdditionaL(i, j);

            determinant = Find_determinant(a, n);

        }

        /// <summary>
        /// Поиск определителя матрицы
        /// </summary>
        /// <returns></returns>
        public double Determinant()
        {
          return Find_determinant(a, n);
        }

        /// <summary>
        /// Поиск определителя матрицы
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        double Find_determinant(double[][] matr,int n)//Поиск определителя матрицы
        {

            double ret = 0;
            double[][] am;
            if (n == 2)
                ret = matr[0][0] * matr[1][1] - matr[0][1] * matr[1][0];
            else //if (n > 1)
            {
                am = new double[n][];
                for (int i = 0; i < n; i++)
                    am[i] = new double[n];
                for (int i = 0; i < n; i++)//Цикл по элементам нулевой строки
                {
                    //Запись новой матрицы [n-1][n-1]_Begin
                    for (int row = 0; row < (n - 1); row++)//Запись новой матрицы [n-1][n-1]
                        for (int coLi = 0, coL = 0; coLi < (n); coLi++)//Запись новой матрицы [n-1][n-1]
                        {
                            if (coLi != i)
                            {
                                am[row][coL] = matr[row + 1][coLi];
                                coL += 1;
                            }
                        }
                    //Запись новой матрицы [n-1][n-1] _End               
                    ret = ret + matr[0][i] * Math.Pow(-1.0, i) * Find_determinant(am, n - 1);
                }
                //for( int i=0; i<n; i++ )
                //    {delete am[i]; am[i]=NULL; }
                // delete[] am; am=NULL;
            }
          /*  else //n==1
            {
                ret = matr[0][0];
            }*/
            return ret;
        }

        /// <summary>
        /// Транспонирование матрицы
        /// </summary>
        /// <returns></returns>
        public double[][] TransponMatrix()
        {
            int n = a[0].Length;
            double[][] ret;
            ret = new double[n][];
            for (int i = 0; i < n; i++)
                ret[i] = new double[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ret[i][j] = a[j][i];
                }
            }
            return ret;
        }

        /// <summary>
        /// Транспонирование матрицы, поданной на вход
        /// </summary>
        /// <param name="matr"></param>
        /// <returns></returns>
        public double[][] TransponMatrix(double[][] matr)
        {
            int n = a[0].Length;
            double[][] ret;
            ret = new double[n][];
            for (int i = 0; i < n; i++)
                ret[i] = new double[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ret[i][j] = matr[j][i];
                }
            }
            return ret;
        }

        /// <summary>
        /// Обратная матрица
        /// </summary>
        /// <returns></returns>
        double[][] InverseMatrix()
        {
            int n = a[0].Length;
            double[][] ret;
            ret = new double[n][];
            for (int i = 0; i < n; i++)
                ret[i] = new double[n];

            for (int i = 0; i < n;i++ )
                for (int j = 0; j < n; j++)
                {
                    //if (Math.Abs(determinant) < 0.0000000001) 
                        //System.Windows.Forms.MessageBox.Show("determinant"+determinant.ToString());
                    ret[i][j] = algAdditional[i][j] / determinant; //AlgAdditionaL(i, j) / determinant;//Determinant();
                }
            ret = TransponMatrix(ret);

                return ret;
        }

        /// <summary>
        /// Алгеброическое дополнение элемента a[i,j]
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
      public  double AlgAdditionaL(int n1, int n2)
        {
            double[][] temp = new double[n - 1][];
            for (int k = 0; k < n-1; k++)
            {
                temp[k] = new double[n - 1];
            }

            int i1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != n1)
                {
                    int j1 = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != n2)
                        {
                            temp[i1][j1] = a[i][j];
                            j1++;
                        }
                    }
                    i1++;
                }
            }

            if (n > 2)
                return Math.Pow(-1, n1 + n2) * Find_determinant(temp, n - 1);
            else //Если на вход подаётся матрица 2x2
                return Math.Pow(-1, n1 + n2)*temp[0][0];
        }


      public static double[] operator *(Matrix matrix, double[] vector)
      {
          double[] ret = new double[matrix.n];
          if (matrix.n == vector.Length)
          {              
              for (int i = 0; i < matrix.n; i++)
              {
                  double temp = 0;
                  for (int j = 0; j < matrix.n; j++)
                  {
                      temp += matrix.A[i][j] * vector[j];
                  }
                  ret[i] = temp;
              }
          }
          return ret;
      }

    }

    /// <summary>
    /// Решение системы линейных уравнений
    /// </summary>
    public class LinearEquation
    {
        public double[][] LeftMatr
        {
            get
            {
                if (leftMatr.A!=null)
                    return leftMatr.A;
                return null;
            }
            set
            { leftMatr.A = value; }
        }

        Mathematic.Matrix leftMatr;        
        int n=0;

        public LinearEquation(double[][] leftPart)
        {
            n = leftPart.Length;
            leftMatr = new Mathematic.Matrix(leftPart);
        }

        public double[] X(double[] right)
        {
            
            double[] ret = new double[n];
            for (int i = 0; i < n; i++)
            {
                double temp = 0;
                for (int j = 0; j < n; j++)
                {
                    temp += leftMatr.Inverse[i][j] * right[j];
                }
                ret[i] = temp;
            }
            return ret;     
        }
    }

    /// <summary>
    /// Разложение реализации в ряд Фурье. Поиск амплитуд по частотам
    /// </summary>
    public class Fourier
    {
        List<WorkWithFunct.ValuePoint> reA;
        public List<WorkWithFunct.ValuePoint> ReA
        {
            get { return reA; }
        }
        List<WorkWithFunct.ValuePoint> imA;
        public List<WorkWithFunct.ValuePoint> ImA
        {
            get { return imA; }
        }

        List<WorkWithFunct.ValuePoint> absA;
        public List<WorkWithFunct.ValuePoint> AbsA
        {
            get { return absA; }
        }

        /// <summary>
        /// Амплитуды при косинусах
        /// </summary>
        List<WorkWithFunct.ValuePoint> an;
        public List<WorkWithFunct.ValuePoint> An
        {
            get { return an; }
        }

        /// <summary>
        /// Амплитуды при синусах
        /// </summary>
        List<WorkWithFunct.ValuePoint> bn;
        public List<WorkWithFunct.ValuePoint> Bn
        {
            get { return bn; }
        }


        public Fourier()
        {
            reA = new List<WorkWithFunct.ValuePoint>();
            imA = new List<WorkWithFunct.ValuePoint>();
            absA = new List<WorkWithFunct.ValuePoint>();
            an = new List<WorkWithFunct.ValuePoint>();
            bn = new List<WorkWithFunct.ValuePoint>();
        }

        /// <summary>
        /// Разложить входные данные в ряд, учитывая частоты от omMin до omMax
        /// </summary>
        /// <param name="points"></param>
        /// <param name="omMin"></param>
        /// <param name="omMax"></param>
        public void Fseries(List<WorkWithFunct.ValuePoint> points, double omMin, double omMax)
        {
            double Tend = points[points.Count - 1].x - points[0].x;
            #region Поиск амплитуд при косинусах и синусах
            double integraL = 0.0;
            int k0 = (int)(Math.Round(omMin * Tend / (Math.PI))), kEnd = (int)(Math.Round(omMax * Tend / (Math.PI)));
            if (k0 == 0) 
                k0 = 1;
            if (k0 > kEnd) kEnd = k0 + 1;

            //a0
            integraL = 0;
            for (int i = 1; i < points.Count; i++)
            {
                integraL += 0.5 * (points[i].y + points[i - 1].y) * (points[i].x - points[i - 1].x);
            }
            //integraL += 0.5 * (points[].y + points[i - 1].y) * (points[i].x - points[i - 1].x);
            an.Add(new WorkWithFunct.ValuePoint( 0.0, integraL / Tend));//a0
            //a0

            for(int k=k0;k<kEnd;k++)
            {
              integraL=0;
              for (int i = 1; i < points.Count; i++)
              {
                  integraL += 0.5 * ((points[i].y * Math.Cos(k * Math.PI * points[i].x / Tend) + points[i - 1].y * Math.Cos(k * Math.PI * points[i-1].x / Tend))) * (points[i].x - points[i - 1].x);
              }              
              an.Add(new WorkWithFunct.ValuePoint(k * Math.PI/ Tend, integraL/Tend));

              integraL = 0;
              for (int i = 1; i < points.Count; i++)
              {
                  integraL += 0.5 * ((points[i].y * Math.Sin(k * Math.PI * points[i].x / Tend) + points[i - 1].y * Math.Sin(k * Math.PI * points[i - 1].x / Tend))) * (points[i].x - points[i - 1].x);
              }              
              bn.Add(new WorkWithFunct.ValuePoint(k * Math.PI / Tend, integraL / Tend));
            }
            #endregion Поиск амплитуд при косинусах и синусах
        }

       
        public List<WorkWithFunct.ValuePoint> FRealization(double t0, double Tend, double dt)
        {
            List<WorkWithFunct.ValuePoint> value = new List<WorkWithFunct.ValuePoint>();
            

            for(double t=t0;t<=Tend;t+=dt)
            {
                double v=0;
                for (int k = 0; k < bn.Count; k++)
            {
                v += an[k+1].y * Math.Cos(an[k+1].x * t) + bn[k].y * Math.Sin(bn[k].x * t);
            }
            v += an[0].y / 2.0;
            value.Add(new WorkWithFunct.ValuePoint(t, v));
            }


            return value;
        }

        /// <summary>
        /// Прямое преобразование Фурье
        /// </summary>
        /// <param name="points"></param>     
        public void Transform(List<WorkWithFunct.ValuePoint> points)//, double omMin, double omMax)
        {            
            double dT = (points[points.Count-1].x - points[0].x) / (points.Count-1);
            int N = points.Count;
            //for (double om=omMin; om<=omMax; om+=dkOm)
            for (int k = 0; k < N; k++)
            {
                double re = 0, im = 0;
                for (int i = 0; i < N; i++)
                {
                    re += points[i].y * Math.Cos(2 * Math.PI * i * k / N);
                    im += points[i].y * Math.Sin(2 * Math.PI * i * k / N);
                }
                reA.Add(new WorkWithFunct.ValuePoint(2 * Math.PI * k / (N * dT), re));
                imA.Add(new WorkWithFunct.ValuePoint(2 * Math.PI * k / (N * dT), im));
                absA.Add(new WorkWithFunct.ValuePoint(2 * Math.PI * k / (N * dT), Math.Sqrt(re * re + im * im)));
            }
            


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        public void InverseTransform(List<WorkWithFunct.ValuePoint> points)
        { 
         
        }


    }

}
