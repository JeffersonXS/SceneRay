# SceneRay

### GitHub dos itegrantes

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
