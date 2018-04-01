using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcialExamen
{
    public class menu
    {
        int op;
        string respuesta = "";
        public void getMenu()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Ingrese un numero del 1 al 6 para ir al respectivo ejercicio, 7 para salir");
                op = int.Parse(Console.ReadLine());
            }
            catch { getMenu(); }

            switch (op)
            {
                case 1:
                    ejercicio1 aa = new ejercicio1();
                    aa.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                    else getMenu();
                    break;
                case 2:
                    ejercicio2 ab = new ejercicio2();
                    ab.inicio();

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                    else getMenu();
                    break;
                case 3:
                    ejercicio3 ac = new ejercicio3();
                    ac.inicio3();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 4:
                    ejercicio4 ad = new ejercicio4();
                    ad.inicio4();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                    else getMenu();
                    break;
                case 5:
                    ejercicio5 ae = new ejercicio5();
                    ae.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 5; }
                    else getMenu();
                    break;
                case 6:
                    ejercicio6 af = new ejercicio6();
                    af.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 6; }
                    else getMenu();
                    break;
                case 7:
                    break;
                    default:
                    getMenu();
                    break;
            }

        }
    }
    
    public class ejercicio1

    {
        string miCadena = "";
        char[] cadenaAux;
        int n,m,cont=0;
        public ejercicio1() { }
        public void inicio()
        {
            Console.Write("Ingrese la cadena que quiera veificar si es palindrome o no ");
            miCadena = Console.ReadLine();
            n = miCadena.Length;
            m = n - 1;
            cadenaAux = new char[n];
            for(int i = 0; i < n; i++)
            {
                 cadenaAux[i] = miCadena[m - i];
               // Console.WriteLine(n);
            }
            for(int j=0;j< n;j++)
            {
                if(cadenaAux[j] == miCadena[j])
                {
                    cont++;
                }
            }
            if (cont == n)
            {
                Console.WriteLine(miCadena + " es palindrome");

            }else Console.WriteLine(miCadena + " no es palindrome");
        }
    }
    public class ejercicio2
    {
        string nombre;
        int edad,diaNac,mesNac,añoNac;

        public void inicio()
        {
            Console.Write("Dame tu nombre == >");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}", nombre.ToUpper());
            Console.WriteLine("Digita tu fecha de nacimiento: ");
            //Dia de nacimiento
            Console.Write("Dia de nacimiento: ");
            diaNac = int.Parse(Console.ReadLine());
            while (diaNac <= 0 || diaNac > 31) 
            {  Console.WriteLine("Por favor, digite un dia entre 1 y 31");
                Console.Write("Dia de nacimiento: ");
                diaNac = int.Parse(Console.ReadLine());
            } 
            //Mes de nacimiento
            Console.Write("Mes de nacimiento ==> ");
            mesNac = int.Parse(Console.ReadLine());
            while (mesNac <= 0 || mesNac > 12) 
            {
                Console.WriteLine("Por favor, digite un dia entre 1 y 12 ");
                Console.Write("Mes de nacimiento ==> ");
                mesNac = int.Parse(Console.ReadLine());
            } 
            //año de nacimiento
          
            Console.Write("Año de nacimiento ==> ");
            añoNac = int.Parse(Console.ReadLine());
            while (añoNac <= 1900 || añoNac > 2017) 
            {
                Console.WriteLine("Por favor, digite un dia entre 1900 y 2017");
                Console.Write("Año de nacimiento ==> ");
                añoNac = int.Parse(Console.ReadLine());
            } 
            edad = DateTime.Now.Year - añoNac;
            Console.WriteLine(nombre+" tu edad es: "+edad);


        }
    }
    public class ejercicio3
    {
        string a;
         int e = 0, f, g, h, x, y, i, o, u, aa,v;
        int tot;
        
        public void inicio3()
        {
           
                Console.Clear();
                x = 0;
                aa = 0;
                e = 0;
                i = 0;
                o = 0;
                u = 0;
                llenado();
                for (int j = 0; j < a.Length; j++)
                {
                    switch (a[j])
                    {
                        case 'a':
                            x++;
                            aa++;
                            break;
                        case 'e':
                            x++;
                            e++;
                            break;
                        case 'i':
                            x++;
                            i++;
                            break;
                        case 'o':
                            x++;
                            o++;
                            break;
                        case 'u':
                            x++;
                            u++;
                            break;
                    case ' ':
                        v++;
                        break;
                    case '0':
                        
                        tot++;
                        break;
                    case '1':
                        
                        tot++;

                        break;
                    case '2':
                       
                        tot++;

                        break;
                    case '3':
                        tot++;
                        break;
                    case '4':
                        
                        tot++;
                        break;
                    case '5':
                        
                        tot++;
                        break;
                    case '6':
                        
                        tot++;
                        break;
                    case '7':
                       
                        tot++;
                        break;
                    case '8':
                       
                        tot++;
                        break;
                    case '9':
                      
                        tot++;
                        break;

                    default:
                            break;
                    }
                }

                Console.WriteLine("La cantidad de vocales es: " + x);
                Console.WriteLine("La cantidad de letras es: " + (a.Length-v- tot-x));
                Console.WriteLine("La cantidad de digitos es: " + tot);
                Console.WriteLine("La cantidad de caracteres vacios es: " + v);
                

                
        }
        private void llenado()
        {
            Console.Write("Ingrese una cadena: ");
            a = Console.ReadLine();
        }
    }
    public class ejercicio4
    {
        float[] notas;
        float promedioA=0, promedioR=0, promedio=0,a=0,r=0;
        int n;
        public ejercicio4() { }
        public void inicio4()
        {
            Console.Clear();
            Console.Write("Que cantidad de notas quiere ingresar?");
            n = int.Parse(Console.ReadLine());
            notas = new float[n];
            
            for(int i =0;i< n; i++)
            {
                Console.Write("Digite la nota {0}: ", (i + 1));
                notas[i] = float.Parse(Console.ReadLine());
                while (notas[i] < 0 || notas[i] > 100)
                {
                    Console.WriteLine("Nota no valida, intentelo otra vez ");
                    Console.Write("Digite la nota {0}: ", (i + 1));
                    notas[i] = float.Parse(Console.ReadLine());
                } 
            }
            for(int j =0; j< n; j++)
            {
                if (notas[j] >= 51)
                {
                    promedioA += notas[j];
                    a++;
                }else if (notas[j] < 51)
                {
                    promedioR += notas[j];
                    r++;
                }
                promedio += notas[j];
            }
            promedioA /= a;
            promedioR /= r;
            promedio /= n;
            Console.Write("La cantidad de aprobados es: "+a+" El promedio de los aprobados es: " + promedioA+"\n");
            Console.Write("La cantidad de reprobados es: "+r+" El promedio de los reprobados es: " + promedioR + "\n");
            Console.Write("La cantidad de notas es: "+n+" El promedio de llas notas es: " + promedio + "\n");
        }
    }
    public class ejercicio5
    {
        int[] vectorU, vectorD, vectorUn;
        int m, n;
        public void inicio()
        {
            Console.Write("Ingrese la longitud del vector A: ");
                m = int.Parse(Console.ReadLine());
            vectorU = new int[m];
            for (int i =0; i <m; i++)
            {
                
                Console.Write("Ingrese dato vector A {0}: ", (i+1));
                vectorU[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El vector A es: ");
            for(int k =0;k< m; k++)
            {
                Console.Write("[{0}] ", vectorU[k]);
            }
            Console.Write("Ingrese la longitud del vector B: ");
            n = int.Parse(Console.ReadLine());
            vectorD = new int[n];
            for (int i = 0; i < n; i++)
            {

                Console.Write("Ingrese dato vector B {0}: ", (i + 1));
                vectorD[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El vector B es: ");
            for (int k = 0; k < m; k++)
            {
                Console.Write("[{0}] ", vectorD[k]);
            }
            vectorUn = new int[n + m];
            for(int o=0;o<m; o++)
            {
                vectorUn[o] = vectorU[o];
            }
            for (int o = m; o < (n + m); o++)
            {
                vectorUn[o] = vectorD[o-m];
            }
            
            Console.WriteLine("\nLa union de los vectores es: ");
            for (int k = 0; k < n+m; k++)
            {
                Console.Write("[{0}] ", vectorUn[k]);
            }
            //burbuja();
            Array.Sort(vectorUn);
            Array.Reverse(vectorUn);
            Console.WriteLine("\nEl vector ordenado de mayor a menor es: ");
            for (int k = 0; k < n + m; k++)
            {
                Console.Write("[{0}] ", vectorUn[k]);
            }
            Console.WriteLine();
        }
        private void burbuja()
        {
            int t;
            for (int i = 1; i < vectorUn.Length; i++)
                for (int b = vectorUn.Length - 1; b >= i; b--)
                {
                    if (vectorUn[b - 1] < vectorUn[b])
                    {
                        t = vectorUn[b - 1];
                        vectorUn[b - 1] = vectorUn[b];
                        vectorUn[b] = t;
                    }
                }
        }
    }
    public class ejercicio6
    {
        protected int[,] matrizUno, matrizDos, matrizTres;
        
        protected int a = 0, b, c = 0, d = 0, m, n, i, j, p;
        protected float pp;
        protected float[] det, det1;
        public void inicio()
        {
            Console.Write("Ingrese las  dimensiones de su matriz: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            llenado(n, m);
            mostrar(n, m, matrizUno);
            Console.Write(" Ultima fila ");
                for (int j = 0; j < m; j++)
                {  Console.Write(" "+matrizUno[n-1,j]);
                p += matrizUno[n - 1, j];

                }
            Console.WriteLine("\nLa suma es: " + p);
        }
        protected void llenado(int n, int m)
        {
            Console.WriteLine("Matriz uno");
            matrizUno = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Ingrese el valor para la posicion {0},{1} ", i, j);
                    matrizUno[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        protected void mostrar(int n, int m, int[,] matriz)
        {
            Console.Clear();
            Console.WriteLine("Mostrando resultado... ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" [{0}] ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // menu p = new menu();
            // p.getMenu();
            ListViewxD obj = new ListViewxD();
            obj.Show();
            Console.ReadKey();
        }
    }
}
