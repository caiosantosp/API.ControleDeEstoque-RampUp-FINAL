# **Olá, como você está?**

Este projeto tem como objetivo a construção de um sistema para controle estoque de uma loja qualquer. Esse site foi criado, pensando como base em uma loja de roupas.



Para usar a api por favor use esse link utilizando as Endpoints abaixo:
**https://apicontroledeestoquev3beta.herokuapp.com/**



Os principais Endpoints da API são:

- GET:
- 
  *Link/api/Produtos* | **Retorna todos os produtos cadastrados.**
  
  *Link/api/Produtos/QuantidadeTotalDoEstoque* | **Retorna a quantidade total de itens no estoque.**
  
  *Link/api/Produtos/TotalDeVendasDosProdutos* | **Retorna a quantidade total de vendas dos produtos.**
  
  *Link/api/Produtos/TotalDeComprasDosProdutos* | **Retorna a quantidade total de compras dos produtos.**
  
  *Link/api/Produtos/DezUltimosProdutosAdicionados* | **Retorna os dez ultimos produtos vendidos.**
  
  *Link*/api/Produtos/{id} | **Retorna um produto buscando pelo ID.**
  
  <br>
  
- POST:
- 
  *Link/api/Produtos* | **Adiciona um novo produto.**
  
  <br>
  
- PUT:
- 
  *Link/api/Produtos/{id}* | **Edita um produto pelo ID.**
  
  <br>
  
- DELETE:
- 
  *Link/api/Produtos/{id}* | **Deleta um produto pelo ID.**

<br>

***OBS:** Caso você se depare com algum erro, não hesite em me chamar nas redes sociais abaixo.*



Projeto desenvolvido utilizando como base a linguagem <b>C#</b> e os seguintes frameworks:

- Microsoft Entity Framework
- Pomelo Entity Framework
- AspNetCore
- MySql

 <br>

O sistema foi hospedado no site do **Heroku**. Por não haver compatibilidade completa do **Heroku** com a linguagem C# eu utilizei o sistema de container, onde criei uma imagem **Docker** de toda a API e seus endpoints.



Caso o sistema apresente alguma demora ou travamento, se deve ao fato de todas as ferramentas utilizadas serem gratuitas, o que limita muito no desempenho. Por favor, cuidado com a quantidade de requisições e não realize teste de estress.



Para verificar a construção do sistema da interface que utiliza a API, acesse o seguinte repositório:
\- **https://github.com/caiosantosp/Interface.ControleDeEstoque-V3-BETA/**



Qualquer duvida ou sugestão, favor entrar em contato comigo nas seguintes redes:
LinkedIn:https://www.linkedin.com/in/caiosantosportugal/

GitHub:https://github.com/caiosantosp

E-mail: caiosantos.portugal@hotmail.com

 <br>

# -- ATENÇÃO --



## Ao utilizar a API:

1. Não utilize essa API em seu sistema. Qualquer pessoa pode ver esses dados.

2. Não utilize essa API de maneira comercial. O sitema está sujeito a falhas, podendo ser acessado por pessoas não autorizadas.

3. A API não está validada por nenhum serviço de segurança. Qualquer falha de segurança na API não será de responsabilidade do criador.

4. API ainda em construção, podendo ser atualizada diversas vezes.
 

 <br>
OBS: *Só garanto a segurança da API após minha pós em segurança*. :satisfied::satisfied::satisfied:
