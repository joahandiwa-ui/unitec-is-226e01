// Archivo: ./src/ConsoleApp262E01/Program.cs

// 1. Declaración de variables
double lado1 = 5;
double lado2 = 6;
double Base =8;
double altura =10;
double Altura =12;   
// Variable preparada para futuros cálculos de volumen

// 2. Consumo de la Librería de Clases (Invocación de métodos estáticos)
double perimetro = Figura262.Perimetro(lado1,lado2,Base);
double area = Figura262.Area(Base,altura);
double Volumen = Figura262. Volumen(area,Altura);

// 3. Salida en Consola
Console.WriteLine($"El perímetro de la base de un triangulo de lado de {lado1}cm, de lado {lado2}cm, de base de {Base}cm es {perimetro}cm");
Console.WriteLine($"El área de un triangulo de Base de {Base}cm por altura de {altura}cm es {area}cm^2");
Console.WriteLine($"El Volumen de un triangulo con el area de base de {area}cm^2 con una altura de {Altura}cm es el {Volumen}cm^3");