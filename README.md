# MungipaggProject

## GOALS:
Controle de Acesso com Cartão RFID, após encostar o cartão no leitor de cartões que estará conectado a entrada GPIO na raspberry pi,
os dados são escritos em um arquivo.json na própria raspberry e em seguiada enviados para o banco de dados remoto MongoDb.

## OVERVIEW:
O sensor RFID MFRC522 foi conectado a entrada GPIO da placa raspberry pi 3  a programação para comunicação com o sensor RFID foi feita
em python. A placa raspberry pi 3 envia os dados lido pelo sensor RFID através da linguagem python para o banco de dados mongoDb remoto
a aplicação mvc manipula o banco de dados mongoDb

## Requisito para o projeto funcionar:

- **Sensor RFID:**

<p align="center">
  <img width="460" height="300" src="https://user-images.githubusercontent.com/19213840/32897154-001294c4-cacc-11e7-8714-43241c6e79b2.jpg">
</p>

Este Kit módulo leitor RFID baseado no chip MFRC522 da empresa NXP é altamente utilizado em comunicação sem contato a uma frequência de 
13,56MHz. Este chip, de baixo consumo e pequeno tamanho, permite sem contato ler e escrever em cartões que seguem o padrão Mifare, 
muito usado no mercado.Este Kit módulo leitor RFID possui as ferramentas que você precisa para um projeto de controle de acesso ou sistemas de segurançaa um ótimo preço. As tags (ou etiquetas) RFID, podem conter vários dados sobre o proprietário do cartão, como nome e endereço, no caso de produtos, informações sobre procedência e data de validade, apenas para citar alguns exemplos.

- **Raspberry pi 3:**

<p align="center">
  <img width="460" height="300" src="https://user-images.githubusercontent.com/19213840/32895760-4c4186ba-cac8-11e7-8af1-15723f9b7ad2.jpg">
</p>

Um microcomputador com pinos  GPIO (General Purpose Input/Output são basicamente portas programáveis de entrada e saída de dados).O
GPIO foi utilizado conectar o sensor MFRC522 e a linguagem escolhida para comunicar o sensor foi python, o raspberry pi 3 possui sistema Raspian.

- **3 Notebook:**
Será onde o banco de dados MongoDb estara rodando e onde a aplicação AspNetMvc estara rodando

- **4 Rede:**
A rede seria para a transmissão dos dados lidos pelo sensor e poisteriomente enviados pelas raspberry para um banco de dados remoto.

______________________________________________________________________________________________________________________________

## Camadas do projeto MVC

- #### 1. Presentation:
   - **Mundipagg.PontoDigital.Application:** Fara Download em horário agendado do arquivo.json que está na raspbery pi e que contém o histórico de todos os dados lidos pelo sensor.
   -  **Mundipagg.PontoDigital.MVC:** Faz a interface entre Usuário e a camada de Aplicação, exibi na tela as requisições do usuario e os resultados da requisição.

- #### 2. Service:
   - **Mundipagg.PontoDigital.Services.WebApi:** Essa camada seria para utilizar um WPF que consumiria os dados do serviço, mas infelizmente não tive tempo criar o projeto WPF.

- #### 3. Aplication:
   - **Mundipagg.PontoDigital.Application:** Interface entre  o projeto MVC com Repositorio e dominio.
   - **Mundipagg.PontoDigital.Application.Teste:** Projeto de teste que irá testar as validações da entidade funcionário.

- #### 4. Dominio:
   - **Mundipagg.PontoDigital.Domain:** Contém as entidades e as regras de negócio.

- #### 5. Infra:
   - **Mundipagg.PontoDigital.CrsossCutting:** O projeto utiliza o framework SimpleInjector e realiza a injeção de dependência no projeto MVC.
  - **Mundipagg.PontoDigital.Infra.Data:** Onde as operações de CRUD realmente acontecem.




