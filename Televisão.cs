public class Televisao
{ 
    public Televisao(float tamanho)
 { 
    Tamanho = tamanho;
 }
 public void AumentarVolume()
{
    Volume = Volume + 1;
    
}

    public float Tamanho {get; set;}
    public int Resolucao {get; set;}
    public int Volume {get; set; }
    public int Canal { get; set; }
    public bool Estado {get; set;}
}  
