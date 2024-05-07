namespace tp02_Bis_Brodsky;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        Superheroe superheroe1 = new Superheroe();
        Superheroe superheroe2 = new Superheroe();
        do {
            Console.WriteLine("1 --> Cargar Datos Superhéroe 1");
            Console.WriteLine("2 --> Cargar Datos Superhéroe 2");
            Console.WriteLine("3 --> Cometir!");
            Console.WriteLine("4 --> Salir");
            Console.WriteLine("5 --> Cambiar los valores de Velocidad y Fuerza");
            Console.WriteLine("6 --> Aleatorio");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    pedirDatos(superheroe1);
                    break;
                case 2:
                    pedirDatos(superheroe2);
                    break;
                case 3:
                    quienGano(superheroe1, superheroe2);
                    break;
                case 4:
                    Console.WriteLine("saliste");
                    break;
                case 5:
                    cambiarFueYVelo(superheroe1, superheroe2);
                    break;
                case 6:
                    AleatorioFueVelo(superheroe1, superheroe2);
                    Console.WriteLine(superheroe1.Fuerza);
                    break;
                default:
                    Console.WriteLine("Error, volver a ingresar");
                    break;
            }
        }while(menu != 4);
    }
    static void AleatorioFueVelo(Superheroe superheroe1, Superheroe superheroe2){
        bool puede = false;
        if (superheroe1.Nombre == null || superheroe2.Nombre == null){
            Console.WriteLine("error, hay uno o los dos que son nulos");
        }
        else{
            do {
                Console.WriteLine("ingrese un superheroe (1 o 2)");
                string super = Console.ReadLine();
                puede = int.TryParse(super, out int superInt);
                if (puede == true){
                    if (superInt != 1 && superInt != 2){
                        Console.WriteLine("error, no existe ese superheroe");
                    }
                    else if(superInt == 1){
                        superheroe1.Aleatorio();
                        quienGano(superheroe1, superheroe2);
                    }
                    else{
                        superheroe2.Aleatorio();
                        quienGano(superheroe1, superheroe2);
                    }
                }
                else{
                    Console.WriteLine("error");
                }
            }while(puede == false);
            
        }
    }
    static void cambiarFueYVelo(Superheroe superheroe1, Superheroe superheroe2){
        bool puede = false;
        if (superheroe1.Nombre == null || superheroe2.Nombre == null){
            Console.WriteLine("error, hay uno o los dos que son nulos");
        }
        else{
            do {
                Console.WriteLine("ingrese un superheroe (1 o 2)");
                string super = Console.ReadLine();
                puede = int.TryParse(super, out int superInt);
                if (puede == true){
                    if (superInt != 1 && superInt != 2){
                        Console.WriteLine("error, no existe ese superheroe");
                    }
                    else if(superInt == 1){
                        int fueOvelo = 0;
                        validarFueVeloInt(superheroe1, fueOvelo);
                        fueOvelo = 1;
                        validarFueVeloInt(superheroe1, fueOvelo);
                        quienGano(superheroe1, superheroe2);
                    }
                    else{
                        int fueOvelo = 0;
                        validarFueVeloInt(superheroe2, fueOvelo);
                        fueOvelo = 1;
                        validarFueVeloInt(superheroe2, fueOvelo);
                        quienGano(superheroe1, superheroe2);
                    }
                }
                else{
                    Console.WriteLine("error");
                }
            }while(puede == false);
            
        }
        
    }
    static void quienGano(Superheroe superheroe1, Superheroe superheroe2){
        if (superheroe1.Nombre == null || superheroe2.Nombre == null){
            Console.WriteLine("error, hay uno o los dos que son nulos");
        }
        else{
            if (superheroe1.ObtenerSkill() > superheroe2.ObtenerSkill()){
                double diferencia = superheroe1.ObtenerSkill() - superheroe2.ObtenerSkill();
                if (diferencia >= 30){
                    Console.WriteLine("Ganó " + superheroe1.Nombre +" por amplia diferencia");
                }
                else if (10 <= diferencia && diferencia < 30){
                    Console.WriteLine("Ganó " + superheroe1.Nombre +" ¡Fue muy parejo!");
                }
                else {
                    Console.WriteLine("Ganó " + superheroe1.Nombre +" ¡No le sobró nada!");
                }
            }
            else if (superheroe1.ObtenerSkill() < superheroe2.ObtenerSkill()){
                double diferencia = superheroe2.ObtenerSkill() - superheroe1.ObtenerSkill();
                if (diferencia >= 30){
                    Console.WriteLine("Ganó " + superheroe2.Nombre +" por amplia diferencia");
                }
                else if (10 <= diferencia && diferencia < 30){
                    Console.WriteLine("Ganó " + superheroe2.Nombre +" ¡Fue muy parejo!");
                }
                else {
                    Console.WriteLine("Ganó " + superheroe2.Nombre +" ¡No le sobró nada!");
                }
            }
            else{
                Console.WriteLine("Empataron!");
            }
        }
    }
    static void pedirDatos(Superheroe superheroe){
        Console.WriteLine("ingrese el nombre");
        superheroe.Nombre = Console.ReadLine();
        Console.WriteLine("ingrese la ciudad");
        superheroe.Ciudad = Console.ReadLine();
        bool puede = false;
        do {
            Console.WriteLine("ingrese el peso");
            string peso = Console.ReadLine();
            puede = double.TryParse(peso, out double pesoDouble);
            if (puede == true){
                superheroe.Peso = pesoDouble;
            }
            else{
                Console.WriteLine("error");
            }
        }while(puede == false);
        int fueOvelo = 0;
        validarFueVeloInt(superheroe, fueOvelo);
        fueOvelo = 1;
        validarFueVeloInt(superheroe, fueOvelo);
        fueOvelo = 2;
        validarFueVeloInt(superheroe, fueOvelo);

    }
    static void validarFueVeloInt(Superheroe superheroe, int fueOvelo){
        bool puede = false;
        do {
            if (fueOvelo == 0){
                Console.WriteLine("ingrese el fuerza");
            }
            else if (fueOvelo == 1){
                Console.WriteLine("ingrese la velocidad");
            }
            else{
                Console.WriteLine("ingrese la inteligencia");
            }
            string fuerza = Console.ReadLine();
            puede = double.TryParse(fuerza, out double fuerzaDouble);
            if (puede == true){
                if(fueOvelo == 0){
                    superheroe.Fuerza = fuerzaDouble;
                }
                else if (fueOvelo == 1){
                    superheroe.Velocidad = fuerzaDouble;
                }
                else{
                    superheroe.Inteligencia = fuerzaDouble;
                }
            }
            else{
                Console.WriteLine("error");
            }
        }while(puede == false);
    }
}
