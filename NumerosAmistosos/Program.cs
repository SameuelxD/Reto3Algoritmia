internal class Program
{
    private static void Main(string[] args)
    {
        var numero1 = 0;
        var numero2 = 0;
        var sumadiv1=0;
        var sumadiv2=0;
        for (int i = 1000; i <= 1500; i++)
        {
            numero1 = i;
            if (i!=numero1)
            {
                numero2=i;
            }
            for(int j=1;j<=1500;j++){
                if(numero1%j==0 && j!=numero1){
                    sumadiv1=sumadiv1+j;
                    if(numero2%j==0 && j!=numero2){
                        sumadiv2=sumadiv2+j;
                        if(sumadiv1==numero2 && sumadiv2==numero1){
                            Console.WriteLine($"Los numeros {numero1} y {numero2} son amigables");

                        }
                    }
                }
            }



        }
    }



}
