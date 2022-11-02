using System;

public class calculadora
{
    private int num1;
    private int num2;

    public numero()
	{
    }	
	public global::System.Int32 Num1 { get => num1; set => num1 = value; }
	public global::System.Int32 Num2 { get => num2; set => num2 = value; }

    public int dividir()
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
	    return "No se puede dividir entre 0";
        }
    }

}
