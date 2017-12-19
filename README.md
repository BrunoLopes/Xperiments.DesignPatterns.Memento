##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Memento 

> Memento é um padrão de projeto de software documentado no Catálogo Gang of Four, sendo considerado como um padrão comportamental. Ele permite armazenar o estado interno de um objeto em um determinando momento, para que seja possível retorná-lo a este estado, sem que isso cause problemas com o encapsulamento.

> Ele funciona de maneira que uma classe é responsável por salvar o estado do objeto desejado enquanto que uma outra classe fica responsável por armazenar todas essas copias (mementos).

> O padrão Memento é implementado se utilizando de três elementos: Originador, Armazenador e o Memento.

### Motivação

> O Padrão Comportamental Memento possui uma grande gama de aplicações onde é necessário a recuperação de um estado anterior de um objeto como um todo, qualquer tipo de editor precisa oferecer uma maneira de desfazer ações como restaurar imagens, textos etc. Para isso, o padrão Memento procura recuperar o estado anterior dessas ações e copiar os mesmos para um objeto a ser restaurado.

### Participantes:
Três objetos estão envolvidos na implementação do padrão Memento.
###### Originador:
 é o objeto cujo estado se deseja capturar.
###### Memento:
responsável por armazenar o estado interno do objeto Originador.
###### Armazenador:
é o objeto que acessará o originador, e deseja desfazer qualquer mudança efetuada, caso necessário.
ele é responsável por armazenar todos os Mementos.
os Mementos devem ser recuperados de maneira LIFO (Last In First Out) onde o ultimo adicionado será o primeiro a ser recuperado.
O Armazenador deve requisitar um objeto memento, antes de se valer do originador. Após efetuar as operações desejadas no originador, o cliente devolve a este o objeto memento, caso deseje desfazer qualquer alteração.

>O objeto memento não permite o acesso de qualquer classe além da classe originador. Assim, tal padrão mostra-se útil por não violar o conceito de encapsulamento.

### Funcionamento
> O objeto representado na classe Originador cria um novo memento a partir de si próprio, é ele que vai controlar toda a execução do Padrão Memento, criando uma nova instância da classe Armazenador, sempre que haja alguma modificação derivada de ações do sistema e de seu funcionamento padrão, o Originador irá criar um novo Memento, externalizando seu estado interno para um novo objeto que se tornará o Memento que será armazenado para posterior restauração. Além dos métodos e atributos próprios do objeto a ser restaurado, o Originador conta com um atributo que represente o estado atual do mesmo, métodos para definir e atribuir o estado, e métodos para salvar e solicitar o estado a partir do Memento.

> Com o estado salvo no Objeto Memento, o Originador volta suas atenções para o Armazenador, quando o método que aciona a ação de modificação é invocado, o Memento é criado e adicionado no Armazenador, que, a partir de agora guardará os Mementos em uma pilha, usando o LIFO, para tanto, o Armazenador possui uma lista do tipo do Memento, possui métodos para adicionar um novo Memento e para acessar o ultimo adicionado na pilha do Armazenador, quando o ultimo for retirado, o topo da lista será o Memento com o estado anterior ao que foi solicitado, e assim por diante, até que não haja mais Mementos para serem acessados, nesse momento deve ser lançada uma exceção.
![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Interpreter_design_pattern.png/220px-Interpreter_design_pattern.png)

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Interpreter`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT 2017 © 
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 
