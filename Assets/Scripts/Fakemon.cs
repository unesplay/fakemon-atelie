public class Fakemon
{
    protected string nome;
    protected string autor;

    protected Tipos_Mon tipo, tipoSec;

    protected Atributos_Fakemon atributos;

    protected Moveset_Fakemon moveset;


    public Fakemon(
        string nom, string aut, 
        Tipos_Mon tp, Tipos_Mon tps,
        int vd, int atk, int def, int vel,
        Movimento moveA, Movimento moveB, Movimento moveC, Movimento moveD 
    ) {
        Nome = nom;
        Autor = aut;

        Tipo = tp;
        TipoSec = tps;

        atributos = new Atributos_Fakemon(9, vd, atk, def, vel);

        moveset = new Moveset_Fakemon(moveA, moveB, moveC, moveD);
    }


    public string Nome { get => nome; set => nome = value ?? nome; }
    public string Autor { get => autor; set => autor = value ?? autor; }

    public Tipos_Mon Tipo { get => tipo; set => tipo = value; }
    public Tipos_Mon TipoSec { get => tipoSec; set => tipoSec = value; }

    public Atributos_Fakemon Atributos { get => atributos; }

    public Moveset_Fakemon Moveset { get => moveset; }
}


public class Atributos_Fakemon
{
    protected int vida, ataque, defesa, velocidade;
    protected int limite;


    public Atributos_Fakemon(int lim, int vd, int atk, int def, int vel)
    {
        limite = lim;
        Vida = vd;
        Ataque = atk;
        Defesa = def;
        Velocidade = vel;
    }


    public int Vida { get => vida; set => vida = (value >= 1 && value <= limite) ? value : vida; }
    public int Ataque { get => ataque; set => ataque = (value >= 1 && value <= ataque) ? value : ataque; }
    public int Defesa { get => defesa; set => defesa = (value >= 1 && value <= defesa) ? value : defesa; }
    public int Velocidade { get => velocidade; set => velocidade = (value >= 1 && value <= velocidade) ? value : velocidade; }
}


public class Moveset_Fakemon
{
    protected Movimento moveA, moveB, moveC, moveD;


    public Moveset_Fakemon(Movimento a, Movimento b, Movimento c, Movimento d)
    {
        MoveA = a;
        MoveB = b;
        MoveC = c;
        MoveD = d;
    }


    public Movimento MoveA { get => moveA; set => moveA = value ?? moveA; }
    public Movimento MoveB { get => moveB; set => moveB = value ?? moveB; }
    public Movimento MoveC { get => moveC; set => moveC = value ?? moveC; }
    public Movimento MoveD { get => moveD; set => moveD = value ?? moveD; }
}


public class Movimento
{
    protected string nome;
    protected Tipos_Mon tipo;
    protected int poder;
    protected string descricao;


    public Movimento(string nm, Tipos_Mon tp, int pow, string desc)
    {
        // nao usa setter pq NAO TEM
        this.nome = nm;
        this.tipo = tp;
        this.poder = pow;
        this.descricao = desc;
    }


    public string Nome { get => nome; }
    public Tipos_Mon Tipo { get => tipo; }
    public int Poder { get => poder; }
    public string Descricao { get => descricao; }
}