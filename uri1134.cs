using System; 

class URI {

    static void Main(string[] args) { 

    int gasolina, diesel, alcool, x;
    
    alcool =0;
    gasolina=0;
    diesel=0;
    
     x = int.Parse(Console.ReadLine());
     
    while (x!=4){
        
        if(x == 1){
            alcool++;
        }
        
            else if(x == 2){
            gasolina++;
        }
        
            else if(x == 3){
            diesel++;
        }
         
            x = int.Parse(Console.ReadLine());
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: "+alcool);
Console.WriteLine("Gasolina: "+gasolina);
Console.WriteLine("Diesel: "+diesel);


    }

}