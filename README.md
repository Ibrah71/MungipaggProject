# MungipaggProject

Controle de Acesso com Cartão RFID, após encostar o cartão no leitor de cartões que estará conectado a entrada GPIO na raspberry pi,
os dados são escritos em um arquivo.json na própria raspberry e em seguiada enviados para o banco de dados remoto MongoDb.


Requisito para o projeto funcionar:

1 Sensor RFID:
Este Kit módulo leitor RFID baseado no chip MFRC522 da empresa NXP é altamente utilizado em comunicação sem contato a uma frequência de 
13,56MHz. Este chip, de baixo consumo e pequeno tamanho, permite sem contato ler e escrever em cartões que seguem o padrão Mifare, 
muito usado no mercado.

Este Kit módulo leitor RFID possui as ferramentas que você precisa para um projeto de controle de acesso ou sistemas de segurança 
a um ótimo preço. As tags (ou etiquetas) RFID, podem conter vários dados sobre o proprietário do cartão, como nome e endereço e,
no caso de produtos, informações sobre procedência e data de validade, apenas para citar alguns exemplos.

2 Raspberry pi 3:
Um microcomputador com pinos  GPIO (General Purpose Input/Output são basicamente portas programáveis de entrada e saída de dados)
onde é possivel conectar sensores como o utilizado no projeto o sensor MFRC522.O raspberry utilizado no projeto roda o sistema Raspian

3 Notebook:
Será onde o banco de dados MongoDb estara rodando e onde a aplicação AspNetMvc estara rodando

4 Rede:
A rede seria para a transmissão dos dados lidos pelo sensor e poisteriomente enviados pelas raspberry para um banco de dados remoto.

______________________________________________________________________________________________________________________________

CAMADAS DO PROJETO MVC

1 Presentation:

1.1: Mundipagg.PontoDigital.Application = Fara Download em horário agendado do arquivo.json que está na raspbery pi e que contém o história de todos os dados
lidos pelo sensor

1.2: Mundipagg.PontoDigital.MVC =  Faz a interface entre Usuário e a camada de Aplicação, exibi na tela as requisições do usuario

2 Service:

2.1: Mundipagg.PontoDigital.Services.WebApi = Imaginando uma possivel extensão fiz essa camada para utilizar um WPF que consumiria os
dados do serviço, mas infelizmente não tive tempo criar o projeto WPF.

3 Aplication:

3.1 Mundipagg.PontoDigital.Application = Faz interface entre  o projeto MVC com Repositorio e dominio

3.2 Mundipagg.PontoDigital.Application.Teste = Projeto de teste que irá testar as validações da entidade funcionario

4 Dominio:

4.1 Mundipagg.PontoDigital.Domain = Contém as entidades e as regras de negócio.

5 Infra:

5.1 Mundipagg.PontoDigital.CrsossCutting = O projeto utiliza o framework SimpleInjector e faz a injeção de dependência no projeto MVC

5.2 Mundipagg.PontoDigital.Infra.Data = Onde as operações de CRUD realmente acontecem



