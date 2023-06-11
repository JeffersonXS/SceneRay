# SceneRay

### GitHub dos integrantes

Jefferson Bispo da Silva:
> GitHub [@JeffersonXS](https://github.com/JeffersonXS) &nbsp;&middot;&nbsp;

Lucas Barreto Barbosa:
> GitHub [@LucasBarbosa22](https://github.com/LucasBarbosa22) &nbsp;&middot;&nbsp;

---
### Explicação da cena 

<h4 align ="center">
  Criamos uma cena de mira bem básica no unity, sendo assim, nessa cena foi preciso a utilização de raycast para podermos definir os inimigos a serem derrotados.
</a></h4>
  
* Cenário

  - O ambiente é um local desértico, no qual o sol já está indo embora e a noite prestes a chegar;
  - Nesse lugar nosso personagem treina sua mira com objetos;
  - A cada vez que ele acerta os objetos, vão aparecendo mais em lugares aleatórios dentro do seu campo de visão;
  - É um campo de treino de mira a céu aberto, longe da civilização.

<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/23e1cc3d-9dd6-4fab-8ec3-874c7120bc67" width ="900" </a>
  <br>
</h1>
  
---
* Conceitos de progamação aplicados
  - Raycast;
  - Destroy;
  - Skybox Processual;
  - Directional Light;
  - Scripts de movimentação e câmera;
  - Prefab.

### Raycast

  Utilizamos do raycast para definirmos os inimigos e assim criar uma trajetória do nosso personagem até o inimigo. Colocamos uma mira com um canvas, para realmente mostrar se era inimigo ou não, se fosse mostraria a seguinte mensagem no terminal da unity: "hit something". Se não fosse apareceria: "hit nothing".
<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/e8c877ba-203c-471b-8e41-c52223748801" width ="900" </a>
  <br>
</h1>
  
<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/6a2d2550-4eb9-4fd9-9821-db3e9563270c" width ="900" </a>
  <br>
</h1>
    
### Destroy

  O "destroy" também faz parte do raycast, porque assim que é definido um inimigo, é usado o destroy para acabar com tal.

### Skybox Processual

  Aqui ajeitamos a visão do céu, arrumamos sua iluminação/coloração, para coloca ela no céu da cena, utilizamos a opção Environment do lighting localizado no rendering que fica na barra de atalhos Window do unity.

### Directional Light

A "Directional Light" foi usa para a iluminação do cenário, para definirmos uma iluminação mais direta e ficar esse aspecto de pôr do sol. Ao todo ultilizamos 3 delas, uma no céu(con a Skybox) e duas na direção do chão, para aspecto de degradê e um pouco mais claro

### Movimentação e câmera

Criamos dois scripts uma para a movimentação básica do personagem como pulo e se mover livremente, tanto na diagonal quanto horizontal e vertical. E outro script foi para ter a câmera em primeira pessoa com liberdade de olhar para diversos cantos.

### Prefab

Foi necessário o "prefab" para fazer com que diversos inimigos surgissem em locais aleatórios sem poluir muito a tela. Então criamos um script para definir os locais aleatórios que e a quantidade e interligamos com o destroy, pois assim que um for destuído o outro aparece.

<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/7516b471-3844-40ac-9a93-1b6444d86bcf" width ="900" </a>
  <br>
</h1>    
