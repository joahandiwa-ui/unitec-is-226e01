using System.Reflection;

namespace Application.IntegrationTest;

public class UnitTestIntegrationTestApplication
{
    [Theory]
    [InlineData(4, 4, 64)] // Lado 4 -> Area 16 * Altura 4 = Volumen 64
    [InlineData(5, 6, 150)]// Lado 5 -> Area 25 * Altura 6 = Volumen 150}
    [InlineData(10, 5, 10, 250)]
    [InlineData(4, 3, 5, 30)]
    [InlineData(6, 8, 2, 48)]
    [InlineData(5, 10, 4, 100)]
    [InlineData(20, 10, 1, 100)]
    [InlineData(8, 4, 10, 160)]
    [InlineData(3, 3, 2, 9)]
    [InlineData(12, 12, 10, 720)]
    [InlineData(100, 2, 5, 500)]
    [InlineData(1, 1, 10, 5)]
    [InlineData(7, 3, 2, 21)]
    [InlineData(9, 9, 10, 405)]
    [InlineData(15, 4, 3, 90)]
    [InlineData(2.5, 4, 4, 20)]
    [InlineData(5, 2.5, 2, 12.5)]
    [InlineData(10, 0.5, 10, 25)]
    [InlineData(50, 50, 2, 2500)]
    [InlineData(2, 100, 0.5, 50)]
    [InlineData(11, 5, 2, 55)]
    [InlineData(6, 6, 3, 54)]
    public void CalcularVolumenCubo_IntegradoAreaCuadrado_Correcto(double lado,  double Altura, double expected)
    {
        // Arrange - Setup
        // Obtenemos un dato real del Componente A.
        double area = Triangulo.Area(lado) ;

        // Act - Perform
        // Le pasamos ese dato real al Componente B.
        double actual = Triangulo.Volumen(area, Altura) ;

        // Assert - Verify
        // Verificamos si el flujo completo produjo el resultado correcto
        Assert.Equal(expected, actual, 1) ;

    }
}
