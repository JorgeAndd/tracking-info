# TrackingInfo

Esse projeto apresenta um protótipo para um sistema de rastreio de encomendas para um e-commerce.

O projeto foi desenvolvido em .NET Core e Angular 8, utilizando como base o template disponibilizado pelo Visual Studio.

## Funcionalidades
O projeto tem como funcionalidades básicas:

 - Mostrar uma listagem de pedidos
 - Mostrar informação da última atualização do rastreio do pedido
 - Mostrar detalhes do pedido, incluindo número de rastreio, datas etapas do rastreio

# Backend

O backend do projeto é desenvolvido em C# com .NET Core.
A persistência de dados é feita com Firebase, por permitir uma rápida prototipação de estruturas de dados, utilizando formato JSON.

Para esse protótipo, foram criadas apenas chamadas GET, tanto para a partir do Backend para o Firebase, quanto do frontend para o Backend.

As principais funcionalidades do backend foram desenvolvidas com auxílio de testes unitários com framework **XUnit**

## Testes Unitários com XUnit
Foram desenvolvidos testes unitários básicos com *framework* XUnit.

Para auxiliar em alguns testes, foi criado um *mock* para o Firebase, retornando objetos json fixos condizentes com os testes a serem realizados.

## Frontend
O frontend foi desenvolvido utilizando **Angular** em sua versão 8.
Foram criados apenas dois componentes, para demonstrar as funcionalidades básicas do sistema: listagem de pedidos e detalhes do pedido.

O frontend realiza as comunicações com o backend por meio de chamadas REST, sendo no caso desse protótipo, exclusivamente com métodos GET.



# Execução do projeto
Para a execução do projeto, é necessário o Visual Studio, recomendando-se a versão 2019, seguindo os seguintes passos:

 - Clonar o projeto
 - Executar o comando `npm install` a partir da pasta **`TrackingInfo/ClientApp`**
 - Setar o projeto TrackingInfo como projeto padrão
 - Executar o projeto

# Desenvolvimentos Futuros

Como forma a melhorar o protótipo, as seguintes funcionalidades podem ser implementas:

 - Utilização de um banco de dados real, com estruturas mais bem definidas
 - Inserção de novos pedidos
 - Busca de pedidos de um determinado usuário
 - Detecção e alerta para pedidos em atraso
 - Utilização de API de rastreio (ex: Correios)
