public class Calculadora
{
    double memoria = 0;
    //metodo de calculadora con memoria caso SUMA//
    public double sumar (double sumando1)
    {
        memoria = memoria + sumando1
        return memoria;      
    }
    public double sumar (double sumando1, double sumando2)
    {
        memoria = sumando1 + sumando2 
        return memoria;
    }
    //metodo de calculadora con memoria caso RESTA//
    public double restar (double resta1)
    {
        memoria = memoria + resta1
        return memoria;      
    }
    public double restar (double resta1, double resta2)
    {
        memoria = resta1 + resta2 
        return memoria;
    }
     //metodo de calculadora con memoria caso Multiplicacion//
    public double multiplicar (double multiplicado1)
    {
        memoria = memoria + multiplicado1
        return memoria;      
    }
    public double multiplicar (double multiplicado1, double multiplicado2)
    {
        memoria = multiplicado1 + multiplicado2 
        return memoria;
    }
    //metodo de calculadora con memoria caso Raiz Cuadrada//
     public double raiz (double raiz1)
    {
        memoria = Math.Sqrt(raiz1); 
        return memoria;
    }
}