# **Os 4 pilares da Orientação a Objeto**

### Escrito por: Victor Souza  A.k.a _vhost_

## Primeiro pilar: **_Abstração_**

O conceito de Abstração se baseia em: Dado um objeto do mundo real, precisamos transformar suas características e os seus comportamentos, em propriedades e métodos no programa para realizar as tarefas necessárias que levam a resolução do meu problema, o qual originou a criação do meu programa. Muitas características deixam de ser representadas nesse processo de abstração, já que não serão sempre todas elas, necessárias para a execução do programa. 

Por exemplo, se quiséssemos representar nosso Cão em um programa de computador que late, corre atrás do rabo e pega o jornal, como seria o código após o processo de abstração? Veja o exemplo abaixo:

```csharp 
    public abstract class Cao
    {
        public string Raca;

        public string Nome;

        public int Idade;

        abstract public void Latir();

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
Criamos uma classe **Abstrata**, classes abstratas servem como um modelo, ela significa que basicamente todo objeto que for um tipo de cão, deverá seguir seu modelo, e ter sua própria implementação do método **Latir()** que está marcado como método abstrato, se quiséssemos criar um Bulldog seria assim que faríamos:

```csharp
 public class BullDog : Cao
    {
        public override void Latir()
        {
            Console.Write("auf auf!");
            Console.Read();
        }
    }
```

Criamos nosso BullDog que **herda** ( Explicarei herança mais a frente nesse artigo ) de Cão, ou seja tem todos os métodos e propriedades de um cão, mas tem seu próprio jeito de latir, pois com certeza um Bulldog late diferente de um Shit-tzu. 

A Abstração é isso, você observar algo real, e criar uma implementação em código, com propriedades e métodos o suficiente para que ele possa realizar as tarefas necessárias.

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
tem que possuir os métodos e propriedades que constam nessa interface. O ``` { get; set; } ```  serve para que toda vez que forem utilizar uma propriedade do objeto, não estarão acessando diretamente, mas sim através do método **GET** que retorna o valor da propriedade, e o método **SET** que altera o valor da propriedade para o valor especificado pelo usuário. Agora toda vez que esse objeto for ser utilizado deve estar encapsulado, onde a única referência exposta para o usuário será essa interface. 


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

A Herança, no mundo da orientação a objeto, segue basicamente o mesmo conceito da herança no mundo real, vamos tomar por exemplo um pai e um filho, o filho herda caracteríticas do pai, talvez a cor dos olhos, a cor do cabelo ou a cor da pele, a mesma coisa se aplica na orientação a objeto. Temos um objeto pai, que tem suas propriedades e métodos, e se criamos um objeto filho que herda as características desse objeto pai, ele vai ter os mesmos métodos e propriedades que o seu objeto pai tem, podendo se estender , tendo suas próprias propriedades e métodos. Isso permite reusabilidade de código já que como posso utilizar herança para objetos que devem compartilhar das mesmas propriedades e métodos comuns entre eles, ao invés de reescrever todos eles para cada objeto que necessita desses métodos e propriedades. Observe: 

```csharp
  public class Humano
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public double Altura { get; set; }

        public Humano(string nome, int idade, double altura)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
        }

        public void Falar()
        {
            Console.WriteLine($"Ola meu nome e {this.Nome}");
            Console.ReadLine();
        }
       
        public void Andar()
        {
            Console.WriteLine("Andando!");
            Console.ReadLine();
        }

    }
```

Criamos uma classe **Humano** que tem seus métodos e características e um construtor, que diz: _"Toda vez que for instânciado um **Humano**, é preciso fornecer um **Nome,Idade e Altura**, pois sem isso o objeto não é um **Humano**"_. Se eu precisasse de um objeto **Homem**, ao invés de reescrever esse métodos e propriedades, posso fazê-lo herdar de **Humano**, já que todo homem é um humano, e me preocupar em apenas escrever os métodos e propriedades adicionais, específicas ao objeto **Homem**.

```csharp
 public class Homem : Humano
    {
        //Adicionamos uma propriedade booleana, para dizer se o nosso objeto Homem, tem ou não barba.
        public bool TemBarba { get; set; }
    }
```

E agora instânciamos nossos objetos e compreendemos o poder da herança:
```csharp
 public class Homem : Humano
    {
        public Homem(string nome, int idade, double altura):base(nome, idade, altura) {
        }
        
        public bool TemBarba { get; set; }
    }
```
Repare que ambos objetos apresentam as mesmas propriedades, métodos e um construtor, o objeto **Homem** apresenta uma propriedade adicional, pois **Homem** tem características específicas que se estende além das fornecidas do humano.

### _Um olhar mais profundo: **O modificador Abstract**_

O modificador **Abstract** quando usado em classes, diz que aquela classe é como um modelo, e não pode ser instânciada, a classe contém métodos e propriedades, mas ela exige ser herdada para que exista uma implementação concreta dos métodos e propriedades. Quando o modificador **Abstract** é utilizado em método, o método não tem corpo na classe abstrata ele requer que toda classe que herda dessa classe abstrata, tenha a implementação concreta do método. Observe o método latir da nossa classe Cão. 

```csharp
 abstract public void Latir();

 public override void Latir()
        {
            Console.Write("auf auf!");
            Console.Read();
        }
```

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
Criamos a classe **Automóvel** que contém o método **Freiar()**. A propriedade **_virtual_** adicionada ao método, diz que esse método pode ter sua implementação alterada ( sofrer um _override_ ) nas classes que herdam esse comportamento.

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