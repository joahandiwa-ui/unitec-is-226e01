public class UnitTestApplication
{
// PRUEBA 1: PERÍMETRO
[Theory]
[InlineData(6, 5, 7, 18)] // Lado 2 -> Perímetro 8
[InlineData(4, 6, 5, 15)] // Lado 5 -> Perímetro 20
[InlineData(2, 8, 4, 14)] // Lado 10 -> Perímetro 40
public void CalcularPerimetroTriangulo_LadoValido_Correcto(double lado1, double lado2, double Base, double expected)
{
// Arrange
// (No necesitamos Arrange para inicializar objetos porque el método es estático)
// Act
// Llamamos al método directamente usando el nombre de la clase (Figura)
double actual = Figura262.Perimetro(lado1, lado2, Base);
// Assert
Assert.Equal(expected, actual);
}
// continua área
// Continuación
// PRUEBA 2: ÁREA
[Theory]
[InlineData(6, 5, 15)] // Lado 2 -> Área 4
[InlineData(4, 6, 12)] // Lado 5 -> Área 25
[InlineData(2, 8, 8)] // Lado 10 -> Área 100
[InlineData(3, 8, 12)]
[InlineData(16, 2, 16)]
public void CalcularAreaCuadrado_LadoValido_Correcto(double Altura, double Base, double expected)
{
// Arrange
// Act
double actual = Figura262.Area(Base, Altura);
// Assert
Assert.Equal(expected, actual);
}
// continua volumen
// Continuación
// PRUEBA 3: VOLUMEN (CUBO)
[Theory]
[InlineData(4, 2, 8)] // Área 4, Altura 2 -> Volumen 8
[InlineData(9, 3, 27)] // Área 9, Altura 3 -> Volumen 27
[InlineData(25, 5, 125)] // Área 25, Altura 5 -> Volumen 125
[InlineData(23, 2, 46)]
[InlineData(20, 3, 60)]
[InlineData(10, 4, 40)]

public void CalcularVolumenCubo_AreaYAlturaValidas_Correcto(double area, double Altura, double expected)
{
// Arrange
// Act
double actual = Figura262.Volumen(area, Altura);
// Assert
Assert.Equal(expected, actual);
}
}