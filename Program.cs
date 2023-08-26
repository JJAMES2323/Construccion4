using System;
//calculadora
double numerador1 = 0;
double numerador2 = 0;
double denominador1 = 0;
double denominador2 = 0;
string operador;
double numeradorRes = 0;
double denominadorRes = 0;
int opcion = 0;
double temp1 = 0;
double temp2 = 0;
double demcomun = 0;
//tablas
Random random = new Random();
int numeroAleatorio = 0;
int num1 = 0;
int num2 = 0;
int faltante = 0;
//numero especial
int numespecial=0;
int numespctem=0;
int residuo=0;
int suma=0;
//adivinanza
string palabra;
int palabra1=0;
int palabra2=0;
int palabra3=0;
int aciertos=0;
int fallos=0;

do
{

  Console.WriteLine("ingrese 1 para la calculadora de fracciones");
  Console.WriteLine("ingrese 2 para generador de tablas");
  Console.WriteLine("ingrese 3 para numero especial");
  Console.WriteLine("ingrese 4 para adivinanza");
  Console.WriteLine("ingrese 5 para salir");

  opcion = Int32.Parse(Console.ReadLine());

  if (opcion == 1)
  {
    Console.WriteLine("ingrese numerador 1");
    numerador1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("ingrese denominador 1");
    denominador1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("ingrese numerador 2");
    numerador2 = double.Parse(Console.ReadLine());
    Console.WriteLine("ingrese denominador 1");
    denominador2 = Double.Parse(Console.ReadLine());
    Console.WriteLine("ingrese operacion (+,-,/,*)");
    operador = Console.ReadLine();
    if (numerador2 == 0 || denominador2 == 0)
    {
      Console.WriteLine("NO es posible dividir entre 0");
    }
    else if (operador == "+")
    {
      demcomun = denominador1 * denominador2;
      temp1 = (demcomun / denominador1) * numerador1;
      temp2 = (demcomun / denominador2) * numerador2;
      numeradorRes = temp1 + temp2;
      Console.WriteLine(numerador1 + "/" + denominador1 + "+" + numerador2 + "/" + denominador2 + "=" + numeradorRes + "/" + demcomun);
    }
    else if (operador == "-")
    {
      demcomun = denominador1 * denominador2;
      temp1 = (demcomun / denominador1) * numerador1;
      temp2 = (demcomun / denominador2) * numerador2;
      numeradorRes = temp1 - temp2;
      Console.WriteLine(numerador1 + "/" + denominador1 + "-" + numerador2 + "/" + denominador2 + "=" + numeradorRes + "/" + demcomun);
    }
    else if (operador == "/")
    {
      numeradorRes = numerador1 * denominador2;
      denominadorRes = denominador1 * numerador2;
      Console.WriteLine(numerador1 + "/" + denominador1 + "/" + numerador2 + "/" + denominador2 + "=" + numeradorRes + "/" + denominadorRes);
    }
    else if (operador == "*")
    {
      numeradorRes = numerador1 * numerador2;
      denominadorRes = denominador1 * denominador2;
      Console.WriteLine(numerador1 + "/" + denominador1 + "*" + numerador2 + "/" + denominador2 + "=" + numeradorRes + "/" + denominadorRes);
    }
    else
    {
      Console.WriteLine("opcion invalida");
    }
  }
  else if (opcion == 2)
  {
    Console.WriteLine("ingrese el primer numero");
    num1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero");
    num2 = Int32.Parse(Console.ReadLine());

    for (int i = num1; i < (num2 + 1); i++)
    {
        numeroAleatorio=0;
        numeroAleatorio = random.Next(0, 10 + 1);
        Console.WriteLine(numeroAleatorio);              
      for (int i1 = 0; i1 < 11; i1++)
      {
        if (i1 != numeroAleatorio)
        {
          Console.WriteLine(i + "*" + i1 + "=" + (i * i1));
        }
        else
        {
          Console.WriteLine(i + "*" + " " + "=" + (i * i1));
        }
      }
      do
      {
        Console.WriteLine("ingrese numero que falta");
        faltante = Int32.Parse(Console.ReadLine());
        if (faltante == numeroAleatorio)
        {
          Console.WriteLine("correcto");
        }
        else
        {
          Console.WriteLine("vuleve a intentar");
        }
      } while (faltante != numeroAleatorio);

    }
  }else if(opcion==3){
    Console.WriteLine("ingrese un numero");
    numespecial  = Int32.Parse(Console.ReadLine());
    numespctem=numespecial;
    do
    {
      residuo=numespctem%10;
      suma=suma+residuo;
      numespctem=numespctem/10;
    } while (numespctem!=0);
    if (numespecial % 5 == 0 && numespecial % 2 != 0 && numespecial % 3 != 0 && suma >10 ){
      Console.WriteLine("el numero es especial");
    }else{
      Console.WriteLine("el numero no es especial");
    }
  }else if (opcion==4){
do {
    if(palabra1==1 && palabra2==1 && palabra3==1){
      Console.WriteLine("El gato juega en el jardin.");
    }else if (palabra1==1 && palabra2==0 && palabra3==0)
    {
      Console.WriteLine("El gato juega __ el ______.");
    }else if(palabra2==1 && palabra1==0 && palabra3==0){
      Console.WriteLine("El ____ juega en el ______.");
    }else if (palabra3==1 && palabra1==0 && palabra2==0)
    {
      Console.WriteLine("El ____ juega __ el jardin.");
    }else if (palabra1==1 && palabra2==1 && palabra3==0)
    {
      Console.WriteLine("El gato juega en el ______.");
    }else if (palabra3==1 && palabra1==1 && palabra2==0)
    {
      Console.WriteLine("El gato juega __ el jardin.");
    }else if(palabra2==1 && palabra3==1 && palabra2==0){
      Console.WriteLine("El ____ juega en el jardin.");
    }else{
      Console.WriteLine("El ____ juega __ el ______.");
    }
    Console.WriteLine("Ingrese alguna de las palabras que faltan:");
    palabra = Console.ReadLine().ToLower();

    if (palabra1 == 0 && palabra == "gato") {
        Console.WriteLine("Has acertado");
        aciertos++;
        fallos++;
        palabra1 = 1;
    } else if (palabra2 == 0 && palabra == "en") {
        Console.WriteLine("Has acertado");
        aciertos++;
        fallos++;
        palabra2 = 1;
    } else if (palabra3 == 0 && palabra == "jardin") {
        Console.WriteLine("Has acertado");
        aciertos++;
        fallos++;
        palabra3 = 1;
    } else {
        Console.WriteLine("Has fallado");
        fallos++;
    }
} while (aciertos < 3 && fallos < 10);
    if(aciertos==3){
      Console.WriteLine("felicidades la frase era el gato juega en el jardin");
    }else{
      Console.WriteLine("has perdido");
    }

  }
} while (opcion != 5);