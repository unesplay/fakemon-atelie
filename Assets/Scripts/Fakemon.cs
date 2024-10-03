public class Fakemon
{
    protected string nome;
    protected string autor;

    protected Tipos_Mon tipo, tipoSec;

    private int vida, ataque, defesa, velocidade;

    private string moveA, moveB, moveC, moveD;

    public string Nome { get => nome; set => nome = value ?? nome; }
    public string Autor { get => autor; set => autor = value ?? autor; }

    public Tipos_Mon Tipo { get => tipo; set => tipo = value ?? tipo; }
    public Tipos_Mon TipoSec { get => tipoSec; set => tipoSec = value; }

    public int AtribVida { get => vida; set => vida = (value >= 1 && value <= 9) ? value : vida; }
    public int AtribAtaque { get => ataque; set => ataque = (value >= 1 && value <= 9) ? value : ataque; }
    public int AtribDefesa { get => defesa; set => defesa = (value >= 1 && value <= 9) ? value : defesa; }
    public int AtribVeloci { get => velocidade; set => velocidade = (value >= 1 && value <= 9) ? value : velocidade; }

    public string MoveA { get => moveA; set => moveA = value ?? moveA; }
    public string MoveB { get => moveB; set => moveB = value ?? moveB; }
    public string MoveC { get => moveC; set => moveC = value ?? moveC; }
    public string MoveD { get => moveD; set => moveD = value ?? moveD; }
}



