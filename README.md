# **Os 4 pilares da Orientação a Objeto**

### Escrito por: Victor Souza  A.k.a _vhost_

## Primeiro pilar: **_Abstração_**

O conceito de Abstração se baseia em: Dado um objeto do mundo real, precisamos transformar suas características e os seus comportamentos, em propriedades e métodos no programa para realizar as tarefas necessárias que levam a resolução do meu problema, o qual originou a criação do meu programa. Muitas características deixam de ser representadas nesse processo de abstração, já que não serão sempre todas elas, necessárias para a execução do programa. 

Por exemplo, se quiséssemos representar nosso Cão em um programa de computador que late, corre atrás do rabo e pegar o jornal, como seria o código após o processo de abstração? Veja o exemplo abaixo:

```csharp 
//Criamos uma classe cão, que representa o nosso cão real.
class Cao
    {
        //Damos a ele propriedades de raça, tamanho e idade.
        public string Raca;

        public float Tamanho;

        public int Idade;

        //E os métodos de latir, correr atrás do rabo e pegar o jornal.
        public void Latir()
        {
            Console.Write("Woof!");
            Console.Read();
        }

        public void CorrerAtrasDoRabo()
        {
            Console.Write("Correndo!");
            Console.Read();
        }

        public void PegarOJornal()
        {
            Console.Write("Pegando!");
            Console.Read();
        }
    }

```
Perceba que não representamos todas as características do nosos cão, mas apenas as necessárias para podermos caracterizá-lo como um cão, como latir  e ter uma raça. Isso é a Abstração!

## Segundo pilar: **_Encapsulamento_**

O Encapsulamento, é o conceito de manter o funcionamento interno de determinado objeto, escondido, encapsulado, oferecendo uma interface para quem for utilizar as propriedades e métodos de determinado objeto. Por exemplo, para ler este artigo teve que ir até a página do **Github**, mas você não conhece o código que está por trás da página, os métodos e e propriedades que estão sendo utilizados, interagindo e sendo chamados, você simplesmente vê os textos, botões e links que estão na página, e essa é a idéia do encapsulamento, você fornecer um meio do usuário interagir com seu objeto sem que ele conheça e acesse os métodos e propriedades diretamente, utilizam uma interface desse objeto, getters e setters. Isso permite flexibiliade também, pois como o usuário utiliza uma interface oferecida, eu posso alterar a implementação de determinado método, ou tipo de propriedade, ou até adicionar um novo método ou propriedade sem que isso afete diretamente o usuário. Aprofundando, observe o exemplo de código abaixo: 

```csharp

    //Criamos uma interface IWebPage
    public interface IWebPage
    {
        string Link { get; set; }

        string Botao { get; set; }

        string Texto { get; set; }

        void FazerCadastro();

        void FazerLogin();
    }

```
Uma interface funciona como um contrato, todas as Classes que a implementam,
tem que possuir os métodos e propriedades que constam nessa interface. O ``` { get; set; } ```  serve para que toda vez que forem utilizar uma propriedade do objeto, não estarão acessando diretamente, mas sim através do método **GET** que retorna o valor da propriedade, e o método **SET** que altera o valor da propriedade para o valor especificado pelo usuário. Agora toda vez que esse objeto for ser utilzado deve estar encapsulado, onde a única referência exposta para o usuário será essa interface. 


Agora criamos uma classe que de fato contém a implementação da Interface
```csharp
    
    public class WebPage : IWebPage
    {   
        public string Link { get; set; }

        public string Botao { get; set; }

        public string Texto { get; set; }

        public void FazerLogin()
        {
            Console.Write("Fazendo login!");
            Console.Read();
        }

        public void FazerCadastro()
        {
            Console.Write("Fazendo cadastro!");
            Console.Read();
        }
    }


```

E agora instânciamos um objeto da classe Webpage, que será acessado através de sua interface.

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            IWebPage Webpage = new WebPage();
        }
    }
