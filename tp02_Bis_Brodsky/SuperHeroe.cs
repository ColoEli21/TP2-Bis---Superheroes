class Superheroe{
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public double Peso {get; set;}
    public double Fuerza {get; set;}
    public double Velocidad {get; set;}
    public double Inteligencia {get; set;}
    public Superheroe(){
        
    }

    public Superheroe(string nom, string ciu, double pe, double fue, double velo, double inte){
        Ciudad = ciu;
        Nombre = nom;
        Peso = pe;
        Fuerza = fue;
        Velocidad = velo;
        Inteligencia = inte;
    }

    public double ObtenerSkill(){
        Random random = new Random();
        int numeroAleatorio = random.Next(0, 10);
        return Velocidad * 0.6 + Fuerza * 0.8 * numeroAleatorio * Inteligencia * 0.25;
    }
    public void Aleatorio(){
        Random random = new Random();
        Velocidad = random.Next(0, 100);
        Random random2= new Random();
        Fuerza = random2.Next(0, 100);
    }
}