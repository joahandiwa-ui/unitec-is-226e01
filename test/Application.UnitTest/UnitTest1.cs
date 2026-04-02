public class UnitTestApplication
{
// PRUEBA 1: PERÍMETRO
[Theory]
[InlineData(6, 5, 7, 18)] // Lado 2 -> Perímetro 8
[InlineData(4, 6, 5, 15)] // Lado 5 -> Perímetro 20
[InlineData(2, 8, 4, 14)] // Lado 10 -> Perímetro 40
[InlineData(3, 4, 5, 12)]
[InlineData(5, 12, 13, 30)]
[InlineData(10, 10, 10, 30)]
[InlineData(6, 8, 10, 24)]
[InlineData(7, 24, 25, 56)]
[InlineData(8, 15, 17, 40)]
[InlineData(9, 40, 41, 90)]
[InlineData(11, 60, 61, 132)]
[InlineData(12, 35, 37, 84)]
[InlineData(20, 21, 29, 70)]
[InlineData(2, 2, 3, 7)]
[InlineData(5, 5, 8, 18)]
[InlineData(10, 10, 5, 25)]
[InlineData(1.5, 2.5, 3.5, 7.5)]
[InlineData(0.5, 0.5, 0.5, 1.5)]
[InlineData(100, 100, 100, 300)]
[InlineData(15, 20, 25, 60)]
[InlineData(1, 1, 1, 3)]
[InlineData(50, 40, 30, 120)]
[InlineData(9, 9, 9, 27)]
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
// PRUEBA 2: ÁREA (cuadrado)
[Theory]
[InlineData(6, 5, 15)] // Lado 2 -> Área 4
[InlineData(4, 6, 12)] // Lado 5 -> Área 25
[InlineData(2, 8, 8)] // Lado 10 -> Área 100
[InlineData(3, 8, 12)]
[InlineData(16, 2, 16)]
[InlineData(10, 5, 25)]
[InlineData(4, 3, 6)]
[InlineData(6, 8, 24)]
[InlineData(5, 10, 25)]
[InlineData(20, 10 ,100)]
[InlineData(8, 4, 16)]
[InlineData(3, 3, 4.5)]
[InlineData(12, 12, 72)]
[InlineData(100, 2, 100)]
[InlineData(1, 1, 0.5)]
[InlineData(7, 3, 10.5)]
[InlineData(9, 9, 40.5)]
[InlineData(15, 4, 30)]
[InlineData(2.5, 4, 5)]
[InlineData(5, 2.5, 6.25)]
[InlineData(10, 0.5, 2.5)]
[InlineData(50, 50, 1250)]
[InlineData(2, 100, 100)]
[InlineData(11, 5, 27.5)]
[InlineData(6, 6, 18)]
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
[InlineData(25, 10, 250)]
[InlineData(6, 5, 30)]
[InlineData(24, 2, 48)]
[InlineData(25, 4, 100)]
[InlineData(100, 1, 100)]
[InlineData(16, 10, 160)]
[InlineData(4.5, 2, 9)]
[InlineData(72, 10, 720)]
[InlineData(100, 5, 500)]
[InlineData(0.5, 10, 5)]
[InlineData(10.5, 2, 21)]
[InlineData(40.5, 10, 405)]
[InlineData(30, 3, 90)]
[InlineData(5, 4, 20)]
[InlineData(6.25, 2, 12.5)]
[InlineData(2.5, 10, 25)]
[InlineData(1250, 2, 2500)]
[InlineData(100, 0.5, 50)]
[InlineData(27.5, 2, 55)]
[InlineData(18, 3, 54)]
public void CalcularVolumenCubo_AreaYAlturaValidas_Correcto(double area, double Altura, double expected)
{
// Arrange
// Act
double actual = Figura262.Volumen(area, Altura);
// Assert
Assert.Equal(expected, actual);
}
}