```
## Terceiro pilar: **_Herança_**

A Herança, no mundo da orientação a objeto, segue basicamente o mesmo conceito da herança no mundo real, vamos tomar por exemplo um pai e um filho, o filho herda caracteríticas do pai, talvez a cor dos olhos,a cor do cabelo ou a cor da pele, a mesma coisa se aplica na orientação a objeto. Temos um objeto pai, que tem suas propriedades e métodos, e se criamos um objeto filho que herda as características desse objeto pai, ele vai ter os mesmos métodos e propriedades que o seu objeto pai tem, podendo se estender , tendo suas próprias propriedades e métodos. Isso permite reusabilidade de código já que como eu posso utilizar herança para objetos que devem compartilhar das mesmas propriedades e métodos comuns entre eles, ao invés de reescrever todos eles para cada objeto que necessita desses métodos e propriedades. Observe: 

```csharp
 public class Humano
    {
        public string Nome { get; set; }

        public int  Idade { get; set; }

        public double Altura { get; set; }

        public void Falar()
        {
            Console.WriteLine($"Oi, meu nome é {this.Nome}");
            Console.ReadLine();

        }

        public void Andar()
        {
            Console.WriteLine("Andando!");
            Console.ReadLine();
        }
    }
```

Criamos uma classe **Humano** que tem seus métodos e características, mas se eu precisasse de um objeto **Homem**, ao invés de reescrever esse métodos e propriedades, posso fazê-lo herdar de **Humano**, já que todo homem é um humano, e me preocupar em apenas escrever os métodos e propriedades adicionais, específicas ao objeto **Homem**.

```csharp
 public class Homem : Humano
    {
        //Adicionamos uma propriedade booleana, para dizer se o nosso objeto Homem, tem ou não barba.
        public bool TemBarba { get; set; }
    }
```

E agora instânciamos nossos objetos e compreendemos o poder da herança:
```csharp
class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();

            humano.Nome = "Linus Torvalds";
            humano.Idade = 47;
            humano.Altura = 1.82;

            humano.Falar();
            humano.Andar();

            Homem homem = new Homem();
            
            homem.TemBarba = true;
            homem.Nome = "Linus Torvalds";
            homem.Idade = 47;
            homem.Altura = 1.82;

            homem.Falar();
            homem.Andar();
        }
    }
```
Repare que ambos objetos apresentam as mesmas propriedades e métodos, apenas o objeto **Homem** apresenta uma propriedade adicional, já que herda de **Humano**. 


## Quarto pilar: **_Polimorfismo_**

O Polimorfismo está conectado a herança, já que tem o conceito de que um método herdado, possa realizar uma ação diferente do seu comportamento original que vem do objeto pai. Pense que temos um objeto **Automóvel**, e que os objetos **Carro** e **Moto** herdem o comportamento **Freiar()**, sabemos que o modo que se freia um carro é diferente do modo que se freia uma moto, então precisamos que  método herdado tenha implementações diferentes, mas que mantenha o nome original. Esse é o conceito de polimorfismo, poder alterar o funcionamento interno de um método herdado sem alterar o seu nome. Veja no código abaixo como funciona: 

```csharp
 public class Automovel
    {
        public string Tipo { get; set; }

        public virtual void Freiar()
        {
            Console.WriteLine("Freiando");
            Console.ReadLine();
        }
    }
```
Criamos a classe **Automóvel** que contém o método **Freiar()**. A propriedade **_virtual_** adiciona ao método, diz que esse método pode ter sua implementação alterada ( _override_ ) nas classes que herdam esse comportamento.

```csharp
 public class Carro : Automovel
    {
        public override void Freiar()
        {
            Console.WriteLine("Apertando embreagem do carro");
            Console.WriteLine("Apertando freio do carro");
            Console.ReadLine();
            base.Freiar();
        }
    }
```
```csharp
  public class Moto : Automovel
    {
        public override void Freiar()
        {
            Console.WriteLine("Apertando freio da moto");
            Console.ReadLine();
            base.Freiar();
        }
    }
```

Criamos as classes **Carro** e **Moto**, alterando a implementação do método original, mas mantendo seu nome. Agora toda vez que formos utilizar o método **Freiar()**, em alguma classe que herda de Automóvel, podemos alterar sua implementação se for necessário ou manter a implementação original. Isso é Polimorfismo!

## Final

Espero que o Artigo tenha sido útil, e ajude a compreender um pouco mais desse vasto mundo da Programação Orientada a Objeto. 

Obrigado à todos os leitores.